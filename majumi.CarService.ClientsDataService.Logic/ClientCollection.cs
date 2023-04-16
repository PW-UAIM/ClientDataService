using majumi.CarService.ClientsDataService.Model;
using majumi.CarService.ClientsDataService.Model.Services;
using System.ComponentModel;

namespace majumi.CarService.ClientsDataService.Logic;

public class ClientCollection : IClientCollection
{
    private static readonly List<Client> Clients;

    private static readonly object ClientLock = new();
    static ClientCollection()
    {
        Clients = new List<Client>(ClientCollectionReader.ReadFromJSON("Clients.json"));
    }

    private Client? FindByID(int clientID)
    {
        foreach (Client client in Clients)
        {
            if (client.ClientID == clientID)
            {
                return client;
            }
        }

        return null;
    }

    public Client? GetClientById(int clientID)
    {
        lock (ClientLock)
        {
            return this.FindByID(clientID);
        }
    }

    public List<Client> GetAllClients()
    {
        lock (ClientLock)
        {
            return Clients;
        }
    }
}