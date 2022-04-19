# Интерфейс работающий с методами класса Service
## Методы интерфейса
+ AddService ([service](../Classes/Service.md "Service") : [service](../Classes/Service.md "Service")): int – функция, добавляющая дополнительную услугу.;
+ DelService (id : int): boolean – функция, удаляющая дополнительную услугу;
+ EditService ([service](../Classes/Service.md "Service") : [service](../Classes/Service.md "Service")): boolean – функция, редактирующая дополнительную услугу;
+ GetRents (id : int, in sorting:string, in AscOrDesc:string, in filterA:Rent, in filterB:Rent, in count:int, in page:int): List<Rent> – функция, которая возвращает список аренд, в котурую входила определенная дополнительная услуга. Параметр id – идентифика-тор дополнительной услуги, аренды которой должна вывести функция;
+ GetServices(sorting: string, AscOrDesc: string, filterA: Service, filterB: Service, count: int, page: int): List<Service> – функция, возвращающая список дополнительных услуг с заданными параметрами. Параметры: 
+	sorting: string – отвечает, по какому полю будет сортироваться список:
+	AscOrDesc: string – отвечает, по возрастанию или убыванию будут сортиро-ваться элементы;
+	filterA: Service – отвечает за фильтрацию, включает в себя левую границу ин-тервала значений фильтра;
+	filterB: Service – отвечает за фильтрацию, включает в себя правую границу ин-тервала значений фильтра; 
+	count: int – отвечает, сколько элементов необходимо показать;
+	page: int – отвечает, с какой страницы начинать поиск элементов.

