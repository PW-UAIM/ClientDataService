using Microsoft.AspNetCore.Mvc;

using majumi.CarService.ClientsDataService.Logic;
using majumi.CarService.ClientsDataService.Model.Services;
using majumi.CarService.ClientsDataService.Rest.Model.Services;
using majumi.CarService.ClientsDataService.Model;
using majumi.CarService.ClientsDataService.Rest.Model.Converters;
using majumi.CarService.ClientsDataService.Rest.Model.Model;

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
    [Route("/getClient/{id:int}")]
    public ActionResult<ClientData> GetClient(int id)
    {
        Client? client = clientCollection.GetClientById(id);
        if (client == null)
            return NotFound();

        ClientData clientData = DataConverter.ConvertToClientData(client);
        
        return Ok(clientData);
    }

    [HttpGet]
    [Route("/getAllClients")]
    public ActionResult<List<ClientData>> GetAllClients()
    {
        List<Client> clients = clientCollection.GetAllClients();
        List<ClientData> clientData = DataConverter.ConvertToVisitDataList(clients);

        return Ok(clientData);
    }

    [HttpGet]
    [Route("/runTests")]
    public string RunTests(string host, int port)
    {
        ITestsService tests = new Tests.Tests();

        return tests.RunTests(host, port);
    }
}