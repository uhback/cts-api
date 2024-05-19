# Use the official .NET Core SDK image as a build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy the project files and restore dependencies
COPY . ./
RUN dotnet restore src/CurrentTimeService.Api

# Copy the remaining source code and build the application
COPY . ./
RUN dotnet publish src/CurrentTimeService.Api -c Release -o out

# Use the official .NET Core runtime image for the final stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

# Expose the port your application runs on
EXPOSE 8080

# Define the entry point for the container
ENTRYPOINT ["dotnet", "CurrentTimeService.Api.dll"]
