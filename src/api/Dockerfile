FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

COPY api.sln ./
COPY /domain/docker-ci.domain/*.csproj ./domain/docker-ci.domain/
COPY /rest/*.csproj ./rest/

RUN dotnet restore 

COPY . ./
RUN dotnet publish -c Release -o out

# run built image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "rest.dll"]
#COPY /bin/Release/netcoreapp3.1/publish App/

#WORKDIR /App

#ENTRYPOINT ["dotnet", "rest.dll"]