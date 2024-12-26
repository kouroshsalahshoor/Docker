# Docker

https://docker.com/

https://hub.docker.com/

### Checking That Docker Is Working
make sure the docker desktop is running
#### running a container
````
docker run hello-world
docker run --rm hello-world
docker run -p 80:80 hello-world
````
### Listing the Available Images
````
docker images
````
### Downloading Images
````
docker pull alpine
docker pull alpine:3.4
````
### Deleting Images by ID
````
docker rmi -f <image id>
````
#### Deleting all All Images
````
docker rmi -f $(docker images -q)
````
### Preparing the Application for the Image
````
dotnet restore
dotnet publish --framework net9.0 --configuration Release --output dist
````
### Creating a Custom Image
````
cd Docker\MvcApp\MvcApp
docker build . -t kourosh/mvcapp -f Dockerfile
````
### Creating a Container
````
docker create -p 3000:80 --name mvcApp3000 kourosh/mvcapp
````
### Listing All Containers
````
docker ps
docker ps -a
````
### Starting a Container
````
docker start mvcApp3000
````
### Stopping a Container
````
docker stop <container id>
````
### Deleteing a Container
````
docker rm <container id>
````
