#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/ANZ104AngularDemo.Web.Public/ANZ104AngularDemo.Web.Public.csproj", "src/ANZ104AngularDemo.Web.Public/"]
COPY ["src/ANZ104AngularDemo.Web.Core/ANZ104AngularDemo.Web.Core.csproj", "src/ANZ104AngularDemo.Web.Core/"]
COPY ["src/ANZ104AngularDemo.Application/ANZ104AngularDemo.Application.csproj", "src/ANZ104AngularDemo.Application/"]
COPY ["src/ANZ104AngularDemo.Application.Shared/ANZ104AngularDemo.Application.Shared.csproj", "src/ANZ104AngularDemo.Application.Shared/"]
COPY ["src/ANZ104AngularDemo.Core.Shared/ANZ104AngularDemo.Core.Shared.csproj", "src/ANZ104AngularDemo.Core.Shared/"]
COPY ["src/ANZ104AngularDemo.Core/ANZ104AngularDemo.Core.csproj", "src/ANZ104AngularDemo.Core/"]
COPY ["src/ANZ104AngularDemo.EntityFrameworkCore/ANZ104AngularDemo.EntityFrameworkCore.csproj", "src/ANZ104AngularDemo.EntityFrameworkCore/"]
COPY ["src/ANZ104AngularDemo.GraphQL/ANZ104AngularDemo.GraphQL.csproj", "src/ANZ104AngularDemo.GraphQL/"]
RUN dotnet restore "src/ANZ104AngularDemo.Web.Public/ANZ104AngularDemo.Web.Public.csproj"
COPY . .
WORKDIR "/src/src/ANZ104AngularDemo.Web.Public"
RUN dotnet build "ANZ104AngularDemo.Web.Public.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ANZ104AngularDemo.Web.Public.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ANZ104AngularDemo.Web.Public.dll"]
