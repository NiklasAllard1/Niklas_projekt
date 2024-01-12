FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env

WORKDIR /Workdir

COPY ./bin/Debug/net8.0/ .

CMD ["dotnet", "Niklas_projekt.dll"]