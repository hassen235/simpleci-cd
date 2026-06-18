FROM dhi.io/dotnet:10-sdk as build

WORKDIR /source

COPY ./web.csproj  ./

RUN dotnet restore  ./web.csproj

COPY . .

RUN dotnet publish -o ./publish --no-build --no-restore

FROM dhi.io/aspnetcore:10

WORKDIR /app

COPY --from=build ./publish/ .

WORKDIR /publish

ENTRYPOINT [ "dotnet","web.dll" ]

