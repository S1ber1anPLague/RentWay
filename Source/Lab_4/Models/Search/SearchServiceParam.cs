namespace Lab_4.Models.Search
{
    // класс содержащий все параметры для поиска по услугам
    public class SearchServiceParam
    {
        public SearchServiceParam(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public static SearchServiceParam Empty =>
            new SearchServiceParam("");
    }
}
