namespace majumi.CarService.ClientsDataService.Model.Services;

public interface IClientCollection
{
    public Client? GetClientById(int clientID);
    public List<Client> GetAllClients();
}

