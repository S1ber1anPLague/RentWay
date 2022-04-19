using System;

namespace Lab_4.Models.Library
{
    public class ReceptionInfo
    {
        public ReceptionInfo(int rentID, int carID, DateTime dateOfReceipt, string employeeConclusion, string damage)
        {
            RentID = rentID;
            CarID = carID;
            DateOfReceipt = dateOfReceipt;
            EmployeeConclusion = employeeConclusion;
            Damage = damage;
        }

        public int RentID { get; }
        public int CarID { get; }
        public DateTime DateOfReceipt { get; set; }
        public string EmployeeConclusion { get; set; }
        public string Damage { get; }
    }
}
