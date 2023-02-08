#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
EXPOSE 80

COPY ./bin/Release/net7.0/publish .

ENTRYPOINT ["dotnet", "Blood_Management_System.dll"]