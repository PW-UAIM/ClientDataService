using majumi.CarService.ClientsDataService.Model;
using majumi.CarService.ClientsDataService.Rest.Model.Model;

namespace majumi.CarService.ClientsDataService.Rest.Model.Converters;

public static class DataConverter
{
    public static ClientData ConvertToClientData(this Client client)
    {
        return new ClientData
        {
            ClientID = client.ClientID,
            FirstName = client.FirstName,
            LastName = client.LastName,
            Address = client.Address,
            PhoneNumber = client.PhoneNumber,
            Email = client.Email,
            InsuranceCompany = client.InsuranceCompany,
            PolicyNumber = client.PolicyNumber
        };
    }
}