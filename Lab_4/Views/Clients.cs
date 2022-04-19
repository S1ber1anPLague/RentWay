using Lab_4.DataBase;
using Lab_4.Models.Library;
using Lab_4.Models.Search;
using Lab_4.Utils;
using System;
using System.Windows.Forms;

namespace Lab_4.Views
{
    public partial class Clients : Form
    {
        private SearchClientParam search;
        public Clients()
        {
            InitializeComponent();
            search = SearchClientParam.Empty;
            UpdateView();
        }

        private void UpdateView()
        {
            using (var context = new ApplicationDBContext())
            {
                clientsDataGridView.DataSource = context.GetClients(search).ToSortableBindingList();
                
                clientsDataGridView.Columns[nameof(Client.ID)].Visible = false;
                clientsDataGridView.Columns[nameof(Client.Role)].Visible = false;


                clientsDataGridView.Columns[nameof(Client.DateOfBirth)].HeaderText =
                    Localizations.GetValueOrSelf(nameof(Client.DateOfBirth));
                clientsDataGridView.Columns[nameof(Client.DrivingLicense)].HeaderText =
                    Localizations.GetValueOrSelf(nameof(Client.DrivingLicense));
                clientsDataGridView.Columns[nameof(Client.FIO)].HeaderText =
                   Localizations.GetValueOrSelf(nameof(Client.FIO));
                clientsDataGridView.Columns[nameof(Client.Passport)].HeaderText =
                  Localizations.GetValueOrSelf(nameof(Client.Passport));
                clientsDataGridView.Columns[nameof(Client.PhoneNumber)].HeaderText =
                  Localizations.GetValueOrSelf(nameof(Client.PhoneNumber));
                clientsDataGridView.Columns[nameof(Client.DealsCount)].HeaderText =
                  Localizations.GetValueOrSelf(nameof(Client.DealsCount));
            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {          
            this.Close();
        }

        private void NewClient_Click(object sender, EventArgs e)
        {
            var edit = new ClientCreateEdit();
            if (edit.ShowDialog() == DialogResult.OK)
            {
                using (var context = new ApplicationDBContext())
                {
                    context.AddClient(edit.Client);
                    UpdateView();
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            search = new SearchClientParam(
                passportTextBox.Text,
                drivingLicenseTextBox.Text,
                fioTextBox.Text,
                phoneTextBox.Text,
                int.TryParse(dealsCountTextBox.Text, out int count) ? new int?(count) : null
                );

            UpdateView();
        }

        private void ManageClientButton_Click(object sender, EventArgs e)
        {
            if (clientsDataGridView.SelectedRows.Count < 1)
            {
                return;
            }

            var client = clientsDataGridView.SelectedRows[0].DataBoundItem as Client;
            var clientView = new ClientView(client);
            clientView.ShowDialog();
            UpdateView();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void clientsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
