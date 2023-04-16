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

    public static List<ClientData> ConvertToVisitDataList(this List<Client> clients)
    {
        List<ClientData> clientData = new();

        foreach (Client c in clients)
        {
            clientData.Add(ConvertToClientData(c));
        }

        return clientData;
    }
}