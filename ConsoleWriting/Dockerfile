FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

RUN dotnet --version
RUN echo "$PWD"

COPY ConsoleWriting/ConsoleWriting.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish ConsoleWriting.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "ConsoleWriting.dll"]
