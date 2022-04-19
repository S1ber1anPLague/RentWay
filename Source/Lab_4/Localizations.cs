using Lab_4.Models.Library;
using System.Collections.Generic;

namespace Lab_4
{
    // вспомогательный класс для перевода названий на русский язык
    public static class Localizations
    {
        // словарь, ключ - название на английском, значение - название на русском
        private readonly static Dictionary<string, string> engToRuDictionary =
            new Dictionary<string, string>()
            {
                { nameof(Role.Admin), "Администратор" },
                { nameof(Role.Manager), "Менеджер"},
                { nameof(Role.Director),"Директор"  },

                { nameof(Client.DateOfBirth), "Дата Рождения" },
                { nameof(Client.DrivingLicense), "Водительское" },
                { nameof(Client.FIO), "ФИО" },
                { nameof(Client.Passport), "Паспорт" },
                { nameof(Client.PhoneNumber), "Телефон" },
                { nameof(Client.DealsCount), "Количество обращений" },

                { nameof(Employee.Role), "Роль" },

                { nameof(Employee.ITN), "Идентификационный код" },
                { nameof(Employee.Login), "Логин" },
                { nameof(Employee.Post), "Должность" },

                { nameof(Car.BodyType),"Тип кузова" },
                { nameof(Car.CarBrand), "Марка" },
                { nameof(Car.Color), "Цвет" },
                { nameof(Car.Damage), "Повреждения" },
                { nameof(Car.DepositAmount),"Сумма залога" },
                { nameof(Car.DriveType),"Тип привода" },
                { nameof(Car.EngineVolume), "Объем двигателя" },
                { nameof(Car.IsRented), "В аренде?" },
                { nameof(Car.LicensePlate), "Номер" },
                { nameof(Car.Model), "Модель" },
                { nameof(Car.PricePerDay), "Цена за сутки" },
                { nameof(Car.SteeringWheelLocation), "Расположение руля" },
                { nameof(Car.YearOfIssue), "Год выпуска" },

                { nameof(Service.Name), "Название" },
                { nameof(Service.Price), "Цена" },
                { nameof(Service.Specifications), "Спецификация" },

                { nameof(Rent.Car), "Авто" },
                { nameof(Rent.Client), "Клиент" },
                { nameof(Rent.Employee), "Сотрудник" },
                { nameof(Rent.RentalPeriod), "Срок" },
                { nameof(Rent.StartDate), "От" },
                { nameof(Rent.TypeOfPayment), "Способ оплаты" },
                { nameof(Rent.IsOpen), "Открыта?" },

                { nameof(Reception.Rent), "Дата возврата" },
                { nameof(Reception.EmployeeConclusion), "Вывод сотрудника" },
                { nameof(Reception.Id), "Идентификатор" },
                { nameof(Reception.DateOfReceipt), "Дата выдачи" },


                { nameof(ServiceInRentInfo.Service), "Услуга" },
                { nameof(ServiceInRentInfo.Quantity), "Количество" }
            };

        // метод возвращающий перевод для слова или само слово если перевода нет в словаре
        public static string GetValueOrSelf(string txt)
        {
            if (engToRuDictionary.TryGetValue(txt, out string value))
            {
                return value;
            }

            return txt;
        }
    }
}
