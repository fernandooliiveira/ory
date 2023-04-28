FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["OryAuth/OryAuth.csproj", "OryAuth/"]
RUN dotnet restore "OryAuth/OryAuth.csproj"
COPY . .
WORKDIR "/src/OryAuth"
RUN dotnet build "OryAuth.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OryAuth.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OryAuth.dll"]
