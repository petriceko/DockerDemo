FROM mcr.microsoft.com/dotnet/aspnet:5.0
COPY bin/Release/net5.0/publish App/

WORKDIR /App

ENTRYPOINT ["dotnet", "ConsoleWriting.dll"]

# publish
# ist do priecinku s projektom
# dotnet publish -c Release

# spustenie:
# ist do priecinku, kde sa Dockerfile nachadza
# docker build -t writing-docker-image -f Dockerfile .
# docker images
# docker create --name core-writing-console writing-docker-image
# docker container ps -all
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

# Gitlab:
# https://gitlab.com/petriceko/DockerDemo/container_registry
# https://gitlab.com/petriceko/DockerDemo/container_registry/1900894
# docker login registry.gitlab.com
# --docker build -t registry.gitlab.com/petriceko/dockerdemo .
# dotnet publish -c Release
# docker build -t registry.gitlab.com/petriceko/dockerdemo:Version3 .
# docker push registry.gitlab.com/petriceko/dockerdemo:Version3
# docker pull registry.gitlab.com/petriceko/dockerdemo:Version3
# docker create --name core-writing-console registry.gitlab.com/petriceko/dockerdemo:Version3
# docker start core-writing-console
# docker attach --sig-proxy=false core-writing-console