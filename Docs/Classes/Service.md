# Класс Service
## Атрибуты
- ID:int
- Name:string //Название
- Specification:string //Описание
- Price:decimal //Цена
## Методы
- Service(): void – конструктор класса Service без параметров.
- AddService(): int – функция добавления услуги в БД
- DelService(): boolean – функция удаления услуги из БД
- Edit(): boolean – функция изменения данных
- GetRents(int sorting: string, int AskOrDesk:string, int count:int, int page:int): List<Rent> – функция получения списка аренд
