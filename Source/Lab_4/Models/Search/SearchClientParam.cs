namespace Lab_4.Models.Search
{
    // класс содержащий все параметры для поиска по клиентам
    public class SearchClientParam
    {
        public SearchClientParam(string passport, string drivingLicense, 
            string fIO, string phone, int? dealsCount)
        {
            DrivingLicense = drivingLicense;
            Passport = passport;
            FIO = fIO;
            Phone = phone;
            DealsCount = dealsCount;
        }

        public string DrivingLicense { get; }

        public string Passport { get; }

        public string FIO { get; }

        public string Phone { get; }

        public int? DealsCount { get; }

        public static SearchClientParam Empty =>
            new SearchClientParam("", "", "", "", null);
    }
}
