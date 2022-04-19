using System;

namespace Lab_4.Models.Library
{
    public class Car
    {
        public Car(int iD, string carBrand, string model, string color,
            DateTime yearOfIssue, double engineVolume, string driveType,
            string steeringWheelLocation, decimal depositAmount, decimal pricePerDay,
            string damage, string bodyType,
            bool isRented, string licensePlate)
        {
            ID = iD;
            CarBrand = carBrand;
            Model = model;
            Color = color;
            YearOfIssue = yearOfIssue;
            EngineVolume = engineVolume;
            DriveType = driveType;
            SteeringWheelLocation = steeringWheelLocation;
            DepositAmount = depositAmount;
            PricePerDay = pricePerDay;
            Damage = damage;
            BodyType = bodyType;
            IsRented = isRented;
            LicensePlate = licensePlate;
        }

        public int ID { get; }
        public string CarBrand { get; }
        public string Model { get; }
        public string Color { get; }
        public DateTime YearOfIssue { get; }
        public double EngineVolume { get; }
        public string DriveType { get; }
        public string SteeringWheelLocation { get; }
        public decimal DepositAmount { get; }
        public decimal PricePerDay { get; }
        public string Damage { get; }
        public string BodyType { get; }
        public bool IsRented { get; }

        public string LicensePlate { get; }

        public override string ToString()
        {
            return $"{CarBrand} ({Model}) : {PricePerDay} за день";
        }
    }
}
