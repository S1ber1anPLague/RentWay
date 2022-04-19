using Lab_4.DataBase;
using Lab_4.Models.Library;
using Lab_4.Models.Search;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab_4.Views
{
    public partial class EmployeeView : Form
    {
        public Employee Employee { get; private set; }
        public EmployeeView(Employee employee)
        {
            InitializeComponent();
            Employee = employee;

            fioTextBox.ReadOnly = true;
            passportTextBox.ReadOnly = true;
            phoneTextBox.ReadOnly = true;
            postTextBox.ReadOnly = true;
            passwordTextBox.ReadOnly = true;
            loginTextBox.ReadOnly = true;
            itnTextBox.ReadOnly = true;

            roleTextBox.ReadOnly = true;

            if (ApplicationData.Person.Role == Role.Manager || ApplicationData.Person.Role == Role.Client)
            {
                rentHistoryButton.Visible = false;
            }

            ShowEmployee();
        }

        private void ShowEmployee()
        {
            fioTextBox.Text = Employee.FIO;
            passportTextBox.Text = Employee.Passport;
            phoneTextBox.Text = Employee.PhoneNumber;
            postTextBox.Text = Employee.Post;
            passwordTextBox.Text = Employee.Pass;
            loginTextBox.Text = Employee.Login;
            itnTextBox.Text = Employee.ITN;

            roleTextBox.Text = Localizations.GetValueOrSelf(Employee.Role.ToString());
        }


        private void DelButton_Click(object sender, EventArgs e)
        {
            var isDelConfirmed = MessageBox.Show("Вы действительно хотите удалить объект?",
                 "Подтверждающий диалог", MessageBoxButtons.OKCancel) == DialogResult.OK;
            if (isDelConfirmed)
            {
                using (var context = new ApplicationDBContext())
                {
                    context.DelEmployee(Employee);
                }
                this.Close();
            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Employees employees = new Employees();
            employees.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var edit = new EmployeeCreateEdit(Employee);
            if (edit.ShowDialog() == DialogResult.OK)
            {
                using (var context = new ApplicationDBContext())
                {
                    context.EditEmployee(edit.Employee);
                }
                Employee = edit.Employee;
                this.Close();
            }
        }

        private void RentHistoryButton_Click(object sender, EventArgs e)
        {
            Reception[] receptions;
            using (var context = new ApplicationDBContext())
            {
                receptions =
                    context.GetReceptions(SearchReceptionParam.SearchByEmployeeId(Employee.ID))
                    .ToArray();
            }

            var history = new RentHistoryView(receptions);
            history.ShowDialog();
        }
    }
}
