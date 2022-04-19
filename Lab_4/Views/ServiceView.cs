using Lab_4.DataBase;
using Lab_4.Models.Library;
using System;
using System.Windows.Forms;

namespace Lab_4.Views
{
    public partial class ServiceView : Form
    {
        public Service Service { get; private set; }
        public ServiceView(Service service)
        {
            InitializeComponent();
            Service = service;
            ShowService();
        }

        private void ShowService()
        {
            nameTextBox.Text = Service.Name;
            priceTextBox.Text = Service.Price.ToString();
            specificationTextBox.Text = Service.Specifications;
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Services services = new Services();
            services.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var edit = new ServiceCreateEdit(Service);
            if (edit.ShowDialog() == DialogResult.OK)
            {
                using (var context = new ApplicationDBContext())
                {
                    context.EditService(edit.Service);
                }
                Service = edit.Service;
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
                    context.DelService(Service);
                }
                this.Close();
            }
        }

    }
}
