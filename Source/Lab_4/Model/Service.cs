namespace Lab_4.Model
{
    /*
     * Table Services as S {
  ServiceID int [pk,increment]
  Name text
  Specifications text
  Price decimal
}
    */
    public class Service
    {
        public int ServiceID { get; set; }
        public string Name { get; set; }
        public string Specifications { get; set; }
        public decimal Price { get; set; }
    }
}
