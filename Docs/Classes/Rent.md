# Класс Rent
## Атрибуты 
- ID:int
- Car:[Car](./Car.md "Car") //Автомобиль
- RentalStartDate:DateTime //Дата начала проката
- RentalPeriod:DateTime //Срок проката
- Client:[Client](./Client.md "Client") //Клиент
- Employee:[Employee](./Employee.md "Employee") //Сотрудник
- TypeOfPayment:String //Тип оплаты
- Price:decimal //цена
- DepositAmount:decimal //Сумма залога
- AdditionalService:Dictionary<Service,int> //Дополнительная услуга
## Методы
- Rent(): void – пустой конструктор класса Rent без параметров
- AddRent(): int – функция добавления проката в БД
- DelRent(): boolean – функция удаления проката из БД
- EditRent(): boolean – функция изменения данных
- AddService(id: int): boolean – функция добавления услуги
- DelService(id: int): boolean – функция удаления услуги

