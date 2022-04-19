using Lab_4.Models.Library;

namespace Lab_4.Models.Interfaces
{
    public interface IService
    {
        int AddService(Service service);
        bool DelService(Service service);
        bool EditService(Service service);
    }
}
