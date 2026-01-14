# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["LazyPeopleAPI/LazyPeopleAPI.csproj", "./"]
RUN dotnet restore "LazyPeopleAPI.csproj"
COPY MyApi/. ./
RUN dotnet publish "LazyPeopleAPI.csproj" -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 8080
ENTRYPOINT ["dotnet", "LazyPeopleAPI.dll"]