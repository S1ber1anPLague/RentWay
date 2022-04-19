namespace Lab_4.Model
{
    /*
     * Table CarBrands as CB {
  CarBrandID int [pk,increment]
  CarBrand text
}
    */
    public class CarBrand
    {
        public int CarBrandID { get; set; }
        public string Brand { get; set; }
    }
}
