#FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-nanoserver-1903 AS base
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443

#FROM mcr.microsoft.com/dotnet/core/sdk:3.1-nanoserver-1903 AS build
#WORKDIR /src
##COPY ["SpeakerAPI/SpeakerAPI.csproj", "SpeakerAPI/"]
#COPY SpeakerAPI.csproj .
##RUN dotnet restore "SpeakerAPI/SpeakerAPI.csproj"
#COPY . .
#WORKDIR "/src/SpeakerAPI"
#RUN dotnet build "SpeakerAPI.csproj" -c Release -o /app/build

#FROM build AS publish
#RUN dotnet publish "SpeakerAPI.csproj" -c Release -o /app/publish

#FROM nginx:alpine AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#COPY nginx.conf  /app/nginx.conf
##ENTRYPOINT ["dotnet", "SpeakerAPI.dll"]

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY SpeakerAPI.csproj .
RUN dotnet restore "SpeakerAPI.csproj"
COPY . .
RUN dotnet build "SpeakerAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SpeakerAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SpeakerAPI.dll"]
