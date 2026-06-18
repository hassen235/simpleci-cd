FROM mcr.microsoft.com/dotnet/sdk:10.0-alpine AS build

WORKDIR /source

COPY ./web.csproj  .

RUN dotnet restore  ./web.csproj

COPY . .

RUN dotnet publish -c Release -o ./publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:10.0-alpine

WORKDIR /app

COPY --from=build /source/publish/ .


ENTRYPOINT ["dotnet","web.dll" ]


