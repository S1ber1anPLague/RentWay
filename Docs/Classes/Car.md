# Класс Car
## Атрибуты
- ID:int
- CarBrand:string //Марка
- Model:string //Модель
- Color:string //Цвет
- EngineVolume:double //Объем двигателя
- BodyType:BodyType //Тип кузова
- DriveType:string //Тип привода
- SteeringWheelLocation:string //Расположение руля
- DepositAmount:decimal //Сумма залога
- PricePerDay:decimal //Цена за один день
- Damage:string //Повреждения
- IsRented:boolean //Статус автоомобиля
- YearOfIssue:datetime // Год выпуска
- Equipments:Dictionary<Equipment,int> //Оснащения автомобиля
## Методы
- Car(): void – конструктор класса Car без параметров
- AddCar(): int – функция добавления автомобиля в БД
- DelCar(): boolean – функция удаления автомобиля из БД
- EditCar(): boolean – функция изменения данных об Автомобиле
- GetClients(int sorting: string, int AskOrDesk:string, int count:int, int page:int): List<Client> – функция получения списка клиентов
- GetRents(int sorting: string, int AskOrDesk:string, int count:int, int page:int): List<Rent> – функция получения списка аренд

