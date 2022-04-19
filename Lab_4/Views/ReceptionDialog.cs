using Lab_4.Models.Library;
using System;
using System.Windows.Forms;

namespace Lab_4.Views
{
    public partial class ReceptionDialog : Form
    {
        public ReceptionInfo ReceptionInfo { get; private set; }
        private readonly Rent rent;
        public ReceptionDialog(Rent rent)
        {
            InitializeComponent();
            
            this.rent = rent;

            carTextBox.Text = rent.Car.ToString();
            clientTextBox.Text = rent.Client.ToString();
        }

        private void CloseRentButton_Click(object sender, EventArgs e)
        {
            ReceptionInfo = new ReceptionInfo(
                rent.ID,
                rent.Car.ID,
                DateTime.Now,
                conclusionTextBox.Text,
                damageTextBox.Text
            );
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ReceptionDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
