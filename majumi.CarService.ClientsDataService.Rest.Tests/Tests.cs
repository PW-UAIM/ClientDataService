using System.Diagnostics;
using System.Text.Json;
using majumi.CarService.ClientsDataService.Model;
using majumi.CarService.ClientsDataService.Model.Services;
using majumi.CarService.ClientsDataService.Rest.Model.Model;
using majumi.CarService.ClientsDataService.Rest.Model.Services;

using majumi.CarService.ClientsDataService.Logic;

namespace majumi.CarService.ClientsDataService.Rest.Tests;
public class Tests : ITestsService
{
    private static readonly HttpClient httpClient = new();

    public string RunTests(string host, int port)
    {
        throw new NotImplementedException();
    }
}

