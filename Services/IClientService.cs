/*
public interface IClientService
{
    Task<int> CreerClient(Client client);
    Task<IEnumerable<Client>> GetClients();
}

public class ClientService : IClientService
{
    private List<Client> clients = new List<Client>();
    private int clientIdCounter = 1;

    public async Task<int> CreerClient(Client client)
    {
        client.Id = clientIdCounter++;
        clients.Add(client);
        return client.Id;
    }

    public async Task<IEnumerable<Client>> GetClients()
    {
        return clients;
    }
}
*/