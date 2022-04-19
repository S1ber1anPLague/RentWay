namespace Lab_4.Views
{
    partial class Employees
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
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.newEmployeeButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Поиск = new System.Windows.Forms.GroupBox();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.passportTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.manageSelectedButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.параметрыСортировкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поФИОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поДолжностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            this.Поиск.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Location = new System.Drawing.Point(12, 182);
            this.employeesDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeesDataGridView.MultiSelect = false;
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.ReadOnly = true;
            this.employeesDataGridView.RowHeadersVisible = false;
            this.employeesDataGridView.RowHeadersWidth = 51;
            this.employeesDataGridView.RowTemplate.Height = 24;
            this.employeesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeesDataGridView.Size = new System.Drawing.Size(1023, 518);
            this.employeesDataGridView.TabIndex = 0;
            // 
            // newEmployeeButton
            // 
            this.newEmployeeButton.Location = new System.Drawing.Point(183, 703);
            this.newEmployeeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newEmployeeButton.Name = "newEmployeeButton";
            this.newEmployeeButton.Size = new System.Drawing.Size(309, 58);
            this.newEmployeeButton.TabIndex = 1;
            this.newEmployeeButton.Text = "Добавить нового сотрудника";
            this.newEmployeeButton.UseVisualStyleBackColor = true;
            this.newEmployeeButton.Click += new System.EventHandler(this.NewEmployee_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(940, 0);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(100, 37);
            this.GoBackButton.TabIndex = 3;
            this.GoBackButton.Text = "<<";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 704);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 57);
            this.button1.TabIndex = 16;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(914, 704);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 57);
            this.button2.TabIndex = 17;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Поиск
            // 
            this.Поиск.Controls.Add(this.postTextBox);
            this.Поиск.Controls.Add(this.searchButton);
            this.Поиск.Controls.Add(this.label6);
            this.Поиск.Controls.Add(this.passportTextBox);
            this.Поиск.Controls.Add(this.phoneTextBox);
            this.Поиск.Controls.Add(this.label10);
            this.Поиск.Controls.Add(this.label7);
            this.Поиск.Controls.Add(this.loginTextBox);
            this.Поиск.Controls.Add(this.fioTextBox);
            this.Поиск.Controls.Add(this.label9);
            this.Поиск.Controls.Add(this.label8);
            this.Поиск.Location = new System.Drawing.Point(18, 41);
            this.Поиск.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Поиск.Name = "Поиск";
            this.Поиск.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Поиск.Size = new System.Drawing.Size(1008, 123);
            this.Поиск.TabIndex = 19;
            this.Поиск.TabStop = false;
            this.Поиск.Text = "Поиск";
            // 
            // postTextBox
            // 
            this.postTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.postTextBox.Location = new System.Drawing.Point(191, 23);
            this.postTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(204, 22);
            this.postTextBox.TabIndex = 73;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(896, 82);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(112, 41);
            this.searchButton.TabIndex = 30;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "По номеру телефона";
            // 
            // passportTextBox
            // 
            this.passportTextBox.Location = new System.Drawing.Point(191, 59);
            this.passportTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.Size = new System.Drawing.Size(204, 22);
            this.passportTextBox.TabIndex = 22;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(600, 59);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(204, 22);
            this.phoneTextBox.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "По паспорту";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "По ФИО";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(191, 91);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(204, 22);
            this.loginTextBox.TabIndex = 21;
            // 
            // fioTextBox
            // 
            this.fioTextBox.Location = new System.Drawing.Point(600, 26);
            this.fioTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(204, 22);
            this.fioTextBox.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "По должности";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "По логину";
            // 
            // manageSelectedButton
            // 
            this.manageSelectedButton.Location = new System.Drawing.Point(570, 704);
            this.manageSelectedButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manageSelectedButton.Name = "manageSelectedButton";
            this.manageSelectedButton.Size = new System.Drawing.Size(309, 58);
            this.manageSelectedButton.TabIndex = 20;
            this.manageSelectedButton.Text = "Управление выбранным";
            this.manageSelectedButton.UseVisualStyleBackColor = true;
            this.manageSelectedButton.Click += new System.EventHandler(this.ManageSelectedButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.параметрыСортировкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1047, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // параметрыСортировкиToolStripMenuItem
            // 
            this.параметрыСортировкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поФИОToolStripMenuItem,
            this.поДолжностиToolStripMenuItem});
            this.параметрыСортировкиToolStripMenuItem.Name = "параметрыСортировкиToolStripMenuItem";
            this.параметрыСортировкиToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.параметрыСортировкиToolStripMenuItem.Text = "Параметры сортировки";
            // 
            // поФИОToolStripMenuItem
            // 
            this.поФИОToolStripMenuItem.Name = "поФИОToolStripMenuItem";
            this.поФИОToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.поФИОToolStripMenuItem.Text = "По ФИО";
            // 
            // поДолжностиToolStripMenuItem
            // 
            this.поДолжностиToolStripMenuItem.Name = "поДолжностиToolStripMenuItem";
            this.поДолжностиToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.поДолжностиToolStripMenuItem.Text = "По должности";
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 833);
            this.Controls.Add(this.manageSelectedButton);
            this.Controls.Add(this.Поиск);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.newEmployeeButton);
            this.Controls.Add(this.employeesDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Employees";
            this.Text = "Список сотрудников";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            this.Поиск.ResumeLayout(false);
            this.Поиск.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.Button newEmployeeButton;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox Поиск;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passportTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button manageSelectedButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox postTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem параметрыСортировкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поФИОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поДолжностиToolStripMenuItem;
    }
}