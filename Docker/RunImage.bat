docker login -u majumi -p uaimrzadzi

docker stop clientsdataservice

docker pull majumi/clientsdataservice:dataservice

docker run --name clientsdataservice -p 5002:5002 -it majumi/clientsdataservice:dataservice

pause

docker stop clientsdataservice

docker rm clientsdataservice

pause