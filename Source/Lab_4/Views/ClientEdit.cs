using Lab_4.Models.Library;
using Lab_4.Utils;
using System;
using System.Windows.Forms;

namespace Lab_4.Views
{
    public partial class ClientCreateEdit : Form
    {
        public Client Client { get; private set; }

        public ClientCreateEdit()
        {
            InitializeComponent();
            Text = "Создание нового клиента";
        }

        public ClientCreateEdit(Client client)
        {
            InitializeComponent();
            this.Client = client;
            ShowClient();
            this.Text = "Редактирование информации о клиенте";
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

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsValid()
        {
            return
                 !string.IsNullOrWhiteSpace(fioTextBox.Text)
                 && !string.IsNullOrWhiteSpace(drivingLicenseTextBox.Text)
                 && !string.IsNullOrWhiteSpace(passportTextBox.Text)
                 && !string.IsNullOrWhiteSpace(phoneTextBox.Text)
                 // проверяем что исполнилось 18 лет
                 && birthDatePicker.Value <= DateTime.Now.AddYears(-18)
                 // проверяем паспорт
                 && SimpleValidators.Passport(passportTextBox.Text)
                 // проверяем телефон
                 && SimpleValidators.Phone(phoneTextBox.Text);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                Client = new Client(
                    drivingLicenseTextBox.Text,
                    birthDatePicker.Value,
                    Client?.ID ?? 0,
                    fioTextBox.Text,
                    phoneTextBox.Text,
                    passportTextBox.Text,
                    Client?.DealsCount ?? 0
                    );
                this.Close();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Ошибка! Проверьте корректность вводимых данных");
            }
        }

        private void ClientCreateEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
