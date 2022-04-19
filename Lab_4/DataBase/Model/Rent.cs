using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab_4.DataBase.Model
{
    public class Rent
    {
        public int RentID { get; set; }
        public DateTime StartDate { get; set; }
        public int RentalPeriod { get; set; }
        public int CarID { get; set; }
        public virtual Car Car { get; set; }
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual User User { get; set; }
        public int ClientID { get; set; }
        [ForeignKey("ClientID")]
        public virtual User Client { get; set; }
        public DateTime ReturnDate { get; set; }
        public string TypeOfPayment { get; set; }
        public decimal Price { get; set; }
        public decimal DepositAmount { get; set; }
        public string ClientComment { get; set; }
        public DateTime DateAdded { get; set; }
        public string CommercialComment { get; set; }
        public bool IsOpen { get; set; }
    }
}
