using System;

namespace Lab_4.DataBase.Model
{
    public enum CarStatus { Available, Rented }
    public class Car
    {
        public int CarID { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public DateTime YearOfIssue { get; set; }
        public double EngineVolume { get; set; }
        public int BodyTypeID { get; set; }
        public virtual BodyType BodyType { get; set; }
        public string DriveType { get; set; }
        public string SteeringWheelLocation { get; set; }
        public int CarBrandID { get; set; }
        public virtual CarBrand CarBrand { get; set; }
        public decimal DepositAmount { get; set; }
        public decimal PricePerDay { get; set; }
        public string Damage { get; set; }
        public DateTime DateAdded { get; set; }
        public string LicensePlate { get; set; }
        public CarStatus Status { get; set; }
    }
}