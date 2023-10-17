/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Configuration;
using Astrana.Core.Constants;
using Astrana.Core.Data.DependencyInjection;
using Astrana.Core.DependencyInjection;
using Astrana.Core.Domain.DependencyInjection;
using Astrana.Core.Domain.IdentityAccessManagement.Managers.Idp;
using Astrana.Core.Domain.Models.AstranaApi.Contracts;
using Astrana.Core.MimeTypes.MimeTypes;
using Astrana.Core.SignalRHubs;
using Astrana.Core.Utilities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using System.Net;
using System.Text.Json.Serialization;
using ApiConstants = Astrana.Core.Constants.Api;

namespace Astrana.Core.API
{
    public class ProgramBuilder
    {
        private static readonly Version AssemblyVersion = VersionUtility.GetVersion(typeof(ProgramBuilder));
        private static readonly ApiVersion CurrentApiVersion = new(AssemblyVersion.Major, AssemblyVersion.Minor);
        private static readonly string CurrentApiVersionLabel = CurrentApiVersion.MajorVersion + "." + CurrentApiVersion.MinorVersion;

        private static readonly string SignalRHubPathName = "hub";

        private readonly IConfiguration _configuration;
        private readonly IIdpManager _idpManager;
        
        private const string ClientAppDirectory = "clientapp";

        public ProgramBuilder()
        {
            _configuration = new ConfigurationBuilder().AddProtectedJsonFile(Application.SettingsFileName).Build();
            
            _idpManager = GetServiceProvider().GetRequiredService<IIdpManager>();
        }

        /// <summary>
        /// Configures a Web Application Builder
        /// </summary>
        /// <param name="options"></param>
        /// <param name="enableKestrelHttps"></param>
        /// <returns></returns>
        public WebApplicationBuilder ConfigureWebApplicationBuilder(WebApplicationOptions options, bool enableKestrelHttps = true)
        {
            var builder = WebApplication.CreateBuilder(options);

            builder.Configuration.Sources.Clear();
            builder.Configuration.AddProtectedJsonFile(Application.SettingsFileName, false);

            builder.Logging.ClearProviders();

            builder.Host.UseSerilog((hostContext, loggerConfiguration) =>
            {
                loggerConfiguration.ReadFrom.Configuration(hostContext.Configuration);
            });

            builder.Services.AddSingleton<IAstranaApiInfo, AstranaApiInfo>();
            builder.Services.AddCoreServices(builder.Configuration);
            builder.Services.AddDataServices(builder.Configuration);
            builder.Services.AddDomainServices(builder.Configuration);

            // Add services to the container.
            builder.Services.AddControllers().AddJsonOptions(jsonOptions =>
            {
                jsonOptions.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
                jsonOptions.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());

            }).PartManager.ApplicationParts.Add(new AssemblyPart(typeof(ProgramBuilder).Assembly));
            
            builder.Services.AddHttpContextAccessor();

            if (builder.Environment.IsDevelopment())
            {
                // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
                builder.Services.AddEndpointsApiExplorer();
                builder.Services.AddSwagger(CurrentApiVersionLabel);
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

                jwtBearerOptions.Events = new JwtBearerEvents
                {
                    OnChallenge = async (context) =>
                    {
                        context.HandleResponse();
                        
                        if (context.AuthenticateFailure != null)
                        {
                            context.Response.StatusCode = 401;

                            context.Response.ContentType = MimeTypeMapper.GetMimeType("json");
                            
                            await context.HttpContext.Response.WriteAsync("{ \"message\": \"Access Denied\" }");
                        }
                    }
                };
            });

            builder.Services.AddAuthorization(authorizationOptions =>
            {
                authorizationOptions.FallbackPolicy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
            });

            builder.Services.AddSpaStaticFiles(configuration =>
            {
               configuration.RootPath = $"{ClientAppDirectory}/build";
            });

            if (enableKestrelHttps)
            {
                var httpsIpAddress = IPAddress.Loopback;
                const int httpsPort = 9001;

                builder.WebHost.UseKestrel(kestrelServerOptions =>
                {
                    kestrelServerOptions.Listen(httpsIpAddress, httpsPort, listenOptions =>
                    {
                        listenOptions.UseHttps(SslUtility.GetSslCertificate());
                    });
                });
            }

            builder.Services.AddSignalR();

            return builder;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public WebApplication Build(WebApplicationBuilder builder)
        {
            var app = builder.Build();

            app.UseHttpsRedirection();

            var staticFileOptions = new StaticFileOptions();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseSwagger();
                app.UseSwaggerUI(options =>
                {
                    options.DocumentTitle = $"{Application.Name} Web API v{CurrentApiVersionLabel}";
                    options.SwaggerEndpoint($"/swagger/v{CurrentApiVersionLabel}/swagger.json", $"{Application.Name} API v{CurrentApiVersionLabel}");
                    options.RoutePrefix = ApiConstants.DocsRoutePrefix;

                    options.InjectStylesheet($"/{ApiConstants.Swagger.SwaggerUiDirectoryName}/override.css");
                    options.InjectJavascript($"/{ApiConstants.Swagger.SwaggerUiDirectoryName}/override.js");
                });

                staticFileOptions = new StaticFileOptions
                {
                    FileProvider = new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, $"wwwroot/{ApiConstants.Swagger.SwaggerUiDirectoryName}")),
                    RequestPath = $"/{ApiConstants.Swagger.SwaggerUiDirectoryName}"
                };
            }
            else
            {
                app.UseExceptionHandler("/Error");

                // The default HSTS value is 30 days.
                // TODO: You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                //app.UseHsts();
            }

            app.UseStaticFiles(staticFileOptions);
            app.UseSpaStaticFiles();

            app.UseWhen(httpContext => !PathStartsWith(httpContext, new List<string> { $"/{Api.RoutePrefix}", $"/{SignalRHubPathName}" }), applicationBuilder =>
            {
                applicationBuilder.UseSpa(spa =>
                {
                    spa.Options.SourcePath = $"{ClientAppDirectory}";

                    if (app.Environment.IsDevelopment())
                    {
                        //spa.UseReactDevelopmentServer(npmScript: "start");
                    }
                });
            });

            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapHub<MainHub>($"/{SignalRHubPathName}");
            app.MapControllers(); 

            app.MapFallbackToFile("index.html");

            return app;
        }

        private static bool PathStartsWith(HttpContext httpContext, List<string> paths)
        {
            if(httpContext.Request.Path.Value == null)
                return false;

            foreach (var path in paths)
            {
                if (httpContext.Request.Path.Value.StartsWith(path))
                    return true;
            }

            return false;
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
