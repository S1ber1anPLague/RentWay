# Класс Client
Данный класс является наследником класса [Person](Person.md "Person")
## Атрибуты
- DriverLicense:string //Водительское удостоверение
- DayOfBirth:datetime //Дата рождения
- Comment:string //Комментарий
## Методы
- Client() - конструктор класса Client без параметров
- AddClient(): int – функция добавления клиента в БД
- DelClient(): boolean – функция удаления клиента из БД
- EditClient(): boolean – функция редактирования данных о клиенте
- GetCars(int sorting: string, int AskOrDesk:string, int count:int, int page:int): List<Car> – функция получения списка автомобилей
- GetEmployees(int sorting: string, int AskOrDesk:string, int count:int, int page:int): List<Employee> – функция получения списка сотрудников

