FROM microsoft/aspnetcore:2.0

WORKDIR /app

RUN mkdir data

copy /bin/Release/netcoreapp2.0 .

ENTRYPOINT ["dotnet","Sumador.dll"]