using Lab_4.DataBase;
using Lab_4.Models.Library;
using Lab_4.Models.Search;
using Lab_4.Utils;
using System;
using System.Windows.Forms;

namespace Lab_4.Views
{
    public partial class Cars : Form
    {
        // текущие фильтры
        SearchCarParam search;
        public Cars()
        {
            InitializeComponent();
            // по умолчанию фильтров нет
            search = SearchCarParam.Empty;
            // обновляем интерфейс
            UpdateView();
        }

        private void UpdateView()
        {
            using (var context = new ApplicationDBContext())
            {
                // получаем список автомобилей
                carsDataGridView.DataSource = context.GetCars(search).ToSortableBindingList();
                // скрываем столбец с ID
                carsDataGridView.Columns[nameof(Client.ID)].Visible = false;
                // переводим заголовки на русский язык
                carsDataGridView.Columns[nameof(Car.BodyType)].HeaderText =
                    Localizations.GetValueOrSelf(nameof(Car.BodyType));
                carsDataGridView.Columns[nameof(Car.CarBrand)].HeaderText =
                    Localizations.GetValueOrSelf(nameof(Car.CarBrand));
                carsDataGridView.Columns[nameof(Car.Color)].HeaderText =
                   Localizations.GetValueOrSelf(nameof(Car.Color));
                carsDataGridView.Columns[nameof(Car.Damage)].HeaderText =
                  Localizations.GetValueOrSelf(nameof(Car.Damage));
                carsDataGridView.Columns[nameof(Car.DepositAmount)].HeaderText =
                    Localizations.GetValueOrSelf(nameof(Car.DepositAmount));
                carsDataGridView.Columns[nameof(Car.DriveType)].HeaderText =
                    Localizations.GetValueOrSelf(nameof(Car.DriveType));
                carsDataGridView.Columns[nameof(Car.EngineVolume)].HeaderText =
                    Localizations.GetValueOrSelf(nameof(Car.EngineVolume));
                carsDataGridView.Columns[nameof(Car.IsRented)].HeaderText =
                    Localizations.GetValueOrSelf(nameof(Car.IsRented));
                carsDataGridView.Columns[nameof(Car.LicensePlate)].HeaderText =
                    Localizations.GetValueOrSelf(nameof(Car.LicensePlate));
                carsDataGridView.Columns[nameof(Car.Model)].HeaderText =
                    Localizations.GetValueOrSelf(nameof(Car.Model));
                carsDataGridView.Columns[nameof(Car.PricePerDay)].HeaderText =
                    Localizations.GetValueOrSelf(nameof(Car.PricePerDay));
                carsDataGridView.Columns[nameof(Car.SteeringWheelLocation)].HeaderText =
                    Localizations.GetValueOrSelf(nameof(Car.SteeringWheelLocation));
                carsDataGridView.Columns[nameof(Car.YearOfIssue)].HeaderText =
                    Localizations.GetValueOrSelf(nameof(Car.YearOfIssue));
            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Обработчик события "Добавить новый автомобиль"
        private void NewCar_Click(object sender, EventArgs e)
        {
            // создаем форму
            var create = new CarCreateEdit();
            // вызываем открытие и проверяем статус завершения
            // если добавление подтверждено
            if (create.ShowDialog() == DialogResult.OK)
            {
                using (var context = new ApplicationDBContext())
                {
                    // добавляем информацию в БД
                    context.AddCar(create.Car);
                    // и обновляем интерфейс
                    UpdateView();
                }
            }
        }
        // обработчик кнопки "Управление выбранным"
        private void ManageCarButton_Click(object sender, EventArgs e)
        {
            // если нет выбранного элемента
            if (carsDataGridView.SelectedRows.Count < 1)
            {
                // прерываем выполнение
                return;
            }
            // извлекаем привязанный элемент
            var car = carsDataGridView.SelectedRows[0].DataBoundItem as Car;
            // создаем форму для отображения данных
            var carView = new CarView(car);
            // отображаем ее как диалоговое
            carView.ShowDialog();
            // обновляем отображение
            UpdateView();
        }
        // обработчик кнопки "Найти"
        private void SearchButton_Click(object sender, EventArgs e)
        {
            // если год От введен неверно
            if (!int.TryParse(startYearTextBox.Text, out int startYear))
            {
                // сбрасываем к минимальному допустимому значению
                startYear = int.MinValue;
            }
            // если год До введен неверно
            if (!int.TryParse(endYearTextBox.Text, out int endYear))
            {
                // сбрасываем к максимально допустимому значению
                endYear = int.MaxValue;
            }
            // флаг доступности
            bool? isAvailable;
            // если нажат
            if (isAvailableCheckBox.CheckState == CheckState.Checked)
            {
                isAvailable = true;
            }
            // если не нажат
            else if (isAvailableCheckBox.CheckState == CheckState.Unchecked)
            {
                isAvailable = false;
            }
            // если не определен
            else
            {
                isAvailable = null;
            }
            // создаем фильтры
            search = new SearchCarParam(
                brandTextBox.Text,
                startYear,
                endYear,
                colorTextBox.Text,
                driveTypeTextBox.Text,
                isAvailable
                );
            // обновляем интерфейс
            UpdateView();
        }
    }
}
