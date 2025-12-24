FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["MTG.InventoryManager/MTG.InventoryManager.csproj", "MTG.InventoryManager/"]
RUN dotnet restore "MTG.InventoryManager/MTG.InventoryManager.csproj"
COPY . .
WORKDIR "/src/MTG.InventoryManager"
RUN dotnet build "./MTG.InventoryManager.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./MTG.InventoryManager.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MTG.InventoryManager.dll"]
