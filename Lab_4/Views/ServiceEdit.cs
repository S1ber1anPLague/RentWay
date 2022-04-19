using Lab_4.Models.Library;
using System;
using System.Windows.Forms;

namespace Lab_4.Views
{
    public partial class ServiceCreateEdit : Form
    {
        public Service Service { get; private set; }
        public ServiceCreateEdit()
        {
            InitializeComponent();
            Text = "Создание новой дополнительной услуги";
        }

        public ServiceCreateEdit(Service service)
        {
            InitializeComponent();
            this.Service = service;
            this.Text = "Редактирование информации о дополнительной услуге";
        }

        private void ShowService()
        {
            nameTextBox.Text = Service.Name;
            priceTextBox.Text = Service.Price.ToString();
            specificationTextBox.Text = Service.Specifications;
        }

        public bool IsValid()
        {
            return
              !string.IsNullOrWhiteSpace(nameTextBox.Text)
              && !string.IsNullOrWhiteSpace(specificationTextBox.Text)
              && decimal.TryParse(priceTextBox.Text, out decimal price)
              && price > 0;
        }


        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ServiceCreateEdit_Load(object sender, EventArgs e)
        {
            if (Service != null)
            {
                ShowService();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                Service = new Service(
                    Service?.ID ?? 0,
                    nameTextBox.Text,
                    specificationTextBox.Text,
                    decimal.Parse(priceTextBox.Text)
                    );

                this.Close();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Ошибка! Проверьте корректность вводимых данных");
            }
        }
    }
}
