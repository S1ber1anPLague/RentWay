using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4.Views
{
    public partial class Execution : Form
    {
        public Execution()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            AllRents allrent = new AllRents();
            allrent.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClientChoice_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CarChoice_Click(object sender, EventArgs e)
        {
            Cars cars = new Cars();
            cars.Show();
        }
    }
}
