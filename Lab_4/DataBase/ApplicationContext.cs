using Lab_4.DataBase.Model;
using Lab_4.Models.Interfaces;
using Lab_4.Models.Search;
using Lab_4.Models.Statistics;
using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Lab_4.DataBase
{
    public partial class ApplicationDBContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // для того чтобы работал CodeFirst с SQLite
            var sqliteConnectionInitializer = new SqliteDropCreateDatabaseWhenModelChanges<ApplicationDBContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
            // запрещаем каскадное удаление чтобы не получить цикл
            modelBuilder.Entity<Rent>()
                .HasRequired(r => r.User)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rent>()
                .HasRequired(r => r.Client)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rent>()
                .HasRequired(r => r.Car)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CarBrand>()
                .HasIndex(c => c.Brand)
                .IsUnique();

            modelBuilder.Entity<BodyType>()
                .HasIndex(c => c.Type)
                .IsUnique();
        }

        // инициализация
        private void Init()
        {
            // если БД пользователей пустая
            if (Users.Count() == 0)
            {
                // заносим значения по умолчанию
                AddEmployee(DefaultData.Admin);
                AddEmployee(DefaultData.Director);
                AddEmployee(DefaultData.Manager);
            }
        }

        public ApplicationDBContext() : base("RentWayDbSQLite")
        {
            Init();
        }

        // данные из таблицы "Cars"
        public DbSet<Car> Cars { get; set; }
        // данные из таблицы "BodyTypes"
        public DbSet<BodyType> BodyTypes { get; set; }
        // данные из таблицы "CarBrands"
        public DbSet<CarBrand> CarBrands { get; set; }
        // данные из таблицы "Receptions"
        public DbSet<Reception> Receptions { get; set; }
        // данные из таблицы "Rents"
        public DbSet<Rent> Rents { get; set; }
        // данные из таблицы "Services"
        public DbSet<Service> Services { get; set; }
        // данные из таблицы "Users"
        public DbSet<User> Users { get; set; }
        // данные из таблицы "ServiceInRents"
        public DbSet<ServiceInRent> ServiceInRents { get; set; }
        // метод для поиска работника по логину и паролю
        public Models.Library.Employee FindEmployee(string login, string password)
        {
            // ищем первый элемент или null если такого нет
            var user = Users.FirstOrDefault(u =>
                u.Login == login && u.Pass == password);
            // если поиск не дал результатов
            if (user == null)
            {
                // возвращаем null
                return null;
            }
            // преобразуем к модельному классе
            return Mapper.FromUser(user);
        }

        // метод для преобразования данных из таблицы "User"
        // в модельный класса "Клиент"
        public Models.Library.Client GetClientFromUser(User user)
        {
            // подсчитываем количество аренд
            var dealsCount = Rents.Count(r => r.ClientID == user.UserID);
            // создаем объект копируя информацию
            return new Models.Library.Client(
                user.DrivingLicense, user.DateOfBirth.Value, user.UserID,
                user.FIO, user.PhoneNumber, user.Passport,
                dealsCount
                );
        }
        // метод для поиска клиентов по указанным фильтрам (параметрам поиска)
        public IEnumerable<Models.Library.Client> GetClients(SearchClientParam search)
        {
            // отбираем только клиентов
            var queryable = Users.Where(u => u.UserType == Models.Library.Role.Client);
            // проверяем заполненность фильтра
            if (!string.IsNullOrWhiteSpace(search.FIO))
            {
                // применяем его, проверяя вхождение строки поиска в значение поля
                queryable = queryable.Where(u => u.FIO.Contains(search.FIO));
            }
            // далее - аналогично
            if (!string.IsNullOrWhiteSpace(search.Passport))
            {
                queryable = queryable.Where(u => u.Passport.Contains(search.Passport));
            }

            if (!string.IsNullOrWhiteSpace(search.Phone))
            {
                queryable = queryable.Where(u => u.PhoneNumber.Contains(search.Phone));
            }

            if (!string.IsNullOrWhiteSpace(search.DrivingLicense))
            {
                queryable = queryable.Where(u => u.DrivingLicense.Contains(search.DrivingLicense));
            }

            var seq =
                 queryable
                    // получаем данные из БД преобразовывая в массив
                    .ToArray()
                    // преобразуем в модельные объекты
                    .Select(u => GetClientFromUser(u));
            // если есть фильтр по количество сделок
            if (search.DealsCount.HasValue)
            {
                // то применяем LINQ и фильтруем значения
                return seq.Where(c => c.DealsCount == search.DealsCount.Value);
            }

            return seq;
        }
        // метод для преобразования данных из таблицы Car
        // к модельному типу
        private Models.Library.Car GetModelCarFromDB(Car car)
        {
            return new Models.Library.Car(
                            car.CarID,
                            car.CarBrand.Brand,
                            car.Model,
                            car.Color,
                            car.YearOfIssue,
                            car.EngineVolume,
                            car.DriveType,
                            car.SteeringWheelLocation,
                            car.DepositAmount,
                            car.PricePerDay,
                            car.Damage,
                            car.BodyType.Type,
                            car.Status == CarStatus.Rented,
                            car.LicensePlate
                        );
        }

        // метод для поиска автомобилей, аналогичен методу поиска клиентов
        public IEnumerable<Models.Library.Car> GetCars(SearchCarParam search)
        {
            var queryable = Cars.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.Brand))
            {
                queryable = queryable.Where(c => c.CarBrand.Brand.Contains(search.Brand));
            }

            if (!string.IsNullOrWhiteSpace(search.Color))
            {
                queryable = queryable.Where(c => c.Color.Contains(search.Color));
            }

            if (!string.IsNullOrWhiteSpace(search.DriveType))
            {
                queryable = queryable.Where(c => c.DriveType.Contains(search.DriveType));
            }

            if (search.IsAvailable.HasValue)
            {
                queryable = queryable.Where(c =>
                    c.Status == (search.IsAvailable.Value ? CarStatus.Available : CarStatus.Rented));
            }

            queryable = queryable.Where(c => c.YearOfIssue.Year >= search.StartYear && c.YearOfIssue.Year <= search.EndYear);

            return
                queryable
                    .ToArray()
                    .Select(car => GetModelCarFromDB(car));
        }

        // метод для поиска работников, аналогичен методу поиска клиентов
        public IEnumerable<Models.Library.Employee> GetEmployees(SearchEmployeeParam search)
        {
            var queryable =
                Users.Where(u => u.UserType != Models.Library.Role.Client);

            if (!string.IsNullOrWhiteSpace(search.FIO))
            {
                queryable = queryable.Where(u => u.FIO.Contains(search.FIO));
            }

            if (!string.IsNullOrWhiteSpace(search.Passport))
            {
                queryable = queryable.Where(u => u.Passport.Contains(search.Passport));
            }

            if (!string.IsNullOrWhiteSpace(search.Phone))
            {
                queryable = queryable.Where(u => u.PhoneNumber.Contains(search.Phone));
            }

            if (!string.IsNullOrWhiteSpace(search.Login))
            {
                queryable = queryable.Where(u => u.Login.Contains(search.Login));
            }

            if (!string.IsNullOrWhiteSpace(search.Post))
            {
                queryable = queryable.Where(u => u.Post.Contains(search.Post));
            }

            return
                queryable
                .ToArray()
                    .Select(u => Mapper.GetEmployeeFromUser(u));
        }

        // метод для поиска услуг, аналогичен методу поиска клиентов
        public IEnumerable<Models.Library.Service> GetServices(SearchServiceParam search)
        {
            var queryable = Services.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.Name))
            {
                queryable = queryable.Where(s => s.Name.Contains(search.Name));
            }

            return queryable.ToArray().Select(s => Mapper.GetServiceFromDb(s));
        }

        // метод для поиска аренд, аналогичен методу поиска клиентов
        public IEnumerable<Models.Library.Rent> GetRents(SearchRentParam search)
        {
            var rents = Rents.ToArray();
            var queryable = Rents.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.CarBrand))
            {
                queryable = queryable.Where(r => r.Car.CarBrand.Brand.Contains(search.CarBrand));
            }

            if (!string.IsNullOrWhiteSpace(search.ClientFIO))
            {
                queryable = queryable.Where(r => r.Client.FIO.Contains(search.ClientFIO));
            }

            queryable = queryable.Where(r => r.StartDate >= search.Start && r.StartDate <= search.End);

            if (!string.IsNullOrWhiteSpace(search.EmployeeFIO))
            {
                queryable = queryable.Where(r => r.User.FIO.Contains(search.EmployeeFIO));
            }

            if (search.Number.HasValue)
            {
                queryable = queryable.Where(r => r.RentID == search.Number.Value);
            }

            if (search.Period.HasValue)
            {
                queryable = queryable.Where(r => r.RentalPeriod == search.Period);
            }

            if (search.IsOpen.HasValue)
            {
                queryable = queryable.Where(r => r.IsOpen == search.IsOpen);
            }

            return queryable.ToArray().Select(r => GetRentFromDB(r));
        }

        // метод для поиска возвратов, аналогичен методу поиска клиентов
        public IEnumerable<Models.Library.Reception> GetReceptions(SearchReceptionParam search)
        {
            var queryable = Receptions.AsQueryable();

            if (search.CarId.HasValue)
            {
                queryable = queryable.Where(r => r.Rent.CarID == search.CarId.Value);
            }

            if (search.ClientId.HasValue)
            {
                queryable = queryable.Where(r => r.Rent.ClientID == search.ClientId.Value);
            }

            if (search.EmployeeId.HasValue)
            {
                queryable = queryable.Where(r => r.Rent.UserID == search.EmployeeId.Value);
            }

            return queryable.AsEnumerable().Select(r => new Models.Library.Reception(
                r.ReceptionID, r.DateOfReceipt, r.EmployeeConclusion,
                    GetRentFromDB(r.Rent)
                ));
        }

        public bool ContainsBrand(string brand) =>
            CarBrands.Any(c => c.Brand == brand);
    }

    public partial class ApplicationDBContext : IEmployee
    {
        // метод для добавления сотрудника
        public int AddEmployee(Models.Library.Employee employee)
        {
            // преобразуем из модельного объекта
            // и добавляем в таблицу
            Users.Add(Mapper.CreateUserFromEmployee(employee));
            // сохраняем изменения
            return this.SaveChanges();
        }

        public bool DelEmployee(Models.Library.Employee employee)
        {
            // ищем объект в БД по ID
            var user = Users.Find(employee.ID);
            // удаляем его
            Users.Remove(user);
            // сохраняем изменения
            return this.SaveChanges() > 0;
        }

        public bool EditEmployee(Models.Library.Employee employee)
        {
            // ищет объект в БД по ID
            var user = Users.Find(employee.ID);
            // вызываем метод обновления объекта-БД по модельному
            user.UpdateUser(employee);
            // сохраняем изменения
            return this.SaveChanges() > 0;
        }
    }

    public partial class ApplicationDBContext : IClient
    {
        // метод для добавления клиента, аналогичен методу добавления сотрудника
        public int AddClient(Models.Library.Client client)
        {
            Users.Add(Mapper.CreateUserFromClient(client));

            return this.SaveChanges();
        }
        // метод для удаления клиента, аналогичен методу удаления сотрудника
        public bool DelClient(Models.Library.Client client)
        {
            var user = Users.Find(client.ID);
            Users.Remove(user);

            return this.SaveChanges() > 0;
        }
        // метод для редактирования информации о клиенте, аналогичен методу добавления сотрудника
        public bool EditClient(Models.Library.Client client)
        {
            var user = Users.Find(client.ID);
            user.UpdateUser(client);

            return this.SaveChanges() > 0;
        }
    }

    public partial class ApplicationDBContext : ICar
    {
        private Car GetCarFromModelCar(Models.Library.Car car)
        {
            // ищем Id для записи в БД для типа кузова
            var bodyTypeId = BodyTypes.First(bt => bt.Type == car.BodyType).BodyTypeID;
            // ищем Id для записи в БД для марки
            var carBrandId = CarBrands.First(cb => cb.Brand == car.CarBrand).CarBrandID;
            // создаем объект-БД
            return new Car
            {
                Damage = car.Damage,
                DateAdded = DateTime.Now,
                DepositAmount = car.DepositAmount,
                Color = car.Color,
                DriveType = car.DriveType,
                PricePerDay = car.PricePerDay,
                SteeringWheelLocation = car.SteeringWheelLocation,
                EngineVolume = car.EngineVolume,
                Model = car.Model,
                YearOfIssue = car.YearOfIssue,
                Status = CarStatus.Available,
                LicensePlate = car.LicensePlate,
                BodyTypeID = bodyTypeId,
                CarBrandID = carBrandId
            };
        }

        private void UpdateCarByModelCar(Car carDB, Models.Library.Car car)
        {
            var bodyTypeId = BodyTypes.First(bt => bt.Type == car.BodyType).BodyTypeID;
            var carBrandId = CarBrands.First(cb => cb.Brand == car.CarBrand).CarBrandID;

            carDB.Damage = car.Damage;
            carDB.DateAdded = DateTime.Now;
            carDB.DepositAmount = car.DepositAmount;
            carDB.Color = car.Color;
            carDB.DriveType = car.DriveType;
            carDB.PricePerDay = car.PricePerDay;
            carDB.SteeringWheelLocation = car.SteeringWheelLocation;
            carDB.EngineVolume = car.EngineVolume;
            carDB.Model = car.Model;
            carDB.YearOfIssue = car.YearOfIssue;
            carDB.Status = car.IsRented ? CarStatus.Rented : CarStatus.Available;
            carDB.LicensePlate = car.LicensePlate;
            carDB.BodyTypeID = bodyTypeId;
            carDB.CarBrandID = carBrandId;
        }
        // метод для изменения статуса автомобия на доступный к аренде
        private void MakeCarAvailableInternal(int carId)
        {
            var car = Cars.Find(carId);
            car.Status = CarStatus.Available;
        }

        // метод для добавления автомобиля, аналогичен методу добавления сотрудника
        public int AddCar(Models.Library.Car car)
        {
            var carDb = GetCarFromModelCar(car);
            Cars.Add(carDb);

            return this.SaveChanges();
        }
        // метод для удаления автомобиля, аналогичен методу удаления сотрудника
        public bool DelCar(Models.Library.Car car)
        {
            var carDb = Cars.Find(car.ID);
            Cars.Remove(carDb);

            return this.SaveChanges() > 0;
        }
        // метод для редактирования автомобиля, аналогичен методу удаления сотрудника
        public bool EditCar(Models.Library.Car car)
        {
            var carDb = Cars.Find(car.ID);
            UpdateCarByModelCar(carDb, car);

            return this.SaveChanges() > 0;
        }
    }

    public partial class ApplicationDBContext : IService
    {
        // метод для добавления услуг, аналогичен методу добавления сотрудника
        public int AddService(Models.Library.Service service)
        {
            Services.Add(Mapper.CreateServiceFromModel(service));
            return this.SaveChanges();
        }
        // метод для удаления услуг, аналогичен методу удаления сотрудника
        public bool DelService(Models.Library.Service service)
        {
            var serviceDb = Services.Find(service.ID);
            Services.Remove(serviceDb);
            return this.SaveChanges() > 0;
        }
        // метод для редактирования услуг, аналогичен методу удаления сотрудника
        public bool EditService(Models.Library.Service service)
        {
            var serviceDb = Services.Find(service.ID);
            serviceDb.UpdateServiceDbWithModel(service);

            return this.SaveChanges() > 0;
        }
    }

    public partial class ApplicationDBContext : IRent
    {
        // метод для преобразования модельного оьъекта аренды
        // к объекту - БД
        private Rent GetRentFromModelRent(Models.Library.Rent rent)
        {
            return new Rent
            {
                DepositAmount = rent.DepositAmount,
                StartDate = rent.StartDate,
                Price = rent.Price,
                RentalPeriod = rent.RentalPeriod,
                TypeOfPayment = rent.TypeOfPayment,
                DateAdded = DateTime.Now,
                ReturnDate = rent.StartDate.AddDays(rent.RentalPeriod),
                CarID = rent.Car.ID,
                UserID = rent.Employee.ID,
                ClientID = rent.Client.ID,
                IsOpen = rent.IsOpen
            };
        }

        // метод для получения из объекта-БД
        // модельного объекта аренды
        private Models.Library.Rent GetRentFromDB(Rent rent)
        {
            // получаем список заказанных доп. услуг
            var services =
                ServiceInRents
                    .Where(sr => sr.RentId == rent.RentID)
                    .AsEnumerable()
                    .Select(sr => new Models.Library.ServiceInRentInfo(
                        sr.RentId,
                        sr.ServiceInRentID,
                        Mapper.GetServiceFromDb(sr.Service),
                        sr.Price,
                        sr.Quantity))
                    .ToArray();
            return new Models.Library.Rent(
                rent.RentID,
                GetModelCarFromDB(rent.Car),
                Mapper.FromUser(rent.User),
                GetClientFromUser(rent.Client),
                rent.StartDate,
                rent.RentalPeriod,
                rent.TypeOfPayment,
                rent.Price,
                rent.DepositAmount,
                rent.IsOpen,
                services
                );
        }

        // метод для добавления аренды
        public int AddRent(Models.Library.Rent rent)
        {
            using (var dbContextTransaction = Database.BeginTransaction())
            {
                // ищем автомобиль
                var dbCar = Cars.Find(rent.Car.ID);
                // меняем его статус
                dbCar.Status = CarStatus.Rented;
                // получаем объект аренды из модельного
                var rentDb = GetRentFromModelRent(rent);
                // добавляем его
                rentDb = Rents.Add(rentDb);
                // сохраняем изменения
                var b = this.SaveChanges() > 0;
                // перебираем заказанные доп. услуги
                foreach (var service in rent.AdditionalService)
                {
                    var withId = new Models.Library.ServiceInRentInfo(
                        rentDb.RentID,
                        service.ServiceInRentId,
                        service.Service,
                        service.Price,
                        service.Quantity
                        );
                    // записываем в БД
                    b &= AddService(withId);
                }
                // если все записи прошли удачно
                if (b)
                {
                    // фиксируем измения
                    dbContextTransaction.Commit();
                }
                else // иначе
                {
                    // откатываем изменения
                    dbContextTransaction.Rollback();
                }
                return 1;
            }
        }
        // метод для удаления аренд, аналогичен методу удаления сотрудника
        public bool DelRent(Models.Library.Rent rent)
        {
            var rentDb = Rents.Find(rent.ID);
            Rents.Remove(rentDb);

            return this.SaveChanges() > 0;
        }
        // методя для редактирования аренд
        public bool EditRent(Models.Library.Rent rent)
        {
            using (var dbContextTransaction = Database.BeginTransaction())
            {
                // достаем объект-БД
                var rentDB = Rents.Find(rent.ID);
                // если изменилась информация об автомобиле
                if (rent.Car.ID != rentDB.CarID)
                {
                    // старый автомобиль возвращаем
                    MakeCarAvailableInternal(rentDB.CarID);
                    // ищем новый
                    var dbCar = Cars.Find(rent.Car.ID);
                    // меняем статус уже у него
                    dbCar.Status = CarStatus.Rented;
                }
                rentDB.StartDate = rent.StartDate;
                rentDB.Price = rent.Price;
                rentDB.RentalPeriod = rent.RentalPeriod;
                rentDB.TypeOfPayment = rent.TypeOfPayment;
                rentDB.ReturnDate = rent.StartDate.AddDays(rent.RentalPeriod);
                rentDB.CarID = rent.Car.ID;
                rentDB.UserID = rent.Employee.ID;
                rentDB.ClientID = rent.Client.ID;
                rentDB.IsOpen = rent.IsOpen;
                // отбрасываем значение так как поля могли остаться без изменений
                this.SaveChanges();
                bool b = true;
                // массив старых услуг
                var servicesInRent = ServiceInRents.Where(sr => sr.RentId == rentDB.RentID).ToArray();
                foreach (var s in servicesInRent)
                {
                    // проверяем их наличие в обновленном объекте
                    var newV = rent.AdditionalService.FirstOrDefault(sr => sr.ServiceInRentId == s.ServiceInRentID);
                    if (newV == null)
                    {
                        // удаляем из таблицы если не нашли
                        b &= DelService(new Models.Library.ServiceInRentInfo(s.RentId, s.ServiceInRentID,
                            null, s.Price, s.Quantity));
                    }
                    // если нашли то количество отличается то обновляем
                    else if (newV.Quantity != s.Quantity)
                    {
                        var dbSR = ServiceInRents.Find(s.ServiceInRentID);
                        dbSR.Quantity = newV.Quantity;
                        dbSR.Price = newV.Price;
                        b &= this.SaveChanges() > 0;
                    }
                }

                // список новых услуг
                var newServices =
                    rent.AdditionalService
                        .Where(s => !servicesInRent.Any(ss =>
                            ss.ServiceInRentID == s.ServiceInRentId)
                        );

                // добавляем в таблицу
                foreach (var service in newServices)
                {
                    var withId = new Models.Library.ServiceInRentInfo(
                        rentDB.RentID,
                        service.ServiceInRentId,
                        service.Service,
                        service.Price,
                        service.Quantity
                        );
                    b &= AddService(withId);
                }
                if (b)
                {
                    dbContextTransaction.Commit();
                }
                else
                {
                    dbContextTransaction.Rollback();
                }
                
                
                return b;
            }
             
        }
        // метод для закрытия аренды
        public bool CloseRent(Models.Library.ReceptionInfo info)
        {
            var reception = new Reception
            {
                DateOfReceipt = DateTime.Now,
                RentID = info.RentID,
                EmployeeConclusion = info.EmployeeConclusion,
            };
            // ищем автомобиль в БД
            var car = Cars.Find(info.CarID);
            // меняем статус
            car.Status = CarStatus.Available;
            // копируем информацию о состоянии
            car.Damage = info.Damage;
            // добавляем информацию о возвращении
            Receptions.Add(reception);
            var rent = Rents.Find(info.RentID);
            rent.IsOpen = false;
            return this.SaveChanges() > 0;
        }
        // метод для добавления аренд доп. услуг, аналогичен методу добавления сотрудника
        public bool AddService(Models.Library.ServiceInRentInfo info)
        {
            ServiceInRents.Add(new ServiceInRent
            {
                Price = info.Price,
                Quantity = info.Quantity,
                RentId = info.RentId,
                ServiceId = info.Service.ID
            });
            return this.SaveChanges() > 0;
        }
        // метод для удаления аренд доп. услуг, аналогичен методу удаления сотрудника
        public bool DelService(Models.Library.ServiceInRentInfo info)
        {
            var sr = ServiceInRents.Find(info.ServiceInRentId);
            ServiceInRents.Remove(sr);

            return this.SaveChanges() > 0;
        }
    }

    public partial class ApplicationDBContext : IStat
    {
        // расчет статистики по машинам
        public CarsStatInfo GetCarsStatInfo()
        {
            var rentedCarCount = 
                Rents
                    .Select(r => r.CarID) // выбираем ID
                    .Distinct() // удаляем повторения
                    .Count(); // считаем количество

            var info =
                Rents.GroupBy(r => r.CarID) // группируем по ID
                .Where(gr => gr.Count() > 0) // отбрасываем машины без аренд
                .AsEnumerable()
                // записываем информацию о машине и сколько раз она была арендована
                .Select(gr => new Info(GetModelCarFromDB(gr.First().Car).ToString(), gr.Count()))
                .ToArray();

            return new CarsStatInfo(rentedCarCount, info);
        }
        // расчет статистики по клиентам, аналогичен статиске по автомобилям
        public ClientsStatInfo GetClientsStatInfo()
        {

            var clientsCount = Rents.Select(r => r.ClientID).Distinct().Count();

            var info =
                Rents.GroupBy(r => r.ClientID)
                .Where(gr => gr.Count() > 0)
                .AsEnumerable()
                .Select(gr => new Info(GetClientFromUser(gr.First().Client).ToString(), gr.Count()))
                .ToArray();

            return new ClientsStatInfo(clientsCount, info);
        }

        public TotalStatInfo GetTotalStatInfo()
        {
            var rentsCount = Rents.Count();
            var clientsCount = 
                // подсчиываем количество клиентов
                Users.Count(u => u.UserType == Models.Library.Role.Client);
            var carsCount = Cars.Count();

            return new TotalStatInfo(rentsCount, clientsCount, carsCount);
        }
    }
}
