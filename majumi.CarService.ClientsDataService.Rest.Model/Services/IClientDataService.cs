using majumi.CarService.ClientsDataService.Model;

namespace majumi.CarService.ClientsDataService.Rest.Model.Services;

public interface IClientDataService
{
    public Client GetClient(int clientID);

    public Client[] GetAllClients();
}
