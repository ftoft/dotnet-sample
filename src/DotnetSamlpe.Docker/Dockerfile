FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["DotnetSamlpe.Docker/DotnetSamlpe.Docker.csproj", "DotnetSamlpe.Docker/"]
RUN dotnet restore "DotnetSamlpe.Docker/DotnetSamlpe.Docker.csproj"
COPY . .
WORKDIR "/src/DotnetSamlpe.Docker"
RUN dotnet build "DotnetSamlpe.Docker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DotnetSamlpe.Docker.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DotnetSamlpe.Docker.dll"]
