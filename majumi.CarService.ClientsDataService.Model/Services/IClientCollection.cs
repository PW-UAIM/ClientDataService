namespace majumi.CarService.ClientsDataService.Model.Services;

public interface IClientCollection
{
    public Client? GetById(int searchedID);
    public Client[] GetAllClients();
}

