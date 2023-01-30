/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.API.Constants;
using Astrana.Core.Configuration;
using Astrana.Core.Constants;
using Astrana.Core.Data.DependencyInjection;
using Astrana.Core.DependencyInjection;
using Astrana.Core.Domain.DependencyInjection;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.Idp;
using Astrana.Core.Domain.Models.AstranaApi.Responses;
using Astrana.Core.Utilities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Serilog;
using System.Net.Mime;
using System.Text.Json.Serialization;
using ApiConstants = Astrana.Core.Constants.Api;

namespace Astrana.Core.API
{
    public class ProgramBuilder
    {
        private static readonly Version AssemblyVersion = VersionUtility.GetVersion(typeof(ProgramBuilder));
        private static readonly ApiVersion CurrentApiVersion = new(AssemblyVersion.Major, AssemblyVersion.Minor);
        private static readonly string CurrentApiVersionLabel = CurrentApiVersion.MajorVersion + "." + CurrentApiVersion.MinorVersion;

        private readonly IConfiguration _configuration;
        private readonly IIdpManager _idpManager;

        public ProgramBuilder()
        {
            _configuration = new ConfigurationBuilder().AddProtectedJsonFile("appsettings.json").Build();
            
            _idpManager = GetServiceProvider().GetRequiredService<IIdpManager>();
        }

        /// <summary>
        /// Configures a Web Application Builder
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public WebApplicationBuilder ConfigureWebApplicationBuilder(WebApplicationOptions options)
        {
            var builder = WebApplication.CreateBuilder(options);

            builder.Configuration.Sources.Clear();
            builder.Configuration.AddProtectedJsonFile("appsettings.json", false);

            builder.Logging.ClearProviders();

            builder.Host.UseSerilog((hostContext, loggerConfiguration) =>
            {
                loggerConfiguration.ReadFrom.Configuration(hostContext.Configuration);
            });

            builder.Services.AddCoreServices(builder.Configuration);
            builder.Services.AddDataServices(builder.Configuration);
            builder.Services.AddDomainServices(builder.Configuration);

            // Add services to the container.
            builder.Services.AddControllers().ConfigureApiBehaviorOptions(apiBehaviorOptions =>
            {
                apiBehaviorOptions.InvalidModelStateResponseFactory = context =>
                {
                    var result = new BadRequestObjectResult(new ApiResponse<dynamic>(null, ApiResponseMessages.DefaultValidationResponseMessage, context.ModelState.Select(kv => new ApiResponseFailedItem
                    {
                        ItemId = kv.Key, 
                        Message = kv.Value?.Errors.FirstOrDefault()?.ErrorMessage ?? string.Empty

                    }).ToList()));

                    result.ContentTypes.Add(MediaTypeNames.Application.Json);

                    return result;
                };

            }).AddJsonOptions(jsonOptions =>
            {
                jsonOptions.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
                jsonOptions.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());

            }).PartManager.ApplicationParts.Add(new AssemblyPart(typeof(ProgramBuilder).Assembly));

            builder.Services.AddHttpContextAccessor();

            if (builder.Environment.IsDevelopment())
            {
                // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
                builder.Services.AddEndpointsApiExplorer();
                builder.Services.AddSwaggerGen(swaggerGenOptions =>
                {
                    swaggerGenOptions.EnableAnnotations();

                    swaggerGenOptions.IgnoreObsoleteActions();

                    swaggerGenOptions.SwaggerDoc("v" + CurrentApiVersionLabel, new OpenApiInfo
                    {
                        Version = CurrentApiVersionLabel,
                        Title = $"{Application.Name} Web API",
                        Description = $"{Application.Name} Web API",
                        TermsOfService = new Uri($"https://{Application.WebsiteUrl}/legal"),

                        Contact = new OpenApiContact
                        {
                            Name = Application.Name,
                            Email = string.Empty,
                            Url = new Uri($"https://{Application.WebsiteUrl}/contact")
                        },

                        License = new OpenApiLicense
                        {
                            Name = $"{Application.Name} License",
                            Url = new Uri($"https://{Application.WebsiteUrl}/license")
                        }
                    });

                    // Set the comments path for the Swagger JSON and UI.
                    var xmlFile = $"{typeof(ProgramBuilder).Assembly.GetName().Name}.xml";
                    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                    swaggerGenOptions.IncludeXmlComments(xmlPath);

                    swaggerGenOptions.AddSecurityDefinition(ApiConstants.AuthorizationSchemeName.Bearer, new OpenApiSecurityScheme
                    {
                        Name = "Authorization",
                        Type = SecuritySchemeType.ApiKey,
                        Scheme = ApiConstants.AuthorizationSchemeName.Bearer.ToLower(),
                        BearerFormat = ApiConstants.BearerAuthorizationFormat.Jwt,
                        In = ParameterLocation.Header,
                        Description = $"JWT Authorization header using the {ApiConstants.AuthorizationSchemeName.Bearer} scheme."
                    });

                    swaggerGenOptions.AddSecurityRequirement(new OpenApiSecurityRequirement
                    {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = ApiConstants.AuthorizationSchemeName.Bearer
                            },
                            Scheme = ApiConstants.AuthorizationSchemeName.Bearer,
                            Name = ApiConstants.AuthorizationSchemeName.Bearer,
                            In = ParameterLocation.Header
                        },
                        Array.Empty<string>()
                    }
                    });
                });
            }

            builder.Services.AddMvc();

            builder.Services.AddApiVersioning(o =>
            {
                o.ReportApiVersions = true;
                o.AssumeDefaultVersionWhenUnspecified = true;
                o.DefaultApiVersion = CurrentApiVersion;

                o.ApiVersionReader = new HeaderApiVersionReader(ApiConstants.HeaderNames.ApiVersion);
            });

            builder.Services.AddCors(corsOptions =>
            {
                corsOptions.AddPolicy(name: "PublicExternal",
                    corsPolicyBuilder =>
                    {
                        corsPolicyBuilder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
                    });
            });

            builder.Services.AddRouting(routeOptions => routeOptions.LowercaseUrls = true);

            builder.Services.AddAuthentication(authenticationOptions =>
            {
                authenticationOptions.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                authenticationOptions.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                authenticationOptions.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(jwtBearerOptions =>
            {
                jwtBearerOptions.SaveToken = true;
                jwtBearerOptions.TokenValidationParameters = new()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = _idpManager.GetIdpIssuer(),
                    ValidAudience = _idpManager.GetIdpAudience(),
                    IssuerSigningKey = _idpManager.GetIdpIssuerSigningKey()
                };
            });

            builder.Services.AddAuthorization(authorizationOptions =>
            {
                authorizationOptions.FallbackPolicy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
            });

            return builder;
        }

        public WebApplication Build(WebApplicationBuilder builder)
        {
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseSwagger();
                app.UseSwaggerUI(options =>
                {
                    options.DocumentTitle = $"{Application.Name} Web API v{CurrentApiVersionLabel}";
                    options.SwaggerEndpoint($"/swagger/v{CurrentApiVersionLabel}/swagger.json", $"{Application.Name} API v{CurrentApiVersionLabel}");
                    options.RoutePrefix = ApiConstants.RoutePrefix;

                    options.InjectStylesheet($"/{ApiConstants.Swagger.SwaggerUiDirectoryName}/override.css");
                    options.InjectJavascript($"/{ApiConstants.Swagger.SwaggerUiDirectoryName}/override.js");
                });

                app.UseStaticFiles(new StaticFileOptions
                {
                    FileProvider = new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, $"wwwroot/{ApiConstants.Swagger.SwaggerUiDirectoryName}")),
                    RequestPath = $"/{ApiConstants.Swagger.SwaggerUiDirectoryName}"
                });
            }
            else
            {
                app.UseExceptionHandler("/Error");

                // The default HSTS value is 30 days.
                // TODO: You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            return app;
        }

        private ServiceProvider GetServiceProvider()
        {
            return new ServiceCollection()
                .AddScoped(_ => _configuration)
                .AddLogging(l => l.AddConsole())
                .Configure<LoggerFilterOptions>(c => c.MinLevel = LogLevel.Trace)
                .AddCoreServices(_configuration)
                .AddDataServices(_configuration)
                .AddDomainServices(_configuration)
                .BuildServiceProvider();
        }
    }
}
