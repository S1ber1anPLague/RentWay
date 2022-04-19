namespace Lab_4.DataBase.Model
{
    public class ServiceInRent
    {
        public int ServiceInRentID { get; set; }

        public int RentId { get; set; }
        public virtual Rent Rent { get; set; }

        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
