namespace Lab_4.Model
{
    /*
     * Table EquipmentInCar {
  CarID int
  EquipmentID int
  Quantity int
}
    */
    public class EquipmentInCar
    {
        public int EquipmentInCarID { get; set; }

        public int CarID { get; set; }
        public virtual Car Car { get; set; }

        public int EquipmentID { get; set; }
        public virtual Equipment Equipment { get; set; }

        public int Quantity { get; set; }
    }
}
