FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["GrpService1Client/GrpService1Client.csproj", "GrpService1Client/"]
RUN dotnet restore "GrpService1Client/GrpService1Client.csproj"
COPY . .
WORKDIR "/src/GrpService1Client"
RUN dotnet build "GrpService1Client.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GrpService1Client.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GrpService1Client.dll"]
