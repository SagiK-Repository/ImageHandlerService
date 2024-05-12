#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER app
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Core.UseCase.TransformService/Core.UseCase.TransformService.csproj", "Core.UseCase.TransformService/"]
RUN dotnet restore "./Core.UseCase.TransformService/Core.UseCase.TransformService.csproj"
COPY . .
WORKDIR "/src/Core.UseCase.TransformService"
RUN dotnet build "./Core.UseCase.TransformService.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Core.UseCase.TransformService.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Core.UseCase.TransformService.dll"]