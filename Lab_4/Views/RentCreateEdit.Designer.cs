namespace Lab_4.Views
{
    partial class RentCreateEdit
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
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.servicesDataGridView = new System.Windows.Forms.DataGridView();
            this.daysUpDown = new System.Windows.Forms.NumericUpDown();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.addServiceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.carsComboBox = new System.Windows.Forms.ComboBox();
            this.employeesComboBox = new System.Windows.Forms.ComboBox();
            this.clientsComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.typeOfPaymentTextBox = new System.Windows.Forms.TextBox();
            this.closeRentButton = new System.Windows.Forms.Button();
            this.depositAmountTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.removeServiceButton = new System.Windows.Forms.Button();
            this.servicesComboBox = new System.Windows.Forms.ComboBox();
            this.quantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(1035, 1);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(96, 40);
            this.GoBackButton.TabIndex = 80;
            this.GoBackButton.Text = "<<";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // endDatePicker
            // 
            this.endDatePicker.Enabled = false;
            this.endDatePicker.Location = new System.Drawing.Point(189, 225);
            this.endDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(344, 22);
            this.endDatePicker.TabIndex = 79;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 17);
            this.label9.TabIndex = 78;
            this.label9.Text = "Дата конца аренды";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 77;
            this.label8.Text = "Услуга";
            // 
            // servicesDataGridView
            // 
            this.servicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesDataGridView.Location = new System.Drawing.Point(19, 380);
            this.servicesDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.servicesDataGridView.Name = "servicesDataGridView";
            this.servicesDataGridView.ReadOnly = true;
            this.servicesDataGridView.RowHeadersVisible = false;
            this.servicesDataGridView.RowHeadersWidth = 51;
            this.servicesDataGridView.RowTemplate.Height = 24;
            this.servicesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.servicesDataGridView.Size = new System.Drawing.Size(903, 150);
            this.servicesDataGridView.TabIndex = 76;
            // 
            // daysUpDown
            // 
            this.daysUpDown.Location = new System.Drawing.Point(188, 187);
            this.daysUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.daysUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.daysUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.daysUpDown.Name = "daysUpDown";
            this.daysUpDown.Size = new System.Drawing.Size(347, 22);
            this.daysUpDown.TabIndex = 75;
            this.daysUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.daysUpDown.ValueChanged += new System.EventHandler(this.DaysUpDown_ValueChanged);
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(189, 150);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(344, 22);
            this.startDatePicker.TabIndex = 74;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.priceTextBox.Location = new System.Drawing.Point(197, 558);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(723, 22);
            this.priceTextBox.TabIndex = 72;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(15, 561);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(170, 17);
            this.label.TabIndex = 68;
            this.label.Text = "Цена (без учета залога)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 67;
            this.label7.Text = "Сотрудник ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 64;
            this.label4.Text = "Кол-во дней аренды";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "Дата начала аренды";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Автомобиль";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(261, 613);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(239, 60);
            this.saveButton.TabIndex = 81;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // addServiceButton
            // 
            this.addServiceButton.Location = new System.Drawing.Point(927, 380);
            this.addServiceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(205, 55);
            this.addServiceButton.TabIndex = 82;
            this.addServiceButton.Text = "Добавить";
            this.addServiceButton.UseVisualStyleBackColor = true;
            this.addServiceButton.Click += new System.EventHandler(this.AddServiceButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 83;
            this.label1.Text = "Клиент";
            // 
            // carsComboBox
            // 
            this.carsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carsComboBox.FormattingEnabled = true;
            this.carsComboBox.Location = new System.Drawing.Point(188, 39);
            this.carsComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carsComboBox.Name = "carsComboBox";
            this.carsComboBox.Size = new System.Drawing.Size(803, 24);
            this.carsComboBox.TabIndex = 84;
            this.carsComboBox.SelectedIndexChanged += new System.EventHandler(this.CarsComboBox_SelectedIndexChanged);
            // 
            // employeesComboBox
            // 
            this.employeesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeesComboBox.FormattingEnabled = true;
            this.employeesComboBox.Location = new System.Drawing.Point(188, 70);
            this.employeesComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.employeesComboBox.Name = "employeesComboBox";
            this.employeesComboBox.Size = new System.Drawing.Size(803, 24);
            this.employeesComboBox.TabIndex = 85;
            // 
            // clientsComboBox
            // 
            this.clientsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientsComboBox.FormattingEnabled = true;
            this.clientsComboBox.Location = new System.Drawing.Point(188, 101);
            this.clientsComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clientsComboBox.Name = "clientsComboBox";
            this.clientsComboBox.Size = new System.Drawing.Size(801, 24);
            this.clientsComboBox.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 87;
            this.label5.Text = "Тип оплаты";
            // 
            // typeOfPaymentTextBox
            // 
            this.typeOfPaymentTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.typeOfPaymentTextBox.Location = new System.Drawing.Point(189, 268);
            this.typeOfPaymentTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeOfPaymentTextBox.Name = "typeOfPaymentTextBox";
            this.typeOfPaymentTextBox.Size = new System.Drawing.Size(505, 22);
            this.typeOfPaymentTextBox.TabIndex = 88;
            // 
            // closeRentButton
            // 
            this.closeRentButton.Location = new System.Drawing.Point(592, 613);
            this.closeRentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeRentButton.Name = "closeRentButton";
            this.closeRentButton.Size = new System.Drawing.Size(205, 60);
            this.closeRentButton.TabIndex = 89;
            this.closeRentButton.Text = "Закрыть";
            this.closeRentButton.UseVisualStyleBackColor = true;
            this.closeRentButton.Click += new System.EventHandler(this.CloseRentButton_Click);
            // 
            // depositAmountTextBox
            // 
            this.depositAmountTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.depositAmountTextBox.Location = new System.Drawing.Point(188, 300);
            this.depositAmountTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.depositAmountTextBox.Name = "depositAmountTextBox";
            this.depositAmountTextBox.ReadOnly = true;
            this.depositAmountTextBox.Size = new System.Drawing.Size(507, 22);
            this.depositAmountTextBox.TabIndex = 91;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 90;
            this.label6.Text = "Залог";
            // 
            // removeServiceButton
            // 
            this.removeServiceButton.Location = new System.Drawing.Point(928, 476);
            this.removeServiceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeServiceButton.Name = "removeServiceButton";
            this.removeServiceButton.Size = new System.Drawing.Size(205, 54);
            this.removeServiceButton.TabIndex = 92;
            this.removeServiceButton.Text = "Удалить из списка";
            this.removeServiceButton.UseVisualStyleBackColor = true;
            this.removeServiceButton.Click += new System.EventHandler(this.RemoveServiceButton_Click);
            // 
            // servicesComboBox
            // 
            this.servicesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.servicesComboBox.FormattingEnabled = true;
            this.servicesComboBox.Location = new System.Drawing.Point(72, 334);
            this.servicesComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.servicesComboBox.Name = "servicesComboBox";
            this.servicesComboBox.Size = new System.Drawing.Size(560, 24);
            this.servicesComboBox.TabIndex = 93;
            // 
            // quantityUpDown
            // 
            this.quantityUpDown.Location = new System.Drawing.Point(824, 335);
            this.quantityUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quantityUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.quantityUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityUpDown.Name = "quantityUpDown";
            this.quantityUpDown.Size = new System.Drawing.Size(307, 22);
            this.quantityUpDown.TabIndex = 95;
            this.quantityUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(645, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 94;
            this.label10.Text = "Кол-во";
            // 
            // RentCreateEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 684);
            this.Controls.Add(this.quantityUpDown);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.servicesComboBox);
            this.Controls.Add(this.removeServiceButton);
            this.Controls.Add(this.depositAmountTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.closeRentButton);
            this.Controls.Add(this.typeOfPaymentTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clientsComboBox);
            this.Controls.Add(this.employeesComboBox);
            this.Controls.Add(this.carsComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addServiceButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.servicesDataGridView);
            this.Controls.Add(this.daysUpDown);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RentCreateEdit";
            this.Text = "Изменение данных";
            this.Load += new System.EventHandler(this.RentCreateEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView servicesDataGridView;
        private System.Windows.Forms.NumericUpDown daysUpDown;
        public System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox carsComboBox;
        private System.Windows.Forms.ComboBox employeesComboBox;
        private System.Windows.Forms.ComboBox clientsComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox typeOfPaymentTextBox;
        private System.Windows.Forms.Button closeRentButton;
        private System.Windows.Forms.TextBox depositAmountTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button removeServiceButton;
        private System.Windows.Forms.ComboBox servicesComboBox;
        private System.Windows.Forms.NumericUpDown quantityUpDown;
        private System.Windows.Forms.Label label10;
    }
}