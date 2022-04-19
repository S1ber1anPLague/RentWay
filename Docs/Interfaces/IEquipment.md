# Интерфейс работающий с методами класса Equipment
## Методы интерфейса
+ AddEquipment ([equipment](../Classes/Equipment.md "Equipment") : [equipment](../Classes/Equipment.md "Equipment")): int – функция, добавляющая оснащение.;
+ DelEquipment (id : int): boolean – функция, удаляющая оснащение;
+ EditEquipment ([equipment](../Classes/Equipment.md "Equipment") : [equipment](../Classes/Equipment.md "Equipment")): boolean – функция, редактирующая инфор-мацию по оснащению;
+ GetCars (id : int, in sorting:string, in AscOrDesc:string, in filterA:Car, in filterB:Car, in count:int, in page:int): List<Car> – функция, которая возвращает список автомобилей, использующих данное оснащение. Параметр id – идентификатор оснащения. Функция должна вывести список автомобилей, которые его используют;
+ GetEquipments(sorting: string, AscOrDesc: string, filterA: Equipment, filterB: Equip-ment, count: int, page: int): List<Equipment> – функция, возвращающая список осна-щений заданными параметрами. Параметры: 
+	sorting: string – отвечает, по какому полю будет сортироваться список:
+	AscOrDesc: string – отвечает, по возрастанию или убыванию будут сортиро-ваться элементы;
+	filterA: Equipment – отвечает за фильтрацию, включает в себя левую границу интервала значений фильтра;
+	filterB: Equipment – отвечает за фильтрацию, включает в себя правую границу интервала значений фильтра; 
+	count: int – отвечает, сколько элементов необходимо показать;
+	page: int – отвечает, с какой страницы начинать поиск элементов.
