using Lab_4.Models.Library;
using Lab_4.Utils;
using System;
using System.Windows.Forms;

namespace Lab_4.Views
{
    public partial class RentHistoryView : Form
    {
        public RentHistoryView(Reception[] receptions)
        {
            InitializeComponent();
            receptionsDataGridView.DataSource = receptions.ToSortableBindingList();

            receptionsDataGridView.Columns[nameof(Reception.Rent)].Visible = false;
            receptionsDataGridView.Columns[nameof(Reception.EmployeeConclusion)].Visible =
                false;

            receptionsDataGridView.Columns[nameof(Reception.Id)].HeaderText =
                Localizations.GetValueOrSelf(nameof(Reception.Id));
            receptionsDataGridView.Columns[nameof(Reception.DateOfReceipt)].HeaderText =
                Localizations.GetValueOrSelf(nameof(Reception.DateOfReceipt));
        }

        private void ReceptionsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            detailsTextBox.Clear();
            if (receptionsDataGridView.SelectedRows.Count < 1)
            {
                return;
            }

            var reception = receptionsDataGridView.SelectedRows[0].DataBoundItem as Reception;
            detailsTextBox.Text = reception.GetDetails();
        }

        private void RentHistoryView_Load(object sender, EventArgs e)
        {

        }
    }
}
