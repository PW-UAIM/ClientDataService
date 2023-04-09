using System.Text.Json;
using majumi.CarService.ClientsDataService.Model;

namespace majumi.CarService.ClientsDataService.Logic;

public class ClientCollectionReader
{
    public static Client[]? ReadFromJSON(string path)
    {
        return JsonSerializer.Deserialize<Client[]>(File.ReadAllText(path));
    }
}
