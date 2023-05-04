FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["DotnetSample.DockerAwesome/DotnetSample.DockerAwesome.csproj", "DotnetSample.DockerAwesome/"]
RUN dotnet restore "DotnetSample.DockerAwesome/DotnetSample.DockerAwesome.csproj"
COPY . .
WORKDIR "/src/DotnetSample.DockerAwesome"
RUN dotnet build "DotnetSample.DockerAwesome.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DotnetSample.DockerAwesome.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DotnetSample.DockerAwesome.dll"]
