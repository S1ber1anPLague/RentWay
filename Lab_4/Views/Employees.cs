using Lab_4.DataBase;
using Lab_4.Models.Library;
using Lab_4.Models.Search;
using Lab_4.Utils;
using System;
using System.Windows.Forms;

namespace Lab_4.Views
{
    public partial class Employees : Form
    {
        SearchEmployeeParam search;
        public Employees()
        {
            InitializeComponent();
            search = SearchEmployeeParam.Empty;
            UpdateView();
        }

        private void UpdateView()
        {
            using (var context = new ApplicationDBContext())
            {
                employeesDataGridView.DataSource = context.GetEmployees(search).ToSortableBindingList(); ;

                employeesDataGridView.Columns[nameof(Employee.ID)].Visible = false;
                employeesDataGridView.Columns[nameof(Employee.Role)].HeaderText =
                    Localizations.GetValueOrSelf(nameof(Employee.Role));


                employeesDataGridView.Columns[nameof(Employee.FIO)].HeaderText =
                    Localizations.GetValueOrSelf(nameof(Employee.FIO));
                employeesDataGridView.Columns[nameof(Employee.ITN)].HeaderText =
                    Localizations.GetValueOrSelf(nameof(Employee.ITN));
                employeesDataGridView.Columns[nameof(Employee.Login)].HeaderText =
                    Localizations.GetValueOrSelf(nameof(Employee.Login));
                employeesDataGridView.Columns[nameof(Employee.Passport)].HeaderText =
                   Localizations.GetValueOrSelf(nameof(Employee.Passport));
                employeesDataGridView.Columns[nameof(Employee.PhoneNumber)].HeaderText =
                  Localizations.GetValueOrSelf(nameof(Employee.PhoneNumber));
                employeesDataGridView.Columns[nameof(Employee.Post)].HeaderText =
                  Localizations.GetValueOrSelf(nameof(Employee.Post));

            }
        }

        private void NewEmployee_Click(object sender, EventArgs e)
        {
            var edit = new EmployeeCreateEdit();
            if (edit.ShowDialog() == DialogResult.OK)
            {
                using (var context = new ApplicationDBContext())
                {
                    context.AddEmployee(edit.Employee);
                    UpdateView();
                }
            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageSelectedButton_Click(object sender, EventArgs e)
        {
            if (employeesDataGridView.SelectedRows.Count < 1)
            {
                return;
            }

            var employee = employeesDataGridView.SelectedRows[0].DataBoundItem as Employee;
            var employeeView = new EmployeeView(employee);
            employeeView.ShowDialog();
            UpdateView();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            search = new SearchEmployeeParam(
                loginTextBox.Text,
                postTextBox.Text,
                passportTextBox.Text,
                fioTextBox.Text,
                phoneTextBox.Text
                );
            UpdateView();
        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }
    }
}
