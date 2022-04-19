namespace Lab_4.Models.Statistics
{
    public class CarsStatInfo
    {
        public CarsStatInfo(int rentedCar, Info[] info)
        {
            RentedCar = rentedCar;
            Info = info;
        }

        /// <summary>
        /// Количество находившихся в аренде автомобилей
        /// </summary>
        public int RentedCar { get; }
        /// <summary>
        /// Рейтинг наиболее популярных для аренды автомобилей
        /// </summary>
        public Info[] Info { get; }    
    }
}
