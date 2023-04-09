using Microsoft.AspNetCore.Mvc;

using majumi.CarService.ClientsDataService.Logic;
using majumi.CarService.ClientsDataService.Model.Services;
using majumi.CarService.ClientsDataService.Rest.Model.Services;
using majumi.CarService.ClientsDataService.Model;

namespace majumi.CarService.ClientsDataService.Rest.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientDataController : ControllerBase, IClientDataService, ITestsService
{
    private readonly ILogger<ClientDataController> _logger;

    private readonly IClientCollection clientCollection;

    public ClientDataController(ILogger<ClientDataController> logger)
    {
        _logger = logger;
        clientCollection = new ClientCollection();
    }

    [HttpGet]
    [Route("/client/{id:int}")]
    public Client GetClient(int id)
    {
        return clientCollection.GetById(id);
    }

    [HttpGet]
    [Route("/allClients")]
    public Client[] GetAllClients()
    {
        return clientCollection.GetAllClients();
    }

    [HttpGet]
    [Route("/runTests")]
    public string RunTests(string host, int port)
    {
        ITestsService tests = new Tests.Tests();

        return tests.RunTests(host, port);
    }
}