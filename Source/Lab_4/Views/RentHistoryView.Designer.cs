
namespace Lab_4.Views
{
    partial class RentHistoryView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.receptionsDataGridView = new System.Windows.Forms.DataGridView();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.receptionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // receptionsDataGridView
            // 
            this.receptionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receptionsDataGridView.Location = new System.Drawing.Point(16, 15);
            this.receptionsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.receptionsDataGridView.MultiSelect = false;
            this.receptionsDataGridView.Name = "receptionsDataGridView";
            this.receptionsDataGridView.ReadOnly = true;
            this.receptionsDataGridView.RowHeadersVisible = false;
            this.receptionsDataGridView.RowHeadersWidth = 51;
            this.receptionsDataGridView.RowTemplate.Height = 24;
            this.receptionsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.receptionsDataGridView.Size = new System.Drawing.Size(1035, 238);
            this.receptionsDataGridView.TabIndex = 0;
            this.receptionsDataGridView.SelectionChanged += new System.EventHandler(this.ReceptionsDataGridView_SelectionChanged);
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detailsTextBox.Location = new System.Drawing.Point(16, 284);
            this.detailsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.detailsTextBox.Multiline = true;
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.detailsTextBox.Size = new System.Drawing.Size(1033, 239);
            this.detailsTextBox.TabIndex = 1;
            // 
            // RentHistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.detailsTextBox);
            this.Controls.Add(this.receptionsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RentHistoryView";
            this.Text = "История аренд";
            this.Load += new System.EventHandler(this.RentHistoryView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.receptionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView receptionsDataGridView;
        private System.Windows.Forms.TextBox detailsTextBox;
    }
}