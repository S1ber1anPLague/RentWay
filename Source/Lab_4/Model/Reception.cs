using System;

namespace Lab_4.Model
{
    /*
    Table Reception as Re {
  ReceptionID int [pk,increment]
  DateOfReceipt datetime
  EmployeeConclusion text
}
*/
    public class Reception
    {
        public int ReceptionID { get; set; }
        public DateTime DateOfReceipt { get; set; }
        public string EmployeeConclusion { get; set; }
    }
}
