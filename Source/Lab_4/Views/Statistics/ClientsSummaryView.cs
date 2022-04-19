using Lab_4.Models.Statistics;
using Lab_4.Utils;
using System.Linq;
using System.Windows.Forms;

namespace Lab_4.Views.Statistics
{
    public partial class ClientsSummaryView : Form
    {
        public ClientsSummaryView(ClientsStatInfo statInfo)
        {
            InitializeComponent();

            clientsCountTextBox.Text = statInfo.ClientsCount.ToString();
            infoDataGridView.DataSource =
                statInfo.Info.OrderByDescending(i => i.Count).ToSortableBindingList();

            infoDataGridView.Columns[nameof(Info.Value)].HeaderText =
                "Клиент";
            infoDataGridView.Columns[nameof(Info.Count)].HeaderText =
                "Количество аренд";
        }

        private void ClientsSummaryView_Load(object sender, System.EventArgs e)
        {

        }
    }
}
