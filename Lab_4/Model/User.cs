using System;

namespace Lab_4.Model
{
    /*
     * Table User as US {
    UserID int [pk,increment]
    UserType smallint
    FIO text
    PhoneNumber text
    Passport text
    DateAdded datetime
    Login text
    Pass text
    DrivingLicense text
    DateOfBirth datetime
    Post text
    ITN text
    }
    */
    public enum UserType { Admin, Manager, Director }
    public class User
    {
        public int UserID { get; set; }
        public UserType UserType { get; set; }
        public string FIO { get; set; }
        public string PhoneNumber { get; set; }
        public string Passport { get; set; }
        public DateTime DateAdded { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public string DrivingLicense { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Post { get; set; }
        public string ITN { get; set; }
    }

}
