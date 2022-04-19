using System;
using System.Text;

namespace Lab_4.Models.Library
{
    public class Reception
    {
        public Reception(int id, DateTime dateOfReceipt, string employeeConclusion, Rent rent)
        {
            Id = id;
            DateOfReceipt = dateOfReceipt;
            EmployeeConclusion = employeeConclusion;
            Rent = rent;
        }

        public int Id { get; }
        public DateTime DateOfReceipt { get; }
        public string EmployeeConclusion { get; }
        public Rent Rent { get; }

        public string GetDetails()
        {
            var sb = new StringBuilder();
            var format = "{0, -30} : {1}";
            sb.AppendFormat(format, "Идентификатор", Id);
            sb.AppendLine();
            sb.AppendFormat(format, "Дата выдачи", Rent.StartDate);
            sb.AppendLine();
            sb.AppendFormat(format, "Дата приема", DateOfReceipt);
            sb.AppendLine();
            sb.AppendFormat(format, "Цена", Rent.Price);
            sb.AppendLine();
            sb.AppendFormat(format, "Клиент", Rent.Client.FIO);
            sb.AppendLine();
            sb.AppendFormat(format, "Сотрудник", Rent.Employee.FIO);
            sb.AppendLine();
            sb.AppendFormat(format, "Заключение", EmployeeConclusion);
            sb.AppendLine();
            return sb.ToString();
        }
    }
}
