# Интерфейс работает с методами класса Car
## Методы интерфейса
+ AddCar ([car](../Classes/Car.md "Car") : [car](../Classes/Car.md "Car")): int – функция, добавляющая автомобиль. 
+ DelCar (id : int): boolean – функция, удаляющая автомобиль.
+ EditCar ([car](../Classes/Car.md "Car") : [car](../Classes/Car.md "Car")): boolean – функция, редактирующая автомобиль;
+ GetRents (id : int, in sorting:string, in AscOrDesc:string, in filterA:Rent, in filterB:Rent, in count:int, in page:int): List<Rent> – функция, которая возвращает список аренд, в которых участвовал автомобиль. Параметр id – идентификатор автомобиля, аренды которого должна вывести функция;
+ GetClients (id : int, , in sorting:string, in AscOrDesc:string, in filterA:Client, in fil-terB:Client, in count:int, in page:int): List<Client> – функция, которая возвращает спи-сок клиентов, арендовавших данный автомобиль. Параметр id – идентификатор ав-томобиля, арендаторов которого должна вывести функция;
+ GetEquipments (id : int): List<Equipment> – функция, которая возвращает список оснащений определенного автомобиля. Параметр id – идентификатор автомобиля, оснащения которого должна вывести функция;

+ GetCars(sorting: string, AscOrDesc: string, filterA: Car, filterB: Car, count: int, page: int): List<Client> – функция, возвращающая список автомобилей с заданными пара-метрами. Параметры: 
+	sorting: string – отвечает, по какому полю будет сортироваться список:
+	AscOrDesc: string – отвечает, по возрастанию или убыванию будут сортиро-ваться элементы;
+	filterA: Car – отвечает за фильтрацию, включает в себя левую границу интер-вала значений фильтра;
+	filterB: Car – отвечает за фильтрацию, включает в себя правую границу интер-вала значений фильтра; 
+	count: int – отвечает, сколько элементов необходимо показать;
+	page: int – отвечает, с какой страницы начинать поиск элементов.
