namespace Lab_4.Views
{
    partial class RentView
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
            this.editButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.typeOfPaymentTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.daysUpDown = new System.Windows.Forms.NumericUpDown();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.carTextBox = new System.Windows.Forms.TextBox();
            this.employeeTextBox = new System.Windows.Forms.TextBox();
            this.clientTextBox = new System.Windows.Forms.TextBox();
            this.servicesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.daysUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(248, 564);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(187, 54);
            this.editButton.TabIndex = 53;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(796, 2);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(122, 44);
            this.GoBackButton.TabIndex = 58;
            this.GoBackButton.Text = "<<";
            this.GoBackButton.UseVisualStyleBackColor = true;
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(503, 564);
            this.delButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(185, 54);
            this.delButton.TabIndex = 54;
            this.delButton.Text = "Удалить";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Visible = false;
            this.delButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // typeOfPaymentTextBox
            // 
            this.typeOfPaymentTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.typeOfPaymentTextBox.Location = new System.Drawing.Point(196, 272);
            this.typeOfPaymentTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeOfPaymentTextBox.Name = "typeOfPaymentTextBox";
            this.typeOfPaymentTextBox.ReadOnly = true;
            this.typeOfPaymentTextBox.Size = new System.Drawing.Size(505, 22);
            this.typeOfPaymentTextBox.TabIndex = 106;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 105;
            this.label5.Text = "Тип оплаты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 101;
            this.label1.Text = "Клиент";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Enabled = false;
            this.endDatePicker.Location = new System.Drawing.Point(196, 229);
            this.endDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(344, 22);
            this.endDatePicker.TabIndex = 100;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 17);
            this.label9.TabIndex = 99;
            this.label9.Text = "Дата конца аренды";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 17);
            this.label2.TabIndex = 98;
            this.label2.Text = "Дополнительные услуги";
            // 
            // daysUpDown
            // 
            this.daysUpDown.Location = new System.Drawing.Point(195, 191);
            this.daysUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.daysUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.daysUpDown.Name = "daysUpDown";
            this.daysUpDown.ReadOnly = true;
            this.daysUpDown.Size = new System.Drawing.Size(347, 22);
            this.daysUpDown.TabIndex = 96;
            this.daysUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startDatePicker
            // 
            this.startDatePicker.Enabled = false;
            this.startDatePicker.Location = new System.Drawing.Point(196, 154);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(344, 22);
            this.startDatePicker.TabIndex = 95;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.priceTextBox.Location = new System.Drawing.Point(195, 315);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(507, 22);
            this.priceTextBox.TabIndex = 94;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(15, 319);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(43, 17);
            this.label.TabIndex = 93;
            this.label.Text = "Цена";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 92;
            this.label7.Text = "Сотрудник ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 91;
            this.label4.Text = "Кол-во дней аренды";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 90;
            this.label3.Text = "Дата начала аренды";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 89;
            this.label6.Text = "Автомобиль";
            // 
            // carTextBox
            // 
            this.carTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.carTextBox.Location = new System.Drawing.Point(183, 43);
            this.carTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carTextBox.Name = "carTextBox";
            this.carTextBox.ReadOnly = true;
            this.carTextBox.Size = new System.Drawing.Size(505, 22);
            this.carTextBox.TabIndex = 107;
            // 
            // employeeTextBox
            // 
            this.employeeTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.employeeTextBox.Location = new System.Drawing.Point(183, 74);
            this.employeeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeTextBox.Name = "employeeTextBox";
            this.employeeTextBox.ReadOnly = true;
            this.employeeTextBox.Size = new System.Drawing.Size(505, 22);
            this.employeeTextBox.TabIndex = 108;
            // 
            // clientTextBox
            // 
            this.clientTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.clientTextBox.Location = new System.Drawing.Point(183, 105);
            this.clientTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientTextBox.Name = "clientTextBox";
            this.clientTextBox.ReadOnly = true;
            this.clientTextBox.Size = new System.Drawing.Size(505, 22);
            this.clientTextBox.TabIndex = 109;
            // 
            // servicesDataGridView
            // 
            this.servicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesDataGridView.Location = new System.Drawing.Point(15, 395);
            this.servicesDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.servicesDataGridView.Name = "servicesDataGridView";
            this.servicesDataGridView.ReadOnly = true;
            this.servicesDataGridView.RowHeadersVisible = false;
            this.servicesDataGridView.RowHeadersWidth = 51;
            this.servicesDataGridView.RowTemplate.Height = 24;
            this.servicesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.servicesDataGridView.Size = new System.Drawing.Size(903, 150);
            this.servicesDataGridView.TabIndex = 110;
            // 
            // RentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 629);
            this.Controls.Add(this.servicesDataGridView);
            this.Controls.Add(this.clientTextBox);
            this.Controls.Add(this.employeeTextBox);
            this.Controls.Add(this.carTextBox);
            this.Controls.Add(this.typeOfPaymentTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.daysUpDown);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.editButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RentView";
            this.Text = "Аренда";
            ((System.ComponentModel.ISupportInitialize)(this.daysUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.TextBox typeOfPaymentTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown daysUpDown;
        public System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox carTextBox;
        private System.Windows.Forms.TextBox employeeTextBox;
        private System.Windows.Forms.TextBox clientTextBox;
        private System.Windows.Forms.DataGridView servicesDataGridView;
    }
}