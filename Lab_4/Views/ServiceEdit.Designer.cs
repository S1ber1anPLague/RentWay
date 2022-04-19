namespace Lab_4.Views
{
    partial class ServiceCreateEdit
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
            this.GoBackButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.specificationTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(795, 0);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(123, 40);
            this.GoBackButton.TabIndex = 18;
            this.GoBackButton.Text = "<<";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Описание";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(285, 104);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(580, 22);
            this.priceTextBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Цена";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(285, 56);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(580, 22);
            this.nameTextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Название дополнительной услуги";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(341, 407);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(253, 57);
            this.SaveButton.TabIndex = 33;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // specificationTextBox
            // 
            this.specificationTextBox.Location = new System.Drawing.Point(12, 191);
            this.specificationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.specificationTextBox.Multiline = true;
            this.specificationTextBox.Name = "specificationTextBox";
            this.specificationTextBox.Size = new System.Drawing.Size(892, 212);
            this.specificationTextBox.TabIndex = 34;
            // 
            // ServiceCreateEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 475);
            this.Controls.Add(this.specificationTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ServiceCreateEdit";
            this.Text = "Редактирование";
            this.Load += new System.EventHandler(this.ServiceCreateEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox specificationTextBox;
    }
}