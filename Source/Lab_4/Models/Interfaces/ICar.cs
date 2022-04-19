using Lab_4.Models.Library;

namespace Lab_4.Models.Interfaces
{
    public interface ICar
    {
        int AddCar(Car car);
        bool DelCar(Car car);
        bool EditCar(Car car);
    }
}
