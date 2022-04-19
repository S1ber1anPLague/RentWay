using Lab_4.DataBase;
using Lab_4.Models.Library;
using Lab_4.Models.Search;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab_4.Views
{
    public partial class CarView : Form
    {
        public Car Car  { get; private set; }
        public CarView(Car car)
        {
            InitializeComponent();
            Car = car;

            modelTextBox.ReadOnly = true;
            colorTextBox.ReadOnly = true;
            yearOfIssueTextBox.ReadOnly = true;
            engineVolumeTextBox.ReadOnly = true;
            driveTypeTextBox.ReadOnly = true;
            steeringWheelLocationTextBox.ReadOnly = true;

            depositAmountTextBox.ReadOnly = true;
            pricePerDayTextBox.ReadOnly = true;
            damageTextBox.ReadOnly = true;
            licensePlateTextBox.ReadOnly = true;

            carBrandsTextBox.ReadOnly = true;
            bodyTypeTextBox.ReadOnly = true;

            ShowCar();
        }

        // метод для отображения информации об автомобиле
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

            carBrandsTextBox.Text = Car.CarBrand;
            bodyTypeTextBox.Text = Car.BodyType;
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Cars cars = new Cars();
            cars.Show();
        }

        // обработчик кнопки "Изменить"
        private void EditButton_Click(object sender, EventArgs e)
        {
            var edit = new CarCreateEdit(Car);
            if (edit.ShowDialog() == DialogResult.OK)
            {
                using (var context = new ApplicationDBContext())
                {
                    context.EditCar(edit.Car);
                }
                Car = edit.Car;
                this.Close();
            }
        }

        // обработчик кнопки "Удалить"
        private void DelButton_Click(object sender, EventArgs e)
        {
            var isDelConfirmed = MessageBox.Show("Вы действительно хотите удалить объект?",
                "Подтверждающий диалог", MessageBoxButtons.OKCancel) == DialogResult.OK;
            // если действие подтверждено
            if (isDelConfirmed)
            {
                using (var context = new ApplicationDBContext())
                {
                    // делаем запрос к БД на удаление
                    context.DelCar(Car);
                }
                // закрываем окно
                this.Close();
            }
        }

        // обработчик кнопки "История аренд"
        private void RentHistoryButton_Click(object sender, EventArgs e)
        {
            Reception[] receptions;
            using (var context = new ApplicationDBContext())
            {
                // получаем список всех аренд для автомобиля
                receptions =
                    context.GetReceptions(SearchReceptionParam.SearchByCarId(Car.ID))
                    .ToArray();
            }

            var history = new RentHistoryView(receptions);
            history.ShowDialog();
        }
    }
}
