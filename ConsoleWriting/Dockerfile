FROM mcr.microsoft.com/dotnet/aspnet:5.0
COPY bin/Release/net5.0/publish App/

WORKDIR /App

ENTRYPOINT ["dotnet", "ConsoleWriting.dll"]

# publish
# ist do priecinku s projektom
# dotnet publish -c Release

# spustenie:
# ist do priecinku, kde sa Dockerfile nachadza
# docker build -t writing-docker-image -f Dockerfile .              - vybuildovanie noveho dockera na zaklade Dockerfilu s nazvom writing-docker
# docker images                                                     - zobrazenie noveho dockera
# docker create --name core-writing-console writing-docker-image
# docker start core-writing-console
# docker attach --sig-proxy=false core-writing-console
# docker stop core-writing-console
# docker ps -a
# docker rm core-writing-console
# docker image rm writing-docker-image

# update - iba update applikacie, publish a zopakovanie krokov

# pozretie suboru:
# docker exec core-writing-console dir
# vstupenie do vnutra
# docker exec -it core-writing-console bash
# install txt editora:
# apt-get update
# apt-get install vim
# vim WriteLines.txt
# exit

# sharing foldera:
# docker volume create sharing-folder
# docker volume inspect sharing-folder
# docker run -v sharing-folder:/etc/shared --name core-writing-console writing-docker-image





# docker build -f Dockerfile .
# docker run 'imageId'
# docker run -d --name myapp aspnetapp

# docker images
# docker image rm









# ENTRYPOINT ["./ContainerSample"]
# docker run -d -p 8080:80 --name myapp aspnetapp