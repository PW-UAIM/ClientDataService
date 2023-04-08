namespace majumi.CarService.ClientsDataService.Rest.Model.Services;

public interface ITestsService
{
    public string RunTests(string host, int port);
}