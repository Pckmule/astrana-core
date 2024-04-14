/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.WindowsService
{
    /// <summary>
    /// Astrana Windows Service Background Worker
    /// </summary>
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        private const string ServiceName = Core.Constants.Application.Name + " Windows Service";

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation($"{ServiceName} is starting.");

            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("{serviceName} running at: {time}", ServiceName, DateTimeOffset.Now);

                await Task.Delay(1000, stoppingToken);
            }


            _logger.LogInformation("{ServiceName} has stopped.");
        }
    }
}