using majumi.CarService.ClientsDataService.Model;

namespace majumi.CarService.ClientsDataService.Rest.Model.Services;

public interface IMechanicDataService
{
    public Mechanic GetMechanic(int mechanicID);

    public Mechanic[] GetAllMechanics();
}
