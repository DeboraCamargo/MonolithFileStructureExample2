#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SpikeMonoAPI2/SpikeMonoAPI2.csproj", "SpikeMonoAPI2/"]
RUN dotnet restore "SpikeMonoAPI2/SpikeMonoAPI2.csproj"
COPY . .
WORKDIR "/src/SpikeMonoAPI2"
RUN dotnet build "SpikeMonoAPI2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SpikeMonoAPI2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SpikeMonoAPI2.dll"]