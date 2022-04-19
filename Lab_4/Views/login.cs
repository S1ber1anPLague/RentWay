using Lab_4.DataBase;
using System;
using System.Windows.Forms;

namespace Lab_4.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ApplicationData.Person = null;
        }

        private void PassButton_Click(object sender, EventArgs e)
        {
            if (passBox.ReadOnly != true)
            {
                passBox.ReadOnly = true;
                passBox.PasswordChar = '\0';
                PassButton.Text = "Скрыть";
            }
            else
            {
                passBox.ReadOnly = false;
                passBox.PasswordChar = '*';
                PassButton.Text = "Показать";
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDBContext())
            {
                ApplicationData.Person = context.FindEmployee(loginTextBox.Text, passBox.Text);
            }
            if (ApplicationData.Person == null)
            {
                MessageBox.Show("Нет совпадений. Проверьте правильность ввода логина и пароля!");
                return;
            }

            var mainmenu = new MainMenu();
            mainmenu.Show();
            this.Hide();
            mainmenu.FormClosed += Mainmenu_FormClosed;
            passBox.Text = "";
            loginTextBox.Text = "";
        }

        private void Mainmenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
