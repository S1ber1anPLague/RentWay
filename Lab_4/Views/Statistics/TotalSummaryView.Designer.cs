
namespace Lab_4.Views.Statistics
{
    partial class TotalSummaryView
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
            this.rentsCountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clientsCountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.carsCountTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rentsCountTextBox
            // 
            this.rentsCountTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rentsCountTextBox.Location = new System.Drawing.Point(612, 43);
            this.rentsCountTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rentsCountTextBox.Name = "rentsCountTextBox";
            this.rentsCountTextBox.ReadOnly = true;
            this.rentsCountTextBox.Size = new System.Drawing.Size(207, 34);
            this.rentsCountTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(67, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество договоров по аренде";
            // 
            // clientsCountTextBox
            // 
            this.clientsCountTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientsCountTextBox.Location = new System.Drawing.Point(612, 105);
            this.clientsCountTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientsCountTextBox.Name = "clientsCountTextBox";
            this.clientsCountTextBox.ReadOnly = true;
            this.clientsCountTextBox.Size = new System.Drawing.Size(207, 34);
            this.clientsCountTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(67, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Число клиентов";
            // 
            // carsCountTextBox
            // 
            this.carsCountTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carsCountTextBox.Location = new System.Drawing.Point(612, 169);
            this.carsCountTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carsCountTextBox.Name = "carsCountTextBox";
            this.carsCountTextBox.ReadOnly = true;
            this.carsCountTextBox.Size = new System.Drawing.Size(207, 34);
            this.carsCountTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(67, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество автомобилей";
            // 
            // TotalSummaryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 251);
            this.Controls.Add(this.carsCountTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clientsCountTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rentsCountTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TotalSummaryView";
            this.Text = "Общая сводка";
            this.Load += new System.EventHandler(this.TotalSummaryView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rentsCountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientsCountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox carsCountTextBox;
        private System.Windows.Forms.Label label3;
    }
}