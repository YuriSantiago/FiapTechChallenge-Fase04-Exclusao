FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
Expose 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY Core ./Core
COPY ExclusaoProdutor ./ExclusaoProdutor

WORKDIR /src/ExclusaoProdutor

RUN dotnet restore ExclusaoProdutor.csproj
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "ExclusaoProdutor.dll"]