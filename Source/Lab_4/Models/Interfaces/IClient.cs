using Lab_4.Models.Library;

namespace Lab_4.Models.Interfaces
{
    public interface IClient
    {
        int AddClient(Client client);
        bool DelClient(Client client);
        bool EditClient(Client client);
    }
}
