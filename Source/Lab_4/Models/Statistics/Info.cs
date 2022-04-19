namespace Lab_4.Models.Statistics
{
    // вспомогательный класс для хранения информации по количеству
    // value - "ключ", count - количество
    public class Info
    {
        public Info(string value, int count)
        {
            Value = value;
            Count = count;
        }

        public string Value { get; }

        public int Count { get; }
    }
}
