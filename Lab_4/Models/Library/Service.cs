namespace Lab_4.Models.Library
{
    public class Service
    {
        public Service(int iD, string name, string specifications, decimal price)
        {
            ID = iD;
            Name = name;
            Specifications = specifications;
            Price = price;
        }

        public int ID { get; }
        public string Name { get; }
        public string Specifications { get; }
        public decimal Price { get; }

        public override string ToString()
        {
            return $"{Name,20} : {Price}";
        }
    }
}
