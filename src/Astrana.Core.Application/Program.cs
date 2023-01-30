/*
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/.
 */

using ProgramBuilder = Astrana.Core.API.ProgramBuilder;

var options = new WebApplicationOptions
{
    ContentRootPath = AppContext.BaseDirectory,
    Args = args
};

var programBuilder = new ProgramBuilder();

var builder = programBuilder.ConfigureWebApplicationBuilder(options);
programBuilder.Build(builder).Run();