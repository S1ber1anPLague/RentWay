using Lab_4.Models.Statistics;

namespace Lab_4.Models.Interfaces
{
    interface IStat
    {
        CarsStatInfo GetCarsStatInfo();

        ClientsStatInfo GetClientsStatInfo();

        TotalStatInfo GetTotalStatInfo();
    }
}
