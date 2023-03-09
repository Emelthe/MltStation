FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG API_NAME
ENV API_NAME=${API_NAME}

WORKDIR /src
COPY ["$API_NAME/$API_NAME.csproj", "$API_NAME/"]

COPY ["Mlt.Api.Base/Mlt.Api.Base.csproj", "Mlt.Api.Base/"]
COPY ["Mlt.Models/Mlt.Models.csproj", "Mlt.Models/"]

RUN dotnet restore "$API_NAME/$API_NAME.csproj"
COPY . .

WORKDIR "/src/$API_NAME"
RUN dotnet build "$API_NAME.csproj" -c Release -o /app/build --no-restore

FROM build AS publish
RUN dotnet publish "$API_NAME.csproj" -c Release -o /app/publish --no-restore

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "api.service.dll"]