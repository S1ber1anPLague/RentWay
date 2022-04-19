using Lab_4.DataBase;
using Lab_4.Views.Statistics;
using System;
using System.Windows.Forms;

namespace Lab_4.Views
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            var isAdminOrDirector = 
                ApplicationData.Person.Role == Models.Library.Role.Admin ||
                ApplicationData.Person.Role == Models.Library.Role.Director;

            EmployeeList.Visible = isAdminOrDirector;
            summariesBtn.Visible = isAdminOrDirector;
        }

        private void RentOrdering_Click(object sender, EventArgs e)
        {
            var createRent = new RentCreateEdit();
            if (createRent.ShowDialog() == DialogResult.OK)
            {
                using (var context = new ApplicationDBContext())
                {
                    context.AddRent(createRent.Rent);
                }
            }
        }

        private void CarList_Click(object sender, EventArgs e)
        {
            Cars car = new Cars();
            car.Show();
        }

        private void ClientList_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.Show();
        }

        private void ServiceList_Click(object sender, EventArgs e)
        {
            Services services = new Services();
            services.Show();
        }

        private void EmployeeList_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.Show();
        }

        private void RentList_Click(object sender, EventArgs e)
        {
            Rents allrents = new Rents();
            allrents.Show();
        }

        private void CarBrandsButton_Click(object sender, EventArgs e)
        {
            var carBrands = new CarBrands();
            carBrands.Show();
        }

        private void CarBodyTypesButton_Click(object sender, EventArgs e)
        {
            var carBodyTypes = new CarBodyTypes();
            carBodyTypes.Show();
        }

        private void SummariesBtn_Click(object sender, EventArgs e)
        {
            var statView = new SummaryMenuView();
            statView.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
