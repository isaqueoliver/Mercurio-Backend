FROM mcr.microsoft.com/dotnet/core/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:6.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore 
RUN dotnet build --no-restore -c Release -o /app

FROM build AS publish
RUN dotnet publish --no-restore -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
# Padr�o de container ASP.NET
# ENTRYPOINT ["dotnet", "Back.Mercurio.Api.dll"]
# Op��o utilizada pelo Heroku
CMD ASPNETCORE_URLS=http://*:$PORT dotnet Back.Mercurio.Api.dll