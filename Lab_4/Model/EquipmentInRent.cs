namespace Lab_4.Model
{
    /*
     * Table EquipmentInRent as ER {
  RentID int
  EquipmentID int
}
    */
    public class EquipmentInRent
    {
        public int EquipmentInRentEquipmentInRentID { get; set; }
        public int RentID { get; set; }
        public virtual Rent Rent { get; set; }
        public int EquipmentID { get; set; }
        public virtual Equipment Equipment { get; set; }
    }
}
