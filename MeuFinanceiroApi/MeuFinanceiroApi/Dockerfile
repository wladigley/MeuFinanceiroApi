FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY MeuFinanceiroApi/MeuFinanceiroApi.csproj MeuFinanceiroApi/
RUN dotnet restore MeuFinanceiroApi/MeuFinanceiroApi.csproj
COPY . .
WORKDIR /src/MeuFinanceiroApi
RUN dotnet build MeuFinanceiroApi.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish MeuFinanceiroApi.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MeuFinanceiroApi.dll"]
