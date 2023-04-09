using System.Diagnostics;
using System.Text.Json;
using majumi.CarService.ClientsDataService.Model;
using majumi.CarService.ClientsDataService.Model.Services;
using majumi.CarService.ClientsDataService.Rest.Model.Model;
using majumi.CarService.ClientsDataService.Rest.Model.Services;

using majumi.CarService.ClientsDataService.Logic;

namespace majumi.CarService.ClientsDataService.Rest.Tests;
public class Tests : ITestsService
{
    private static readonly HttpClient httpClient = new();

    public string RunTests(string host, int port)
    {
        Debug.Assert(condition: port > 0);

        try
        {
            IClientCollection clientCollection = new ClientCollection();

            Client[] clients1 = clientCollection.GetAllClients();
            ClientData[] clients2 = GetClients(host, (ushort)port);

            Debug.Assert(condition: clients1.Length == clients2.Length);
        }
        catch (Exception e)
        {
            return e.Message;
        }
        return "No errors";
    }

    private ClientData[] GetClients(string webServiceHost, ushort webServicePort)
    {
        string webServiceUri = string.Format("https://{0}:{1}/allClients", webServiceHost, webServicePort);

        Task<string> webServiceCall = CallWebService(HttpMethod.Get, webServiceUri);

        webServiceCall.Wait();

        string jsonResponseContent = webServiceCall.Result;

        ClientData[] clients = ConvertJson(jsonResponseContent);

        return clients;
    }

    public static async Task<string> CallWebService(HttpMethod httpMethod, string webServiceUri)
    {
        HttpRequestMessage httpRequestMessage = new HttpRequestMessage(httpMethod, webServiceUri);

        httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

        HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

        httpResponseMessage.EnsureSuccessStatusCode();

        string httpResponseContent = await httpResponseMessage.Content.ReadAsStringAsync();

        return httpResponseContent;
    }

    public ClientData[] ConvertJson(string json)
    {
        ClientData[] clients = JsonSerializer.Deserialize<ClientData[]>(json);

        return clients;
    }
}

