
FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /source

COPY ./ SCASA-project .
RUN dotnet restore
RUN dotnet publish -c release -o /app --no-restore


FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /app
COPY --from=build /app ./
EXPOSE 80
ENTRYPOINT ["dotnet", "SCASA-project.dll"]
