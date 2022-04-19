namespace Lab_4.Views
{
    partial class ClientCreateEdit
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
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.drivingLicenseTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.passportTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Born = new System.Windows.Forms.Label();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.dealsCountTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(787, 1);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(96, 38);
            this.GoBackButton.TabIndex = 65;
            this.GoBackButton.Text = "<<";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Location = new System.Drawing.Point(239, 224);
            this.birthDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(183, 22);
            this.birthDatePicker.TabIndex = 63;
            // 
            // drivingLicenseTextBox
            // 
            this.drivingLicenseTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.drivingLicenseTextBox.Location = new System.Drawing.Point(239, 178);
            this.drivingLicenseTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drivingLicenseTextBox.Name = "drivingLicenseTextBox";
            this.drivingLicenseTextBox.Size = new System.Drawing.Size(637, 22);
            this.drivingLicenseTextBox.TabIndex = 62;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.phoneTextBox.Location = new System.Drawing.Point(239, 133);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(637, 22);
            this.phoneTextBox.TabIndex = 61;
            // 
            // passportTextBox
            // 
            this.passportTextBox.Location = new System.Drawing.Point(239, 89);
            this.passportTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.Size = new System.Drawing.Size(637, 22);
            this.passportTextBox.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 17);
            this.label7.TabIndex = 58;
            this.label7.Text = "Водительское удостоверение";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 57;
            this.label6.Text = "Номер телефона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "Паспортные данные";
            // 
            // Born
            // 
            this.Born.AutoSize = true;
            this.Born.Location = new System.Drawing.Point(15, 233);
            this.Born.Name = "Born";
            this.Born.Size = new System.Drawing.Size(111, 17);
            this.Born.TabIndex = 55;
            this.Born.Text = "Дата рождения";
            // 
            // fioTextBox
            // 
            this.fioTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.fioTextBox.Location = new System.Drawing.Point(239, 46);
            this.fioTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(637, 22);
            this.fioTextBox.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "ФИО ";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(274, 333);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(342, 54);
            this.saveButton.TabIndex = 69;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // dealsCountTextBox
            // 
            this.dealsCountTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.dealsCountTextBox.Location = new System.Drawing.Point(239, 279);
            this.dealsCountTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dealsCountTextBox.Name = "dealsCountTextBox";
            this.dealsCountTextBox.ReadOnly = true;
            this.dealsCountTextBox.Size = new System.Drawing.Size(643, 22);
            this.dealsCountTextBox.TabIndex = 81;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 17);
            this.label8.TabIndex = 80;
            this.label8.Text = "Кол-во обращений";
            // 
            // ClientCreateEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 398);
            this.Controls.Add(this.dealsCountTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.birthDatePicker);
            this.Controls.Add(this.drivingLicenseTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.passportTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Born);
            this.Controls.Add(this.fioTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClientCreateEdit";
            this.Text = "Редактирование";
            this.Load += new System.EventHandler(this.ClientCreateEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.TextBox drivingLicenseTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox passportTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Born;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox dealsCountTextBox;
        private System.Windows.Forms.Label label8;
    }
}