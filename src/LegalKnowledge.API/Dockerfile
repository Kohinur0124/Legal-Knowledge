#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/LegalKnowledge.API/LegalKnowledge.API.csproj", "src/LegalKnowledge.API/"]
COPY ["src/LegalKnowledge.Application/LegalKnowledge.Application.csproj", "src/LegalKnowledge.Application/"]
COPY ["src/LegalKnowledge.Domain/LegalKnowledge.Domain.csproj", "src/LegalKnowledge.Domain/"]
COPY ["src/LegalKnowledge.Infrastructure/LegalKnowledge.Infrastructure.csproj", "src/LegalKnowledge.Infrastructure/"]
RUN dotnet restore "./src/LegalKnowledge.API/LegalKnowledge.API.csproj"
COPY . .
WORKDIR "/src/src/LegalKnowledge.API"
RUN dotnet build "./LegalKnowledge.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./LegalKnowledge.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LegalKnowledge.API.dll"]