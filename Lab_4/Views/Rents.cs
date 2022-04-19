using Lab_4.DataBase;
using Lab_4.Models.Library;
using Lab_4.Models.Search;
using Lab_4.Utils;
using System;
using System.Windows.Forms;

namespace Lab_4.Views
{
    public partial class Rents : Form
    {
        SearchRentParam search;
        public Rents()
        {
            InitializeComponent();
            search = SearchRentParam.Empty;
            UpdateView();
        }

        private void UpdateView()
        {
            using(var context = new ApplicationDBContext())
            {
                rentsDataGridView.DataSource = context.GetRents(search).ToSortableBindingList();

                rentsDataGridView.Columns[nameof(Rent.ID)].Visible = false;
                var column1 = rentsDataGridView.Columns[nameof(Rent.AdditionalService)];
                if (column1 != null)
                {
                    column1.Visible = false;
                }

                rentsDataGridView.Columns[nameof(Rent.Car)].HeaderText =
                    Localizations.GetValueOrSelf(nameof(Rent.Car));

                rentsDataGridView.Columns[nameof(Rent.Client)].HeaderText =
                    Localizations.GetValueOrSelf(nameof(Rent.Client));

                rentsDataGridView.Columns[nameof(Rent.Employee)].HeaderText =
                    Localizations.GetValueOrSelf(nameof(Rent.Employee));

                rentsDataGridView.Columns[nameof(Rent.Price)].HeaderText =
                    Localizations.GetValueOrSelf(nameof(Rent.Price));

                rentsDataGridView.Columns[nameof(Rent.RentalPeriod)].HeaderText =
                    Localizations.GetValueOrSelf(nameof(Rent.RentalPeriod));

                rentsDataGridView.Columns[nameof(Rent.StartDate)].HeaderText =
                    Localizations.GetValueOrSelf(nameof(Rent.StartDate));

                rentsDataGridView.Columns[nameof(Rent.TypeOfPayment)].HeaderText =
                    Localizations.GetValueOrSelf(nameof(Rent.TypeOfPayment));

                rentsDataGridView.Columns[nameof(Rent.DepositAmount)].HeaderText =
                    Localizations.GetValueOrSelf(nameof(Rent.DepositAmount));

                rentsDataGridView.Columns[nameof(Rent.IsOpen)].HeaderText =
                    Localizations.GetValueOrSelf(nameof(Rent.IsOpen));
            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewRent_Click(object sender, EventArgs e)
        {

        }

        private void ManageSelectedButton_Click(object sender, EventArgs e)
        {
            if (rentsDataGridView.SelectedRows.Count < 1)
            {
                return;
            }

            var rent = rentsDataGridView.SelectedRows[0].DataBoundItem as Rent;
            var rentView = new RentView(rent);
            rentView.ShowDialog();
            UpdateView();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(startDateTextBox.Text, out DateTime startDate))
            {
                startDate = DateTime.MinValue;
            }

            if (!DateTime.TryParse(endDateTextBox.Text, out DateTime endDate))
            {
                endDate = DateTime.MaxValue;
            }

            // флаг доступности
            bool? isOpen;
            // если нажат
            if (isOpenCheckBox.CheckState == CheckState.Checked)
            {
                isOpen = true;
            }
            // если не нажат
            else if (isOpenCheckBox.CheckState == CheckState.Unchecked)
            {
                isOpen = false;
            }
            // если не определен
            else
            {
                isOpen = null;
            }

            search = new SearchRentParam(
                    int.TryParse(numberTextBox.Text, out int number) ? new int?(number) : null,
                    startDate,
                    endDate,
                    int.TryParse(periodTextBox.Text, out int period) ? new int?(period) : null,
                    brandTextBox.Text,
                    clientTextBox.Text,
                    employeeTextBox.Text,
                    isOpen
                );

            UpdateView();
        }

        private void Rents_Load(object sender, EventArgs e)
        {

        }
    }
}
