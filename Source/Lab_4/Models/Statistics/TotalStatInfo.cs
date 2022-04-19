namespace Lab_4.Models.Statistics
{
    public class TotalStatInfo
    {
        public TotalStatInfo(int rentsCount, int clientsCount, int carsCount)
        {
            RentsCount = rentsCount;
            ClientsCount = clientsCount;
            CarsCount = carsCount;
        }

        /// <summary>
        /// Количество договоров по аренде
        /// </summary>
        public int RentsCount { get; }
        /// <summary>
        /// Число клиентов
        /// </summary>
        public int ClientsCount { get; }
        /// <summary>
        /// Количество автомобилей
        /// </summary>
        public int CarsCount { get; }
    }
}
