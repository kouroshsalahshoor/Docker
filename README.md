# Docker

## Ms Sql Server

https://hub.docker.com/r/microsoft/mssql-server

````
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=yourStrong(!)Password" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest
````
### run
https://dev.to/docker/how-to-run-microsoft-sql-in-minutes-using-docker-desktop-3h7d

https://www.bing.com/videos/riverview/relatedvideo?q=how+to+run+sqlserver+on+docker+on+windows&mid=89284776A93E02A30EEB89284776A93E02A30EEB&mmscn=serpvidol&mcid=738E4EBAF2804B59BC7F6E19F010150C&FORM=VIRE&ajaxhist=0&ajaxserp=0

---
## Adding docker to an existing project
- in VS right click on the project
- Add
- Docker support
### generate an image based on dockerfile
````
Docker\MiniApi> docker build -t miniapi .
````
### run the image
````
docker run -p 1234:80 miniapi
````
## dockerizing Wasm

https://chrissainty.com/containerising-blazor-applications-with-docker-containerising-a-blazor-webassembly-app/

---
# Installing Docker on Windows
## Docker desktop

https://docker.com/

hardware virtualization must be on

### installation test
````
docker run hello-world
````
running a container - pulls if not pulled - to test the installation - make sure the docker desktop is running

---

# Images
## Docker Hub

https://hub.docker.com/search?q=

### Listing Available Images
````
docker images
````
### Downloading Images
````
docker pull nginx
docker pull alpine:3.4
````
### Deleting Images by ID
````
docker rmi -f <image id>
````
### Deleting all All Images
````
docker rmi -f $(docker images -q)
````
### Tag
````
docker tag <image id> <image name>:<tag name>
````
### untagging
````
docker rmi <image name>:<tag name>
````
---

# Containers
instance of an image

````
docker run nginx
docker run -d -p 80:80 nginx
````
````
docker ps -a
````
````
docker stop <conainer id>
````
````
docker rm -f <conainer id>
````
````
docker logs <conainer id>
````
````
docker attach <conainer id>
````
````
docker exec -it <conainer id> bash|vim|ls|pwd|<command>
````
### Listing All Containers
docker ps
docker ps -a

docker run --rm hello-world
docker run -p 80:80 hello-world
### Starting a Container
docker start hello-world
### Stopping a Container
docker stop <container id>
### Deleteing a Container
docker rm <container id>
### Creating a Container
docker create -p 3000:80 --name mvcApp3000 kourosh/mvcapp

## Creating a Custom Image from a container
````
docker commit <container id> <new container name>
````

## Preparing the Application for the Image
````
dotnet restore
dotnet publish --framework net9.0 --configuration Release --output dist
````
## Creating a Custom Image
````
cd Docker\MvcApp\MvcApp
docker build . -t kourosh/mvcapp -f Dockerfile
docker commit <container id> <new container name>
````

# links
- https://learn.microsoft.com/en-us/sql/linux/quickstart-install-connect-docker?view=sql-server-ver16&tabs=cli&pivots=cs1-powershell
- https://hub.docker.com/u/microsoft
- https://medium.com/@seventechnologiescloud/local-sqlserver-database-via-docker-compose-the-ultimate-guide-f1d9f0ac1354
