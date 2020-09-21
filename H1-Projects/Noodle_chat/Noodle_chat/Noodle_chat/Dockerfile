#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/runtime:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Noodle_chat/Noodle_chat.csproj", "Noodle_chat/"]
RUN dotnet restore "Noodle_chat/Noodle_chat.csproj"
COPY . .
WORKDIR "/src/Noodle_chat"
RUN dotnet build "Noodle_chat.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Noodle_chat.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Noodle_chat.dll", "http://localhost:8080/"]