using System.Text.Json;
using majumi.CarService.ClientsDataService.Model;

namespace majumi.CarService.ClientsDataService.Logic;

public class MechanicCollectionReader
{
    public static Mechanic[]? ReadFromJSON(string path)
    {
        return JsonSerializer.Deserialize<Mechanic[]>(File.ReadAllText(path));
    }
}
