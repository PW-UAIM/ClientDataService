#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5001

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["majumi.CarService.ClientsDataService.Model/majumi.CarService.ClientsDataService.Model.csproj", "majumi.CarService.ClientsDataService.Model/"]
COPY ["majumi.CarService.ClientsDataService.Rest/majumi.CarService.ClientsDataService.Rest.csproj", "majumi.CarService.ClientsDataService.Rest/"]
COPY ["majumi.CarService.ClientsDataService.Rest.Model/majumi.CarService.ClientsDataService.Rest.Model.csproj", "majumi.CarService.ClientsDataService.Rest.Model/"]
COPY ["majumi.CarService.ClientsDataService.Rest.Tests/majumi.CarService.ClientsDataService.Rest.Tests.csproj", "majumi.CarService.ClientsDataService.Rest.Tests/"]
RUN dotnet restore "majumi.CarService.ClientsDataService.Rest/majumi.CarService.ClientsDataService.Rest.csproj"
COPY . .
WORKDIR "/src/majumi.CarService.ClientsDataService.Rest"
RUN dotnet build "majumi.CarService.ClientsDataService.Rest.csproj" -c Production -o /app/build

FROM build AS publish
RUN dotnet publish "majumi.CarService.ClientsDataService.Rest.csproj" -c Production -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "majumi.CarService.ClientsDataService.Rest.dll"]