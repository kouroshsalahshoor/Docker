# Docker

- https://docker.com/
- https://hub.docker.com/search?q=

### Checking That Docker Is Working
make sure the docker desktop is running

# Images
````
// Listing Available Images
docker images
// Downloading Images
docker pull alpine
docker pull alpine:3.4
// running a container - pulls if not pulled
docker run hello-world
docker run --rm hello-world
docker run -p 80:80 hello-world
// Deleting Images by ID
docker rmi -f <image id>
// Deleting all All Images
docker rmi -f $(docker images -q)
````
# Container
````
// Creating a Container
docker create -p 3000:80 --name mvcApp3000 kourosh/mvcapp
// Listing All Containers
docker ps
docker ps -a
// Starting a Container
docker start mvcApp3000
// Stopping a Container
docker stop <container id>
// Deleteing a Container
docker rm <container id>
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
