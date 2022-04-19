using Lab_4.DataBase;
using Lab_4.Models.Library;
using Lab_4.Models.Search;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab_4.Views
{
    public partial class ClientView : Form
    {
        public Client Client { get; private set; }
        public ClientView(Client client)
        {
            InitializeComponent();
            Client = client;
            drivingLicenseTextBox.ReadOnly = true;
            phoneTextBox.ReadOnly = true;
            passportTextBox.ReadOnly = true;
            fioTextBox.ReadOnly = true;
            birthDatePicker.Enabled = false;

            ShowClient();
        }

        private void ShowClient()
        {
            fioTextBox.Text = Client.FIO;
            drivingLicenseTextBox.Text = Client.DrivingLicense;
            passportTextBox.Text = Client.Passport;
            birthDatePicker.Value = Client.DateOfBirth;
            phoneTextBox.Text = Client.PhoneNumber;
            dealsCountTextBox.Text = Client.DealsCount.ToString();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var edit = new ClientCreateEdit(Client);
            if (edit.ShowDialog() == DialogResult.OK)
            {
                using (var context = new ApplicationDBContext())
                {
                    context.EditClient(edit.Client);
                }
                Client = edit.Client;
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
                    context.DelClient(Client);
                }
                this.Close();
            }
        }

        private void RentList_Click(object sender, EventArgs e)
        {
            Reception[] receptions;
            using(var context = new ApplicationDBContext())
            {
                receptions =
                    context.GetReceptions(SearchReceptionParam.SearchByClientId(Client.ID))
                    .ToArray();
            }

            var history = new RentHistoryView(receptions);
            history.ShowDialog();
        }

        private void dealsCountTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
