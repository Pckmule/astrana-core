/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging.EventLog;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using ProgramBuilder = Astrana.Core.API.ProgramBuilder;

var options = new WebApplicationOptions
{
    ContentRootPath = AppContext.BaseDirectory,
    Args = args
};

var programBuilder = new ProgramBuilder();

var builder = programBuilder.ConfigureWebApplicationBuilder(options);

//builder.Host.UseWindowsService();

builder.Services.Configure<EventLogSettings>(config =>
{
    config.LogName = string.Empty;
    config.SourceName = $"{Astrana.Core.Constants.Application.Name} Windows Service";
});

// TODO: Move to config / registry / env variable
var pfxPath = "D:\\repos\\Astrana\\astrana-core\\src\\Astrana.WindowsService\\conf\\ssl-certificate";
var sslCertificatePfx = new X509Certificate2(Path.Combine(pfxPath, "astrana.pfx"), "astrana");

builder.WebHost.UseKestrel(kestrelServerOptions =>
{
    kestrelServerOptions.Listen(IPAddress.Loopback, 9001, listenOptions =>
    {
        listenOptions.UseHttps(sslCertificatePfx);
    });
});

var app = programBuilder.Build(builder);

app.Run();