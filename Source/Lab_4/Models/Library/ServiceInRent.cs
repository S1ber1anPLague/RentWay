namespace Lab_4.Models.Library
{
    public class ServiceInRentInfo
    {
        public ServiceInRentInfo(int rentId, int serviceInRentId, Service service, decimal price, int quantity)
        {
            RentId = rentId;
            ServiceInRentId = serviceInRentId;
            Service = service;
            Price = price;
            Quantity = quantity;
        }
        public int ServiceInRentId { get; }
        public int RentId { get; }
        public Service Service { get; }
        public decimal Price { get; }
        public int Quantity { get; }
    }
}
