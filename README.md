# Docker

https://hub.docker.com/

### Downloading Images
````
docker run --rm hello-world
docker images
docker pull alpine
docker pull alpine:3.4
````
### Deleting Images
by ID
````
docker rmi -f <image id>
````
All Images
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
