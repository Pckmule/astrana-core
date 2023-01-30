
# This Source Code Form is subject to the terms of the Mozilla Public
# License, v. 2.0. If a copy of the MPL was not distributed with this
# file, You can obtain one at https://mozilla.org/MPL/2.0/.

#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Astrana.Core.Application/Astrana.Core.Application.csproj", "src/Astrana.Core.Application/"]
RUN dotnet restore "src/Astrana.Core.Application/Astrana.Core.Application.csproj"
COPY . .
WORKDIR "/src/Astrana.Core.Application"
RUN dotnet build "Astrana.Core.Application.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Astrana.Core.Application.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Astrana.Core.Application.dll"]