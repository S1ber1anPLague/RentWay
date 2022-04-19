using Lab_4.DataBase;
using Lab_4.Models.Library;
using Lab_4.Models.Search;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Lab_4.Views
{
    public partial class RentCreateEdit : Form
    {
        private BindingList<ServiceInRentInfo> servicesInfoList;
        private BindingList<Service> servicesList;
        public Rent Rent { get; private set; }
        public RentCreateEdit()
        {
            InitializeComponent();
            Text = "Создание нового договора об аренде";
            closeRentButton.Visible = false;
        }

        public RentCreateEdit(Rent rent)
        {
            InitializeComponent();
            Rent = rent;
            Text = "Редактирование информации о договоре";
        }

        private void ShowRent()
        {
            carsComboBox.SelectedItem =
                ((IEnumerable<Car>)carsComboBox.DataSource).First(c => c.ID == Rent.Car.ID);

            employeesComboBox.SelectedItem =
                ((IEnumerable<Employee>)employeesComboBox.DataSource).First(e => e.ID == Rent.Employee.ID);

            clientsComboBox.SelectedItem =
                ((IEnumerable<Client>)clientsComboBox.DataSource).First(c => c.ID == Rent.Client.ID);

            typeOfPaymentTextBox.Text = Rent.TypeOfPayment;
            startDatePicker.Value = Rent.StartDate;
            daysUpDown.Value = Rent.RentalPeriod;
            endDatePicker.Value = Rent.StartDate.AddDays(Rent.RentalPeriod);
            depositAmountTextBox.Text = Rent.Car.DepositAmount.ToString();

            foreach (var sinfo in Rent.AdditionalService)
            {
                servicesInfoList.Add(sinfo);
                var service = servicesList.First(s => s.ID == sinfo.Service.ID);
                servicesList.Remove(service);
            }
        }

        public bool IsValid()
        {
            return
                !string.IsNullOrWhiteSpace(typeOfPaymentTextBox.Text)
             && carsComboBox.SelectedIndex != -1
             && employeesComboBox.SelectedIndex != -1
             && clientsComboBox.SelectedIndex != -1
             && decimal.TryParse(priceTextBox.Text, out decimal _);
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void RentCreateEdit_Load(object sender, EventArgs e)
        {
            servicesInfoList = new BindingList<ServiceInRentInfo>();
            using (var context = new ApplicationDBContext())
            {
                var search = Rent is null ? SearchCarParam.OnlyAvailable : SearchCarParam.Empty;
                carsComboBox.DataSource = context.GetCars(search).ToArray();
            }

            using (var context = new ApplicationDBContext())
            {
                clientsComboBox.DataSource = context.GetClients(SearchClientParam.Empty).ToArray();
            }

            using(var context = new ApplicationDBContext())
            {
                employeesComboBox.DataSource = context.GetEmployees(SearchEmployeeParam.Empty).ToArray();
            }

            using (var context = new ApplicationDBContext())
            {
                servicesList = new BindingList<Service>(
                    context.GetServices(SearchServiceParam.Empty).ToList()
                    );
            }

            endDatePicker.Value = startDatePicker.Value.AddDays((int)daysUpDown.Value);
            
            servicesComboBox.DataSource = servicesList;
            servicesDataGridView.DataSource = servicesInfoList;

            servicesDataGridView.Columns[nameof(ServiceInRentInfo.RentId)].Visible =
                false;

            servicesDataGridView.Columns[nameof(ServiceInRentInfo.ServiceInRentId)].Visible =
                false;

            servicesDataGridView.Columns[nameof(ServiceInRentInfo.Price)].HeaderText =
                Localizations.GetValueOrSelf(nameof(ServiceInRentInfo.Price));

            servicesDataGridView.Columns[nameof(ServiceInRentInfo.Quantity)].HeaderText =
                Localizations.GetValueOrSelf(nameof(ServiceInRentInfo.Quantity));

            servicesDataGridView.Columns[nameof(ServiceInRentInfo.Service)].HeaderText =
                Localizations.GetValueOrSelf(nameof(ServiceInRentInfo.Service));

            if (Rent != null)
            {
                ShowRent();
            }

            SetPrice();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                Rent = new Rent(
                    Rent?.ID ?? 0,
                    carsComboBox.SelectedItem as Car,
                    employeesComboBox.SelectedItem as Employee,
                    clientsComboBox.SelectedItem as Client,
                    startDatePicker.Value,
                    (int)daysUpDown.Value,
                    typeOfPaymentTextBox.Text,
                    decimal.Parse(priceTextBox.Text),
                    decimal.Parse(depositAmountTextBox.Text),
                    Rent?.IsOpen ?? true,
                    servicesInfoList.ToArray()
                    );

                this.Close();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Ошибка! Проверьте корректность вводимых данных");
            }
        }

        private void SetPrice()
        {
            if (!(carsComboBox.SelectedItem is Car selectedCar))
            {
                return;
            }

            depositAmountTextBox.Text = selectedCar.DepositAmount.ToString();
            var price = selectedCar.PricePerDay * daysUpDown.Value;
            foreach(var si in servicesInfoList)
            {
                price += si.Price;
            }

            priceTextBox.Text = price.ToString();
        }

        private void DaysUpDown_ValueChanged(object sender, EventArgs e)
        {
            SetPrice(); 
            
            endDatePicker.Value = startDatePicker.Value.AddDays((int)daysUpDown.Value);
        }

        private void CarsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetPrice();
        }

        private void CloseRentButton_Click(object sender, EventArgs e)
        {
            var reception = new ReceptionDialog(Rent);
            if (reception.ShowDialog() == DialogResult.OK)
            {
                using (var context = new ApplicationDBContext())
                {
                    context.CloseRent(reception.ReceptionInfo);
                    Rent = new Rent(
                    Rent?.ID ?? 0,
                    carsComboBox.SelectedItem as Car,
                    employeesComboBox.SelectedItem as Employee,
                    clientsComboBox.SelectedItem as Client,
                    startDatePicker.Value,
                    (int)daysUpDown.Value,
                    typeOfPaymentTextBox.Text,
                    decimal.Parse(priceTextBox.Text),
                    decimal.Parse(depositAmountTextBox.Text),
                    Rent?.IsOpen ?? false,
                    servicesInfoList.ToArray()
                    );
                }
            }
        }

        private void AddServiceButton_Click(object sender, EventArgs e)
        {
            if (!(servicesComboBox.SelectedItem is Service selectedService))
            {
                return;
            }

            var count = (int)quantityUpDown.Value;
            var serviceInfo = new ServiceInRentInfo(
                Rent?.ID ?? 0,
                0,
                selectedService,
                count * selectedService.Price,
                count
                );

            servicesInfoList.Add(serviceInfo);
            servicesList.Remove(selectedService);

            SetPrice();
        }

        private void RemoveServiceButton_Click(object sender, EventArgs e)
        {
            if (servicesDataGridView.SelectedRows.Count < 1)
            {
                return;
            }

            var info = servicesDataGridView.SelectedRows[0].DataBoundItem as ServiceInRentInfo;
            servicesInfoList.Remove(info);
            servicesList.Add(info.Service);
            SetPrice();
        }
    }
}
