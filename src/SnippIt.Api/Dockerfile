﻿FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/SnippIt.Api/SnippIt.Api.csproj", "SnippIt.Api/"]
RUN dotnet restore "src/SnippIt.Api/SnippIt.Api.csproj"
COPY . .
WORKDIR "/src/SnippIt.Api"
RUN dotnet build "SnippIt.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SnippIt.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SnippIt.Api.dll"]
