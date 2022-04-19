using System;
using System.Collections.Generic;

namespace Lab_4.Models.Library
{
    public class Rent
    {
        public Rent(int iD, Car car, Employee employee, Client client, DateTime startDate, int rentalPeriod, string typeOfPayment, 
            decimal price, decimal depositAmount, bool isOpen = true, ServiceInRentInfo[] additionalService = null)
        {
            ID = iD;
            Car = car;
            Employee = employee;
            Client = client;
            StartDate = startDate;
            RentalPeriod = rentalPeriod;
            TypeOfPayment = typeOfPayment;
            Price = price;
            DepositAmount = depositAmount;
            AdditionalService = additionalService;

            if (additionalService != null)
            {
                AdditionalService = additionalService;
            }
            else
            {
                AdditionalService = new ServiceInRentInfo[] { };
            }
            IsOpen = isOpen;
        }

        public int ID { get; }
        public Car Car { get; }
        public Employee Employee { get; }
        public Client Client { get; }
        public DateTime StartDate { get; }
        public int RentalPeriod { get; }
        public string TypeOfPayment { get; }
        public decimal Price { get; }
        public decimal DepositAmount { get; }
        public ServiceInRentInfo[] AdditionalService { get; }

        public bool IsOpen { get; }
    }
}
