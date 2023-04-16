using majumi.CarService.ClientsDataService.Model;
using majumi.CarService.ClientsDataService.Rest.Model.Model;
using Microsoft.AspNetCore.Mvc;

namespace majumi.CarService.ClientsDataService.Rest.Model.Services;

public interface IClientDataService
{
    public ActionResult<ClientData> GetClient(int id);
    public ActionResult<List<ClientData>> GetAllClients();
}
