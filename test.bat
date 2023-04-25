echo off
set url=https://localhost:5001

CALL:curl_test "Dane klienta o ID 1" GET /getClient/1

CALL:curl_test "Dane wszystkich klientow" GET /getAllClients

EXIT /B 0

:curl_test
echo Nazwa testu: %~1
echo Testowany url: %url%%~3
curl -X %~2 ^
	 %url%%~3 ^
	 -H 'accept:application/json'
echo:
echo:
EXIT /B 0