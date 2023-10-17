using Astrana.Core.Constants;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using ApiConstants = Astrana.Core.Constants.Api;

namespace Astrana.Core.API
{
    public static class Swagger
    {
        public static void AddSwagger(this IServiceCollection services, string currentApiVersionLabel)
        {
            services.AddSwaggerGen(swaggerGenOptions =>
            {
                swaggerGenOptions.EnableAnnotations();

                swaggerGenOptions.IgnoreObsoleteActions();

                swaggerGenOptions.SwaggerDoc("v" + currentApiVersionLabel, new OpenApiInfo
                {
                    Version = currentApiVersionLabel,
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
                var xmlCommentsFileName = $"{typeof(ProgramBuilder).Assembly.GetName().Name}.xml";
                var xmlCommentsFilePath = Path.Combine(AppContext.BaseDirectory, xmlCommentsFileName);
                swaggerGenOptions.IncludeXmlComments(xmlCommentsFilePath);

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
    }
}