using Lab_4.DataBase.Model;
using System;

namespace Lab_4.DataBase
{
    // вспомогательные методы для преобразования
    // модельных классов в классы-БД
    // и обратно
    // для простейших случаев, когда модельные классы
    // не содержат логики требущей информации из других таблиц
    static class Mapper
    {
        public static Models.Library.Employee FromUser(User user)
        {
            return new Models.Library.Employee(user.Login, user.Pass, user.Post,
                user.ITN, user.UserID, user.FIO, user.PhoneNumber, user.Passport, user.UserType);
        }

        public static User CreateUserFromEmployee(Models.Library.Employee employee)
        {
            return new User()
            {
                Login = employee.Login,
                Pass = employee.Pass,
                Post = employee.Post,
                ITN = employee.ITN,
                FIO = employee.FIO,
                PhoneNumber = employee.PhoneNumber,
                Passport = employee.Passport,
                UserType = employee.Role,
                DateAdded = DateTime.Now
            };
        }

        public static void UpdateUser(this User user, Models.Library.Employee employee)
        {
            user.Login = employee.Login;
            user.Pass = employee.Pass;
            user.Post = employee.Post;
            user.ITN = employee.ITN;
            user.FIO = employee.FIO;
            user.PhoneNumber = employee.PhoneNumber;
            user.Passport = employee.Passport;
            user.UserType = employee.Role;
            user.DateAdded = DateTime.Now;
        }

        public static User CreateUserFromClient(Models.Library.Client client)
        {
            return new User()
            {
                DrivingLicense = client.DrivingLicense,
                FIO = client.FIO,
                PhoneNumber = client.PhoneNumber,
                Passport = client.Passport,
                UserType = client.Role,
                DateAdded = DateTime.Now,
                DateOfBirth = new DateTime?(client.DateOfBirth)
            };
        }


        public static void UpdateUser(this User user, Models.Library.Client client)
        {
            user.DrivingLicense = client.DrivingLicense;
            user.FIO = client.FIO;
            user.PhoneNumber = client.PhoneNumber;
            user.Passport = client.Passport;
            user.UserType = client.Role;
            user.DateOfBirth = new DateTime?(client.DateOfBirth);
        }

        public static Models.Library.Employee GetEmployeeFromUser(User user)
        {
            return new Models.Library.Employee(
                user.Login, user.Pass, user.Post, user.ITN,
                user.UserID, user.FIO, user.PhoneNumber,
                user.Passport, user.UserType
                );
        }

        public static Models.Library.Service GetServiceFromDb(Service service)
        {
            return new Models.Library.Service(service.ServiceID, service.Name,
                service.Specifications, service.Price);
        }

        public static Service CreateServiceFromModel(Models.Library.Service service)
        {
            return new Service()
            {
                Price = service.Price,
                ServiceID = service.ID,
                Name = service.Name,
                Specifications = service.Specifications
            };
        }

        public static void UpdateServiceDbWithModel(this Service serviceDb, Models.Library.Service service)
        {
            serviceDb.Name = service.Name;
            serviceDb.Price = service.Price;
            serviceDb.Specifications = service.Specifications;
        }
    }
}
