using System;

namespace Lab_4.DataBase.Model
{
    public class User
    {
        public int UserID { get; set; }
        public Models.Library.Role UserType { get; set; }
        public string FIO { get; set; }
        public string PhoneNumber { get; set; }
        public string Passport { get; set; }
        public DateTime DateAdded { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public string Post { get; set; }
        public string ITN { get; set; }
        public string DrivingLicense { get; set; }
        public DateTime? DateOfBirth { get; set; }

    }

}
