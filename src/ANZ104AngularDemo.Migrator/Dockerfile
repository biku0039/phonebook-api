#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/ANZ104AngularDemo.Migrator/ANZ104AngularDemo.Migrator.csproj", "src/ANZ104AngularDemo.Migrator/"]
COPY ["src/ANZ104AngularDemo.EntityFrameworkCore/ANZ104AngularDemo.EntityFrameworkCore.csproj", "src/ANZ104AngularDemo.EntityFrameworkCore/"]
COPY ["src/ANZ104AngularDemo.Core/ANZ104AngularDemo.Core.csproj", "src/ANZ104AngularDemo.Core/"]
COPY ["src/ANZ104AngularDemo.Core.Shared/ANZ104AngularDemo.Core.Shared.csproj", "src/ANZ104AngularDemo.Core.Shared/"]
RUN dotnet restore "src/ANZ104AngularDemo.Migrator/ANZ104AngularDemo.Migrator.csproj"
COPY . .
WORKDIR "/src/src/ANZ104AngularDemo.Migrator"
RUN dotnet build "ANZ104AngularDemo.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ANZ104AngularDemo.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ANZ104AngularDemo.Migrator.dll"]
