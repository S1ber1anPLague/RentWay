using Lab_4.DataBase;
using Lab_4.Models.Statistics;
using System;
using System.Windows.Forms;

namespace Lab_4.Views.Statistics
{
    public partial class SummaryMenuView : Form
    {
        public SummaryMenuView()
        {
            InitializeComponent();
        }

        private void CarsSummaryButton_Click(object sender, EventArgs e)
        {
            CarsStatInfo info;
            using (var context = new ApplicationDBContext())
            {
                info = context.GetCarsStatInfo();
            }

            var view = new CarsSummaryView(info);
            view.ShowDialog();
        }

        private void ClientsSummaryButton_Click(object sender, EventArgs e)
        {
            ClientsStatInfo info;
            using (var context = new ApplicationDBContext())
            {
                info = context.GetClientsStatInfo();
            }

            var view = new ClientsSummaryView(info);
            view.ShowDialog();
        }

        private void TotalSummaryButton_Click(object sender, EventArgs e)
        {
            TotalStatInfo info;
            using (var context = new ApplicationDBContext())
            {
                info = context.GetTotalStatInfo();
            }

            var view = new TotalSummaryView(info);
            view.ShowDialog();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SummaryMenuView_Load(object sender, EventArgs e)
        {

        }
    }
}
