# Интерфейс работает с методами класса Client
## Методы интерфейса
+ AddClient ([client](../Classes/Client.md "Client") : [client](../Classes/Client.md "Client")): int – функция, добавляющая клиента.
+ DelClient (id : int): boolean – функция, удаляющая клиента;
+ EditClient ([client](../Classes/Client.md "Client") : [client](../Classes/Client.md "Client")): boolean – функция, редактирующая клиента;
+ GetRents (id : int, in sorting:string, in AscOrDesc:string, in filterA:Rent, in filterB:Rent, in count:int, in page:int): List<Rent> – функция, которая возвращает список аренд, определенного клиента. Параметр id – идентификатор клиента, аренды которого должна вывести функция;
+ GetCars (id : int, in sorting:string, in AscOrDesc:string, in filterA:Car, in filterB:Car, in count:int, in page:int): List<Cars> – функция, которая возвращает список автомобилей, находившихся в использовании у определенного клиента. Параметр id – иден-тификатор клиента, автомобилей которого должна вывести функция;
+ GetEmployees (id : int, in sotring:string, in AscOrDesc:string, in filterA:Employee, in filterB:Employee, in count:int, in page:int): List<Employee> – функция, которая воз-вращает список сотрудников, обслуживавших определенного клиента. Параметр id – идентификатор клиента, обслуживших менеджеров которого должна вывести функ-ция;

+ GetClients(sorting: string, AscOrDesc: string, filterA: Client, filterB: Client, count: int, page: int): List<Client> – функция, возвращающая список клиентов с заданными па-раметрами. Параметры: 
+	sorting: string – отвечает, по какому полю будет сортироваться список:
+	AscOrDesc: string – отвечает, по возрастанию или убыванию будут сортиро-ваться элементы;
+	filterA: Client – отвечает за фильтрацию, включает в себя левую границу ин-тервала значений фильтра;
+	filterB: Client – отвечает за фильтрацию, включает в себя правую границу ин-тервала значений фильтра; 
+	count: int – отвечает, сколько элементов необходимо показать;
+	page: int – отвечает, с какой страницы начинать поиск элементов.
