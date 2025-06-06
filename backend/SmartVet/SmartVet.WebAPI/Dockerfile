#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["SmartVet/SmartVet.WebAPI/SmartVet.WebAPI.csproj", "SmartVet/SmartVet.WebAPI/"]
COPY ["SmartVet/SmartVet.Application/SmartVet.Application.csproj", "SmartVet/SmartVet.Application/"]
COPY ["SmartVet/SmartVet.Domain/SmartVet.Domain.csproj", "SmartVet/SmartVet.Domain/"]
COPY ["SmartVet/SmartVet.Infrastructure/SmartVet.Infrastructure.csproj", "SmartVet/SmartVet.Infrastructure/"]
RUN dotnet restore "./SmartVet/SmartVet.WebAPI/SmartVet.WebAPI.csproj"
COPY . .
WORKDIR "/src/SmartVet/SmartVet.WebAPI"
RUN dotnet build "./SmartVet.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./SmartVet.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SmartVet.WebAPI.dll"]
