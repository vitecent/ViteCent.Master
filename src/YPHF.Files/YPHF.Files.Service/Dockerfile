# 请参阅 https://aka.ms/customizecontainer 以了解如何自定义调试容器，以及 Visual Studio 如何使用此 Dockerfile 生成映像以更快地进行调试。

# 此阶段用于在快速模式(默认为调试配置)下从 VS 运行时
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080

# 此阶段用于生成服务项目
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/YPHF.Files/YPHF.Files.Service/YPHF.Files.Service.csproj", "src/YPHF.Files/YPHF.Files.Service/"]
COPY ["src/YPHF.Core/YPHF.Core.Web/YPHF.Core.Web.csproj", "src/YPHF.Core/YPHF.Core.Web/"]
COPY ["src/YPHF.Core/YPHF.Core.Api.Swagger/YPHF.Core.Api.Swagger.csproj", "src/YPHF.Core/YPHF.Core.Api.Swagger/"]
COPY ["src/YPHF.Core/YPHF.Core.Api/YPHF.Core.Api.csproj", "src/YPHF.Core/YPHF.Core.Api/"]
COPY ["src/YPHF.Core/YPHF.Core/YPHF.Core.csproj", "src/YPHF.Core/YPHF.Core/"]
COPY ["src/YPHF.Core/YPHF.Core.Cache.Redis/YPHF.Core.Cache.Redis.csproj", "src/YPHF.Core/YPHF.Core.Cache.Redis/"]
COPY ["src/YPHF.Core/YPHF.Core.Cache/YPHF.Core.Cache.csproj", "src/YPHF.Core/YPHF.Core.Cache/"]
COPY ["src/YPHF.Core/YPHF.Core.Job.Quartz/YPHF.Core.Job.Quartz.csproj", "src/YPHF.Core/YPHF.Core.Job.Quartz/"]
COPY ["src/YPHF.Core/YPHF.Core.Job/YPHF.Core.Job.csproj", "src/YPHF.Core/YPHF.Core.Job/"]
COPY ["src/YPHF.Core/YPHF.Core.Logging.Log4Net/YPHF.Core.Logging.Log4Net.csproj", "src/YPHF.Core/YPHF.Core.Logging.Log4Net/"]
COPY ["src/YPHF.Core/YPHF.Core.Orm.SqlSugar/YPHF.Core.Orm.SqlSugar.csproj", "src/YPHF.Core/YPHF.Core.Orm.SqlSugar/"]
COPY ["src/YPHF.Core/YPHF.Core.Orm/YPHF.Core.Orm.csproj", "src/YPHF.Core/YPHF.Core.Orm/"]
COPY ["src/YPHF.Core/YPHF.Core.Register.Consul/YPHF.Core.Register.Consul.csproj", "src/YPHF.Core/YPHF.Core.Register.Consul/"]
COPY ["src/YPHF.Core/YPHF.Core.Register/YPHF.Core.Register.csproj", "src/YPHF.Core/YPHF.Core.Register/"]
COPY ["src/YPHF.Core/YPHF.Core.Trace.Zipkin/YPHF.Core.Trace.Zipkin.csproj", "src/YPHF.Core/YPHF.Core.Trace.Zipkin/"]
COPY ["src/YPHF.Core/YPHF.Core.Trace/YPHF.Core.Trace.csproj", "src/YPHF.Core/YPHF.Core.Trace/"]
COPY ["src/YPHF.Dto/YPHF.Files.Dto/YPHF.Files.Dto.csproj", "src/YPHF.Dto/YPHF.Files.Dto/"]
RUN dotnet restore "./src/YPHF.Files/YPHF.Files.Service/YPHF.Files.Service.csproj"
COPY . .
WORKDIR "/src/src/YPHF.Files/YPHF.Files.Service"
RUN dotnet build "./YPHF.Files.Service.csproj" -c $BUILD_CONFIGURATION -o /app/build

# 此阶段用于发布要复制到最终阶段的服务项目
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./YPHF.Files.Service.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# 此阶段在生产中使用，或在常规模式下从 VS 运行时使用(在不使用调试配置时为默认值)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "YPHF.Files.Service.dll"]