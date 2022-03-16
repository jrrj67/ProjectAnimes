#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ProjectAnimes/ProjectAnimes.API.csproj", "ProjectAnimes/"]
COPY ["ProjectAnimes.Infra/ProjectAnimes.Infra.csproj", "ProjectAnimes.Infra/"]
COPY ["ProjectAnimes.Core/ProjectAnimes.Domain.csproj", "ProjectAnimes.Core/"]
RUN dotnet restore "ProjectAnimes/ProjectAnimes.API.csproj"
COPY . .
WORKDIR "/src/ProjectAnimes"
RUN dotnet build "ProjectAnimes.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProjectAnimes.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProjectAnimes.API.dll"]