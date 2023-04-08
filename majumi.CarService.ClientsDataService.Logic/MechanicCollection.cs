using majumi.CarService.ClientsDataService.Model;
using majumi.CarService.ClientsDataService.Model.Services;

namespace majumi.CarService.ClientsDataService.Logic;

public class MechanicCollection : IMechanicCollection
{
    private static readonly List<Mechanic> Mechanics;

    private static readonly object MechanicLock = new();
    static MechanicCollection()
    {
        Mechanics = new List<Mechanic>(MechanicCollectionReader.ReadFromJSON("Mechanics.json"));
    }

    public Mechanic? GetById(int searchedId)
    {
        lock (MechanicLock)
        {
            return Mechanics.Find(mechanic => mechanic.MechanicID == searchedId);
        }
    }

    public Mechanic[] GetAllMechanics()
    {
        lock (MechanicLock)
        {
            return Mechanics.ToArray();
        }
    }
}