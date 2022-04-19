namespace Lab_4.Models.Statistics
{
    public class ClientsStatInfo
    {
        public ClientsStatInfo(int clientsCount, Info[] info)
        {
            ClientsCount = clientsCount;
            Info = info;
        }

        /// <summary>
        /// Количество клиентов
        /// </summary>
        public int ClientsCount { get; }
        /// <summary>
        /// Cписок постоянных клиентов
        /// </summary>
        public Info[] Info { get; }
    }
}
