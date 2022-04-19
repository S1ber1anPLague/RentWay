using Lab_4.Models.Library;

namespace Lab_4.Models.Interfaces
{
    public interface IEmployee
    {
        int AddEmployee(Employee employee);
        bool DelEmployee(Employee employee);
        bool EditEmployee(Employee employee);
    }
}
