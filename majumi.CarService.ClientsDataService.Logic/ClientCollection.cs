using majumi.CarService.ClientsDataService.Model;
using majumi.CarService.ClientsDataService.Model.Services;

namespace majumi.CarService.ClientsDataService.Logic;

public class ClientCollection : IClientCollection
{
    private static readonly List<Client> Clients;

    private static readonly object ClientLock = new();
    static ClientCollection()
    {
        Clients = new List<Client>(ClientCollectionReader.ReadFromJSON("Clients.json"));
    }

    public Client? GetById(int searchedId)
    {
        lock (ClientLock)
        {
            return Clients.Find(mechanic => mechanic.ClientID == searchedId);
        }
    }

    public Client[] GetAllClients()
    {
        lock (ClientLock)
        {
            return Clients.ToArray();
        }
    }
}