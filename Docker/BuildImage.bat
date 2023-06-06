docker login -u majumi -p uaimrzadzi

docker rmi majumi/clientsdataservice:dataservice

docker build -f ../majumi.CarService.ClientsDataService.Rest/Dockerfile.prod -t majumi/clientsdataservice:dataservice ..

docker logout

pause