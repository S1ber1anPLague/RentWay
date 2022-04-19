using Lab_4.Models.Statistics;
using System.Windows.Forms;

namespace Lab_4.Views.Statistics
{
    public partial class TotalSummaryView : Form
    {
        public TotalSummaryView(TotalStatInfo statInfo)
        {
            InitializeComponent();

            rentsCountTextBox.Text = statInfo.RentsCount.ToString();
            carsCountTextBox.Text = statInfo.CarsCount.ToString();
            clientsCountTextBox.Text = statInfo.ClientsCount.ToString();
        }

        private void TotalSummaryView_Load(object sender, System.EventArgs e)
        {

        }
    }
}
