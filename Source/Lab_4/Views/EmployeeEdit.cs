using Lab_4.Models.Library;
using Lab_4.Utils;
using System;
using System.Linq;
using System.Windows.Forms;
using ValidationsCollection;

namespace Lab_4.Views
{
    public partial class EmployeeCreateEdit : Form
    {
        public Employee Employee { get; private set; }
        public EmployeeCreateEdit()
        {
            InitializeComponent();
            Text = "Создание нового сотрудника";
        }

        public EmployeeCreateEdit(Employee employee)
        {
            InitializeComponent();
            this.Employee = employee;
            this.Text = "Редактирование информации о сотруднике";
        }

        private void ShowEmployee()
        {
            fioTextBox.Text = Employee.FIO;
            passportTextBox.Text = Employee.Passport;
            phoneTextBox.Text = Employee.PhoneNumber;
            postTextBox.Text = Employee.Post;
            passwordTextBox.Text = Employee.Pass;
            loginTextBox.Text = Employee.Login;
            innTextBox.Text = Employee.ITN;

            var source = (Role[])rolesComboBox.DataSource;
            var role = source.First(r => r == Employee.Role);

            rolesComboBox.SelectedItem = role;
                
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsValid()
        {
            return
                 !string.IsNullOrWhiteSpace(fioTextBox.Text)
                 && !string.IsNullOrWhiteSpace(passportTextBox.Text)
                 && !string.IsNullOrWhiteSpace(phoneTextBox.Text)
                 && !string.IsNullOrWhiteSpace(postTextBox.Text)
                 && !string.IsNullOrWhiteSpace(loginTextBox.Text)
                 && !string.IsNullOrWhiteSpace(passwordTextBox.Text)
                 // проверяем валидность ИНН
                 && Validations.IsValidInn(innTextBox.Text)
                 // паспорта
                 && SimpleValidators.Passport(passportTextBox.Text)
                 // телефона
                 && SimpleValidators.Phone(phoneTextBox.Text);
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                Employee = new Employee(
                    loginTextBox.Text,
                    passwordTextBox.Text,
                    postTextBox.Text,
                    innTextBox.Text,
                    Employee?.ID ?? 0,
                    fioTextBox.Text,
                    phoneTextBox.Text,
                    passportTextBox.Text,
                    (Role)rolesComboBox.SelectedItem
                    );
                this.Close();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Ошибка! Проверьте корректность вводимых данных");
            }
        }

        private void EmployeeCreateEdit_Load(object sender, EventArgs e)
        {
            rolesComboBox.DataSource = new Role[]
            {
                Role.Admin,
                Role.Director,
                Role.Manager
            };
            if (Employee != null)
            {
                ShowEmployee();
            }
            rolesComboBox.FormattingEnabled = true;
            rolesComboBox.Format += RolesComboBox_Format;
        }

        private void RolesComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            var role = ((Role)e.Value).ToString();
            e.Value = Localizations.GetValueOrSelf(role);
        }
    }
}
