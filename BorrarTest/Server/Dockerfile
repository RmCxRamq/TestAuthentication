#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BorrarTest/Server/BorrarTest.Server.csproj", "BorrarTest/Server/"]
COPY ["BorrarTest/Client/BorrarTest.Client.csproj", "BorrarTest/Client/"]
COPY ["BorrarTest/Shared/BorrarTest.Shared.csproj", "BorrarTest/Shared/"]
RUN dotnet restore "BorrarTest/Server/BorrarTest.Server.csproj"
COPY . .
WORKDIR "/src/BorrarTest/Server"
RUN dotnet build "BorrarTest.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BorrarTest.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BorrarTest.Server.dll"]