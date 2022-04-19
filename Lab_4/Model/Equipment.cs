namespace Lab_4.Model
{
    /*
     * Table Equipments as Eq {
  EquipmentID int [pk,increment]
  Name text
  Specifications text
}
    */
    public class Equipment
    {
        public int EquipmentID { get; set; }
        public string Name { get; set; }
        public string Specifications { get; set; }
    }
}
