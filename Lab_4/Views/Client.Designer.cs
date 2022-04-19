namespace Lab_4.Views
{
    partial class ClientView
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
            this.label8 = new System.Windows.Forms.Label();
            this.rentHistoryButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.drivingLicenseTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.passportTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Born = new System.Windows.Forms.Label();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.dealsCountTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Кол-во обращений";
            // 
            // rentHistoryButton
            // 
            this.rentHistoryButton.Location = new System.Drawing.Point(115, 306);
            this.rentHistoryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rentHistoryButton.Name = "rentHistoryButton";
            this.rentHistoryButton.Size = new System.Drawing.Size(248, 71);
            this.rentHistoryButton.TabIndex = 48;
            this.rentHistoryButton.Text = "История аренд";
            this.rentHistoryButton.UseVisualStyleBackColor = true;
            this.rentHistoryButton.Click += new System.EventHandler(this.RentList_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(407, 306);
            this.EditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(191, 71);
            this.EditButton.TabIndex = 47;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(640, 306);
            this.DelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(149, 71);
            this.DelButton.TabIndex = 45;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 78;
            this.label1.Text = "ФИО ";
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Location = new System.Drawing.Point(175, 198);
            this.birthDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(183, 22);
            this.birthDatePicker.TabIndex = 77;
            // 
            // drivingLicenseTextBox
            // 
            this.drivingLicenseTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.drivingLicenseTextBox.Location = new System.Drawing.Point(240, 153);
            this.drivingLicenseTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drivingLicenseTextBox.Name = "drivingLicenseTextBox";
            this.drivingLicenseTextBox.Size = new System.Drawing.Size(637, 22);
            this.drivingLicenseTextBox.TabIndex = 76;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.phoneTextBox.Location = new System.Drawing.Point(175, 107);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(703, 22);
            this.phoneTextBox.TabIndex = 75;
            // 
            // passportTextBox
            // 
            this.passportTextBox.Location = new System.Drawing.Point(175, 63);
            this.passportTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.Size = new System.Drawing.Size(703, 22);
            this.passportTextBox.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 17);
            this.label7.TabIndex = 73;
            this.label7.Text = "Водительское удостоверение";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 72;
            this.label6.Text = "Номер телефона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 71;
            this.label3.Text = "Паспортные данные";
            // 
            // Born
            // 
            this.Born.AutoSize = true;
            this.Born.Location = new System.Drawing.Point(15, 198);
            this.Born.Name = "Born";
            this.Born.Size = new System.Drawing.Size(111, 17);
            this.Born.TabIndex = 70;
            this.Born.Text = "Дата рождения";
            // 
            // fioTextBox
            // 
            this.fioTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.fioTextBox.Location = new System.Drawing.Point(167, 20);
            this.fioTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(711, 22);
            this.fioTextBox.TabIndex = 69;
            // 
            // dealsCountTextBox
            // 
            this.dealsCountTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.dealsCountTextBox.Location = new System.Drawing.Point(175, 261);
            this.dealsCountTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dealsCountTextBox.Name = "dealsCountTextBox";
            this.dealsCountTextBox.ReadOnly = true;
            this.dealsCountTextBox.Size = new System.Drawing.Size(703, 22);
            this.dealsCountTextBox.TabIndex = 79;
            this.dealsCountTextBox.TextChanged += new System.EventHandler(this.dealsCountTextBox_TextChanged);
            // 
            // ClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 384);
            this.Controls.Add(this.dealsCountTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.birthDatePicker);
            this.Controls.Add(this.drivingLicenseTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.passportTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Born);
            this.Controls.Add(this.fioTextBox);
            this.Controls.Add(this.rentHistoryButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.label8);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClientView";
            this.Text = "Клиент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button rentHistoryButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.TextBox drivingLicenseTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox passportTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Born;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.TextBox dealsCountTextBox;
    }
}