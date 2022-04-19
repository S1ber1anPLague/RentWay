
namespace Lab_4.Views.Statistics
{
    partial class CarsSummaryView
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
            this.label1 = new System.Windows.Forms.Label();
            this.carsCountTextBox = new System.Windows.Forms.TextBox();
            this.infoDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество находившихся в аренде автомобилей";
            // 
            // carsCountTextBox
            // 
            this.carsCountTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carsCountTextBox.Location = new System.Drawing.Point(567, 17);
            this.carsCountTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carsCountTextBox.Name = "carsCountTextBox";
            this.carsCountTextBox.ReadOnly = true;
            this.carsCountTextBox.Size = new System.Drawing.Size(207, 34);
            this.carsCountTextBox.TabIndex = 1;
            // 
            // infoDataGridView
            // 
            this.infoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoDataGridView.Location = new System.Drawing.Point(11, 94);
            this.infoDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoDataGridView.Name = "infoDataGridView";
            this.infoDataGridView.ReadOnly = true;
            this.infoDataGridView.RowHeadersVisible = false;
            this.infoDataGridView.RowHeadersWidth = 62;
            this.infoDataGridView.RowTemplate.Height = 31;
            this.infoDataGridView.Size = new System.Drawing.Size(841, 393);
            this.infoDataGridView.TabIndex = 2;
            this.infoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.infoDataGridView_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(557, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Рейтинг наиболее популярных для аренды автомобилей";
            // 
            // CarsSummaryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 495);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.infoDataGridView);
            this.Controls.Add(this.carsCountTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CarsSummaryView";
            this.Text = "Сводка по автомобилям";
            this.Load += new System.EventHandler(this.CarsSummaryView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox carsCountTextBox;
        private System.Windows.Forms.DataGridView infoDataGridView;
        private System.Windows.Forms.Label label3;
    }
}