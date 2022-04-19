namespace Lab_4.DataBase
{
    // класс для хранения значений заносимых в БД по умолчанию
    // в том случае когда она не заполнена
    static class DefaultData
    {
        // менеджер
        public static Models.Library.Employee Manager { get; } =
            new Models.Library.Employee(
                "Manager1",
                "1111",
                "Менеджер",
                "7830002293",
                0,
                "Рзаева Анфиса Сергеевна",
                "+79646293867",
                "4213248300",
                Models.Library.Role.Manager
                );
        // админ
        public static Models.Library.Employee Admin { get; } =
            new Models.Library.Employee(
                "Admin1",
                "1234",
                "Админ",
                "3664069397",
                0,
                "Грушанин Арсений Валерьевич",
                "+79348414616",
                "4920569820",
                Models.Library.Role.Admin
            );
        // директор
        public static Models.Library.Employee Director { get; } =
            new Models.Library.Employee(
                "Dir1",
                "x00x",
                "Исполнительный директор",
                "7707083893",
                0,
                "Баландин Виталий Вячеславович",
                "+79302078839",
                "4920854659",
                Models.Library.Role.Director
            );
    }
}
