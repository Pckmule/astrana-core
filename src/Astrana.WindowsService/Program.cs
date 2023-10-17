/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging.EventLog;
using ProgramBuilder = Astrana.Core.API.ProgramBuilder;

var options = new WebApplicationOptions
{
    ContentRootPath = AppContext.BaseDirectory,
    Args = args
};

var programBuilder = new ProgramBuilder();

var builder = programBuilder.ConfigureWebApplicationBuilder(options);

//builder.Host.UseWindowsService();

if (OperatingSystem.IsWindows())
{
    builder.Services.Configure<EventLogSettings>(config =>
    {
        config.LogName = string.Empty;
        config.SourceName = $"{Astrana.Core.Constants.Application.Name} Windows Service";
    });
}

var app = programBuilder.Build(builder);

app.Run();