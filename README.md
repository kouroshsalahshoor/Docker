# Docker

- https://docker.com/
- https://hub.docker.com/search?q=
````
docker
docker run -d -p 80:80 nginx
docker ps -a
docker stop <conainer id>
docker rm -f <conainer id>
docker logs <conainer id>
docker attach <conainer id>
docker exec -it <conainer id> bash|vim|ls|pwd|<command>
````
# Images
````
// Listing Available Images
docker images
// Downloading Images
docker pull nginx
docker pull alpine:3.4
// Deleting Images by ID
docker rmi -f <image id>
// Deleting all All Images
docker rmi -f $(docker images -q)
````
# Container
````
// Listing All Containers
docker ps
docker ps -a
// running a container - pulls if not pulled - to test the installation - make sure the docker desktop is running
docker run hello-world
docker run --rm hello-world
docker run -p 80:80 hello-world
// Starting a Container
docker start hello-world
// Stopping a Container
docker stop <container id>
// Deleteing a Container
docker rm <container id>
// Creating a Container
docker create -p 3000:80 --name mvcApp3000 kourosh/mvcapp
````
### Creating a Custom Image from a container
````
docker commit <container id> <new container name>
````

# 
### Preparing the Application for the Image
````
dotnet restore
dotnet publish --framework net9.0 --configuration Release --output dist
````
### Creating a Custom Image
````
cd Docker\MvcApp\MvcApp
docker build . -t kourosh/mvcapp -f Dockerfile
docker commit <container id> <new container name>
````

