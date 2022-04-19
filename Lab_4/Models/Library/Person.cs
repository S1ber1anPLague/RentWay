using System;

namespace Lab_4.Models.Library
{
    public abstract class Person
    {
        protected Person(int iD, string fIO, string phoneNumber, string passport, Role role)
        {
            ID = iD;
            FIO = fIO;
            PhoneNumber = phoneNumber;
            Passport = passport;
            Role = role;
        }
        public Role Role { get; }
        public int ID { get; }
        public string FIO { get; }
        public string PhoneNumber { get; }
        public string Passport { get; }

        public override string ToString()
        {
            return FIO;
        }
    }

    public class Client : Person
    {
        public Client(string drivingLicense, DateTime dateOfBirth,
            int iD, string fIO, string phoneNumber, string passport,
            int dealsCount)
            : base(iD, fIO, phoneNumber, passport, Role.Client)
        {
            DrivingLicense = drivingLicense;
            DateOfBirth = dateOfBirth;
            DealsCount = dealsCount;
        }

        public string DrivingLicense { get; }
        public DateTime DateOfBirth { get; }
        public int DealsCount { get; }
    }

    public class Employee : Person
    {
        public Employee(
            string login, string pass, string post, string iTN,
            int iD, string fIO, string phoneNumber, string passport,
            Role role)
            : base(iD, fIO, phoneNumber, passport, role)
        {
            Login = login;
            Pass = pass;
            Post = post;
            ITN = iTN;
        }

        public string Login { get; }
        public string Pass { get; }
        public string Post { get; }
        public string ITN { get; }
    }

    public enum Role { Admin, Manager, Director, Client }
}
