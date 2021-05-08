REM Do priecinku, v ktorom sa nachadza tento bat file treba stiahnut docker installer
"Docker Desktop Installer.exe" install --quiet

REM s pripojenim na internet:
REM docker-compose up -d

REM bez pripojenia na internet:
REM 1. stiahnut docker image na PC ktory pristup na net ma: -> build pipeline by mala pripravit cely folder s images, docker installerom a batakom
REM docker pull containrrr/watchtower
REM docker pull registry.gitlab.com/petriceko/dockerdemo:Version3
REM docker save containrrr/watchtower --output watchtower.tar
REM docker save registry.gitlab.com/petriceko/dockerdemo:Version3 --output docker_demo.tar
REM 2. stiahnute subory pridat do foldera s docker installerom a batakom
REM 3. naloadovat image do dockera:
docker load --input watchtower.tar
docker load --input docker_demo.tar
REM nastartovat docker:
docker-compose up -d