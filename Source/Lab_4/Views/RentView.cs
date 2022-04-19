using Lab_4.DataBase;
using Lab_4.Models.Library;
using System;
using System.Windows.Forms;

namespace Lab_4.Views
{
    public partial class RentView : Form
    {
        public Rent Rent { get; private set; }
        public RentView(Rent rent)
        {
            InitializeComponent();

            Rent = rent;
            ShowRent();
        }

        private void ShowRent()
        {
            carTextBox.Text = Rent.Car.ToString();
            employeeTextBox.Text = Rent.Employee.ToString();
            clientTextBox.Text = Rent.Client.ToString();

            typeOfPaymentTextBox.Text = Rent.TypeOfPayment;
            startDatePicker.Value = Rent.StartDate;
            daysUpDown.Value = Rent.RentalPeriod;
            endDatePicker.Value = Rent.StartDate.AddDays(Rent.RentalPeriod);

            servicesDataGridView.DataSource = Rent.AdditionalService;

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

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var edit = new RentCreateEdit(Rent);
            if (edit.ShowDialog() == DialogResult.OK)
            {
                using (var context = new ApplicationDBContext())
                {
                    context.EditRent(edit.Rent);
                }
                Rent = edit.Rent;
                this.Close();
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            var isDelConfirmed = MessageBox.Show("Вы действительно хотите удалить объект?",
                "Подтверждающий диалог", MessageBoxButtons.OKCancel) == DialogResult.OK;
            if (isDelConfirmed)
            {
                using (var context = new ApplicationDBContext())
                {
                    context.DelRent(Rent);
                }
                this.Close();
            }
        }
    }
}
