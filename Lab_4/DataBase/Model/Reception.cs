using System;

namespace Lab_4.DataBase.Model
{
    public class Reception
    {
        public int ReceptionID { get; set; }
        public DateTime DateOfReceipt { get; set; }
        public string EmployeeConclusion { get; set; }
        public int RentID { get; set; }
        public virtual Rent Rent { get; set; }
    }
}
