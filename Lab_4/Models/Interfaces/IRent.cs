using Lab_4.Models.Library;

namespace Lab_4.Models.Interfaces
{
    public interface IRent
    {
        int AddRent(Rent rent);
        bool DelRent(Rent rent);
        bool EditRent(Rent rent);
        bool AddService(ServiceInRentInfo info);
        bool DelService(ServiceInRentInfo info);
    }
}
