using System;

namespace Lab_4.Model
{
    /*
     * Table Rents as R {
  RentID int [pk, increment] // auto-increment
  StartDate datetime
  RentalPeriod int
  CarID int
  UserID int
  ReturnDate datetime
  TypeOfPayment string
  Price decimal
  DepositAmount decimal
  ClientComment text
  DateAdded datetime
  CommercialComment text
  ReceptionID int
}
    */
    public class Rent
    {
        public int RentID { get; set; }
        public DateTime StartDate { get; set; }
        public int RentalPeriod { get; set; }
        public int CarID { get; set; }
        public virtual Car Car { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public DateTime ReturnDate { get; set; }
        public string TypeOfPayment { get; set; }
        public decimal Price { get; set; }
        public decimal DepositAmount { get; set; }
        public string ClientComment { get; set; }
        public DateTime DateAdded { get; set; }
        public string CommercialComment { get; set; }
        public int ReceptionID { get; set; }
        public virtual Reception Reception { get; set; }
    }
}
