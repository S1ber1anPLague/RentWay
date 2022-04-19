
namespace Lab_4.Views.Statistics
{
    partial class SummaryMenuView
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
            this.carsSummaryButton = new System.Windows.Forms.Button();
            this.clientsSummaryButton = new System.Windows.Forms.Button();
            this.totalSummaryButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // carsSummaryButton
            // 
            this.carsSummaryButton.Location = new System.Drawing.Point(104, 112);
            this.carsSummaryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carsSummaryButton.Name = "carsSummaryButton";
            this.carsSummaryButton.Size = new System.Drawing.Size(216, 66);
            this.carsSummaryButton.TabIndex = 0;
            this.carsSummaryButton.Text = "Сводка по машинам";
            this.carsSummaryButton.UseVisualStyleBackColor = true;
            this.carsSummaryButton.Click += new System.EventHandler(this.CarsSummaryButton_Click);
            // 
            // clientsSummaryButton
            // 
            this.clientsSummaryButton.Location = new System.Drawing.Point(369, 112);
            this.clientsSummaryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clientsSummaryButton.Name = "clientsSummaryButton";
            this.clientsSummaryButton.Size = new System.Drawing.Size(216, 66);
            this.clientsSummaryButton.TabIndex = 1;
            this.clientsSummaryButton.Text = "Сводка по клиентам";
            this.clientsSummaryButton.UseVisualStyleBackColor = true;
            this.clientsSummaryButton.Click += new System.EventHandler(this.ClientsSummaryButton_Click);
            // 
            // totalSummaryButton
            // 
            this.totalSummaryButton.Location = new System.Drawing.Point(641, 112);
            this.totalSummaryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalSummaryButton.Name = "totalSummaryButton";
            this.totalSummaryButton.Size = new System.Drawing.Size(216, 66);
            this.totalSummaryButton.TabIndex = 2;
            this.totalSummaryButton.Text = "Общая сводка";
            this.totalSummaryButton.UseVisualStyleBackColor = true;
            this.totalSummaryButton.Click += new System.EventHandler(this.TotalSummaryButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(809, 14);
            this.goBackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(112, 36);
            this.goBackButton.TabIndex = 3;
            this.goBackButton.Text = "<<";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // SummaryMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 310);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.totalSummaryButton);
            this.Controls.Add(this.clientsSummaryButton);
            this.Controls.Add(this.carsSummaryButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SummaryMenuView";
            this.Text = "Сводки";
            this.Load += new System.EventHandler(this.SummaryMenuView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button carsSummaryButton;
        private System.Windows.Forms.Button clientsSummaryButton;
        private System.Windows.Forms.Button totalSummaryButton;
        private System.Windows.Forms.Button goBackButton;
    }
}