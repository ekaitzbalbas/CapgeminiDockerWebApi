FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY CapgeminiWebApi/CapgeminiWebApi.csproj CapgeminiWebApi/
RUN dotnet restore CapgeminiWebApi/CapgeminiWebApi.csproj
COPY . .
WORKDIR /src/CapgeminiWebApi
RUN dotnet build CapgeminiWebApi.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish CapgeminiWebApi.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CapgeminiWebApi.dll"]
