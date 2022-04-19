using Lab_4.DataBase;
using Lab_4.Models.Library;
using Lab_4.Models.Search;
using Lab_4.Utils;
using System;
using System.Windows.Forms;

namespace Lab_4.Views
{
    public partial class Services : Form
    {
        SearchServiceParam search;
        public Services()
        {
            InitializeComponent();
            search = SearchServiceParam.Empty;
            UpdateView();
        }

        private void UpdateView()
        {
            using (var context = new ApplicationDBContext())
            {
                servicesDataGridView.DataSource = context.GetServices(search).ToSortableBindingList(); ;
                
                servicesDataGridView.Columns[nameof(Service.ID)].Visible = false;
                servicesDataGridView.Columns[nameof(Service.Specifications)].Visible = false;

                servicesDataGridView.Columns[nameof(Service.Name)].HeaderText =
                    Localizations.GetValueOrSelf(nameof(Service.Name));

                servicesDataGridView.Columns[nameof(Service.Price)].HeaderText =
                    Localizations.GetValueOrSelf(nameof(Service.Price));
            }

        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewService_Click(object sender, EventArgs e)
        {
            var edit = new ServiceCreateEdit();
            if (edit.ShowDialog() == DialogResult.OK)
            {
                using (var context = new ApplicationDBContext())
                {
                    context.AddService(edit.Service);
                    UpdateView();
                }
            }
        }

        private void ManageSelectedButton_Click(object sender, EventArgs e)
        {
            if (servicesDataGridView.SelectedRows.Count < 1)
            {
                return;
            }

            var service = servicesDataGridView.SelectedRows[0].DataBoundItem as Service;
            var serviceView = new ServiceView(service);
            serviceView.ShowDialog();
            UpdateView();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            search = new SearchServiceParam(nameTextBox.Text);
            UpdateView();
        }
    }
}
