namespace Lab_4.Models.Search
{
    // класс содержащий все параметры для поиска по автомобилям
    public class SearchCarParam
    {
        public SearchCarParam(string brand, int startYear, int endYear, 
            string color, string driveType, bool? isAvailable)
        {
            Brand = brand;
            StartYear = startYear;
            EndYear = endYear;
            Color = color;
            DriveType = driveType;
            IsAvailable = isAvailable;
        }

        public string Brand { get; }

        public int StartYear { get; }

        public int EndYear { get; }

        public string Color { get; }

        public string DriveType { get; }

        public bool? IsAvailable { get; }
        // вспомогательный экземпляр для поиска без фильтров
        public static SearchCarParam Empty =>
            new SearchCarParam("", int.MinValue, int.MaxValue, "", "", null);
        // вспомогательный экземпляр для поиска доступных машин
        public static SearchCarParam OnlyAvailable =>
            new SearchCarParam("", int.MinValue, int.MaxValue, "", "", true);
    }
}
