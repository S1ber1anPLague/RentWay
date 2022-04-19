namespace Lab_4.Model
{
    /*
     * Table BodyTypes as B {
  BodyTypeID int [pk,increment]
  BodyType text
}
    */
    public class BodyType
    {
        public int BodyTypeID { get; set; }
        public string Type { get; set; }
    }
}
