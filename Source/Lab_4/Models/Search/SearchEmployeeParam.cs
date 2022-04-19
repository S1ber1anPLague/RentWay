namespace Lab_4.Models.Search
{
    // класс содержащий все параметры для поиска по сотрудникам
    public class SearchEmployeeParam
    {
        public SearchEmployeeParam(string login, string post, string passport, string fIO, string phone)
        {
            Login = login;
            Post = post;
            Passport = passport;
            FIO = fIO;
            Phone = phone;
        }

        public string Login { get; }

        public string Post { get; }

        public string Passport { get; }

        public string FIO { get; }

        public string Phone { get; }

        public static SearchEmployeeParam Empty =>
            new SearchEmployeeParam("", "", "", "", "");
    }
}
