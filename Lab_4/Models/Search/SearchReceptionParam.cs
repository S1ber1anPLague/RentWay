namespace Lab_4.Models.Search
{
    // класс содержащий все параметры для поиска по возвратам из аренды
    public class SearchReceptionParam
    {
        public SearchReceptionParam(int? clientId = null, int? carId = null, int? employeeId = null)
        {
            CarId = carId;
            ClientId = clientId;
            EmployeeId = employeeId;
        }

        public int? CarId { get; }

        public int? ClientId { get; }

        public int? EmployeeId { get; }
        // вспомогательный экземпляр для поиска по ID клиента
        public static SearchReceptionParam SearchByClientId(int id) =>
            new SearchReceptionParam(clientId:id);
        // вспомогательный экземпляр для поиска по ID автомобиля
        public static SearchReceptionParam SearchByCarId(int id) =>
            new SearchReceptionParam(carId: id);
        // вспомогательный экземпляр для поиска по ID сотрудника
        public static SearchReceptionParam SearchByEmployeeId(int id) =>
            new SearchReceptionParam(employeeId:id);
    }
}
