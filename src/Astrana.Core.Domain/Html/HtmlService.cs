using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.Html
{
    public class HtmlService: IHtmlService
    {
        private readonly ILogger<HtmlService> _logger;

        public HtmlService(ILogger<HtmlService> logger)
        {
            _logger = logger;
        }
    }
}
