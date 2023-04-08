namespace majumi.CarService.ClientsDataService.Model.Services;

public interface IMechanicCollection
{
    public Mechanic? GetById(int searchedID);
    public Mechanic[] GetAllMechanics();
}

