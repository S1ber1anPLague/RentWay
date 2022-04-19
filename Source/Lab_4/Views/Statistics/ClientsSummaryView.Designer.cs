
namespace Lab_4.Views.Statistics
{
    partial class ClientsSummaryView
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
            this.infoDataGridView = new System.Windows.Forms.DataGridView();
            this.clientsCountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // infoDataGridView
            // 
            this.infoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoDataGridView.Location = new System.Drawing.Point(11, 108);
            this.infoDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoDataGridView.Name = "infoDataGridView";
            this.infoDataGridView.ReadOnly = true;
            this.infoDataGridView.RowHeadersVisible = false;
            this.infoDataGridView.RowHeadersWidth = 62;
            this.infoDataGridView.RowTemplate.Height = 31;
            this.infoDataGridView.Size = new System.Drawing.Size(781, 359);
            this.infoDataGridView.TabIndex = 5;
            // 
            // clientsCountTextBox
            // 
            this.clientsCountTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientsCountTextBox.Location = new System.Drawing.Point(579, 15);
            this.clientsCountTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientsCountTextBox.Name = "clientsCountTextBox";
            this.clientsCountTextBox.ReadOnly = true;
            this.clientsCountTextBox.Size = new System.Drawing.Size(207, 34);
            this.clientsCountTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество клиентов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Постоянные клиенты";
            // 
            // ClientsSummaryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 490);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.infoDataGridView);
            this.Controls.Add(this.clientsCountTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClientsSummaryView";
            this.Text = "Сводка по клиентам";
            this.Load += new System.EventHandler(this.ClientsSummaryView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView infoDataGridView;
        private System.Windows.Forms.TextBox clientsCountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}