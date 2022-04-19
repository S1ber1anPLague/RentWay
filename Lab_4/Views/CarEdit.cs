using Lab_4.DataBase;
using Lab_4.DataBase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Car = Lab_4.Models.Library.Car;

namespace Lab_4.Views
{
    public partial class CarCreateEdit : Form
    {
        public Car Car { get; private set; }
        // конструктор используемый при создании нового объекта
        public CarCreateEdit()
        {
            InitializeComponent();
            Text = "Создание новой машины ";
            // заполняем выпадающий список типов кузовов
            using (var context = new ApplicationDBContext())
            {
                // устанавливаем свойство для отображения
                bodyTypeComboBox.DisplayMember = "Type";
                bodyTypeComboBox.DataSource = context.BodyTypes.ToArray();
            }
            // заполняем выпадающий список марок автомобилей
            using (var context = new ApplicationDBContext())
            {
                // устанавливаем свойство для отображения
                carBrandsComboBox.DisplayMember = "Brand";
                carBrandsComboBox.DataSource = context.CarBrands.ToArray();
            }
        }
        // конструктор вызываемый при редактировании
        public CarCreateEdit(Car car):this() // вызываем второй конструктор для инициализации Ui
        {
            this.Car = car;
            ShowCar();
            this.Text = "Редактирование информации о машине";
        }

        // метод для отображения автомобиля
        private void ShowCar()
        {
            modelTextBox.Text = Car.Model;
            colorTextBox.Text = Car.Color;
            yearOfIssueTextBox.Text = Car.YearOfIssue.Year.ToString();
            engineVolumeTextBox.Text = Car.EngineVolume.ToString();
            driveTypeTextBox.Text = Car.DriveType;
            steeringWheelLocationTextBox.Text = Car.SteeringWheelLocation;

            depositAmountTextBox.Text = Car.DepositAmount.ToString();
            pricePerDayTextBox.Text = Car.PricePerDay.ToString();
            damageTextBox.Text = Car.Damage;
            licensePlateTextBox.Text = Car.LicensePlate;

            carBrandsComboBox.SelectedItem = 
                ((IEnumerable<CarBrand>)carBrandsComboBox.DataSource).First(cb => cb.Brand == Car.CarBrand);
            
            bodyTypeComboBox.SelectedItem =
                ((IEnumerable<BodyType>)bodyTypeComboBox.DataSource).First(bt => bt.Type == Car.BodyType);
        }

        // проверка на корректность ввода
        private bool IsValid()
        {
            return
                 !string.IsNullOrWhiteSpace(yearOfIssueTextBox.Text)
                 && !string.IsNullOrWhiteSpace(modelTextBox.Text)
                 && !string.IsNullOrWhiteSpace(colorTextBox.Text)
                 && !string.IsNullOrWhiteSpace(engineVolumeTextBox.Text)

                 && !string.IsNullOrWhiteSpace(driveTypeTextBox.Text)
                 && !string.IsNullOrWhiteSpace(steeringWheelLocationTextBox.Text)
                 && !string.IsNullOrWhiteSpace(depositAmountTextBox.Text)
                 && !string.IsNullOrWhiteSpace(pricePerDayTextBox.Text)

                 && !string.IsNullOrWhiteSpace(licensePlateTextBox.Text)

                 && double.TryParse(engineVolumeTextBox.Text, out double volume)
                 && volume > 20
                 && decimal.TryParse(depositAmountTextBox.Text, out decimal dA_)
                 && dA_ > 0
                 && decimal.TryParse(pricePerDayTextBox.Text, out decimal ppd)
                 && ppd > 0
                 && int.TryParse(yearOfIssueTextBox.Text, out int year)
                 && year > 1900 && year <= DateTime.Now.Year
                 ;
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // если данные заполнены корректно
            if (IsValid())
            {
                // извлекаем значения из контролов не беспокоясь об проверки - она была сделана раньше
                var carBrand = (carBrandsComboBox.SelectedItem as CarBrand).Brand;
                var bodyType = (bodyTypeComboBox.SelectedItem as BodyType).Type;

                Car = new Car(Car?.ID ?? 0,
                    carBrand,
                    modelTextBox.Text,
                    colorTextBox.Text,
                    new DateTime(int.Parse(yearOfIssueTextBox.Text), 1, 1),
                    double.Parse(engineVolumeTextBox.Text),
                    driveTypeTextBox.Text,
                    steeringWheelLocationTextBox.Text,
                    decimal.Parse(depositAmountTextBox.Text),
                    decimal.Parse(pricePerDayTextBox.Text),
                    damageTextBox.Text,
                    bodyType,
                    false,
                    licensePlateTextBox.Text
                    );
                this.Close();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Ошибка! Проверьте корректность вводимых данных");
            }
        }

        private void CarCreateEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
