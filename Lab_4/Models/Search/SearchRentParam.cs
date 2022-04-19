using System;

namespace Lab_4.Models.Search
{
    public class SearchRentParam
    {
        public SearchRentParam(int? number, DateTime start, DateTime end, int? period, 
            string carBrand, string clientFIO, string employeeFIO, bool? isOpen)
        {
            Number = number;
            Start = start;
            End = end;
            Period = period;
            CarBrand = carBrand;
            ClientFIO = clientFIO;
            EmployeeFIO = employeeFIO;
            IsOpen = isOpen;
        }

        public int? Number { get; }

        public DateTime Start { get; }

        public DateTime End { get; }

        public int? Period { get; }

        public string CarBrand { get; }

        public string ClientFIO { get; }

        public string EmployeeFIO { get; }


        public bool? IsOpen { get; }

        public static SearchRentParam Empty =>
            new SearchRentParam(null, DateTime.MinValue, DateTime.MaxValue,
                null, "", "", "", null);

        public static SearchRentParam OnlyOpen =>
            new SearchRentParam(null, DateTime.MinValue, DateTime.MaxValue,
                null, "", "", "", true);
    }
}
