using Lab_4.Models.Statistics;
using Lab_4.Utils;
using System.Linq;
using System.Windows.Forms;

namespace Lab_4.Views.Statistics
{
    public partial class CarsSummaryView : Form
    {
        public CarsSummaryView(CarsStatInfo statInfo)
        {
            InitializeComponent();

            carsCountTextBox.Text = statInfo.RentedCar.ToString();
            infoDataGridView.DataSource =
                statInfo.Info
                  .OrderByDescending(i => i.Count) // сортируем по убыванию количество
                  .ToSortableBindingList(); // преобразовываем к сортируемому списку
            // устанавливаем перевод для заголовков столбцов DataGridView
            infoDataGridView.Columns[nameof(Info.Value)].HeaderText =
                "Автомобиль";
            infoDataGridView.Columns[nameof(Info.Count)].HeaderText =
                "Количество аренд";
        }

        private void CarsSummaryView_Load(object sender, System.EventArgs e)
        {

        }

        private void infoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
