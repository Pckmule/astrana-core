using Astrana.Core.Domain.Models.AstranaApi.Contracts;
using System.Reflection;
using Astrana.Core.Domain.Models.System.Enums;
using Microsoft.AspNetCore.Http;

namespace Astrana.Core.API
{
    public class AstranaApiInfo : IAstranaApiInfo
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AstranaApiInfo(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;

            Controllers = GetControllers();
        }

        /// <summary>
        /// Returns the current HttpContext.
        /// </summary>
        public HttpContext? Current => _httpContextAccessor.HttpContext;

        /// <summary>
        /// Returns the application's base URL.
        /// </summary>
        public string AppBaseUrl => $"{Current.Request.Scheme}://{Current.Request.Host}{Current.Request.PathBase}/{Core.Constants.Api.RoutePrefix}";

        /// <summary>
        /// Returns a list API Controller types.
        /// </summary>
        public List<Type> Controllers { get; set; }

        /// <summary>
        /// Returns a API proxy endpoint for the specified content identifier.
        /// </summary>
        /// <param name="astranaContentType"></param>
        /// <param name="contentIdentifier"></param>
        /// <returns></returns>
        public string GetProxyEndpoint(AstranaContentType astranaContentType, string contentIdentifier)
        {
            if (astranaContentType == AstranaContentType.Image)
                return $"{AppBaseUrl}/images/proxy/{(contentIdentifier.StartsWith('/') ? contentIdentifier[1..] : contentIdentifier)}";

            if (astranaContentType == AstranaContentType.Video)
                return $"{AppBaseUrl}/videos/proxy/{(contentIdentifier.StartsWith('/') ? contentIdentifier[1..] : contentIdentifier)}";

            if (astranaContentType == AstranaContentType.Audio)
                return $"{AppBaseUrl}/audio/proxy/{(contentIdentifier.StartsWith('/') ? contentIdentifier[1..] : contentIdentifier)}";

            if (astranaContentType == AstranaContentType.File)
                return $"{AppBaseUrl}/files/proxy/{(contentIdentifier.StartsWith('/') ? contentIdentifier[1..] : contentIdentifier)}";

            return $"{AppBaseUrl}/proxy/{contentIdentifier}";
        }

        private static List<Type> GetControllers()
        {
            return Assembly.GetExecutingAssembly().GetTypes().Where(type => type is { IsClass: true, IsAbstract: false } && type.Name.EndsWith("Controller")).ToList();
        }
    }
}