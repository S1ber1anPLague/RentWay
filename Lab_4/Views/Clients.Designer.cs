namespace Lab_4.Views
{
    partial class Clients
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
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.newClientButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dealsCountTextBox = new System.Windows.Forms.TextBox();
            this.drivingLicenseTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.passportTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.manageClientButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.параметрыСортировкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поФИОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поДатеРожденияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поКолвуОбращенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клиенты";
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Location = new System.Drawing.Point(3, 176);
            this.clientsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientsDataGridView.MultiSelect = false;
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.RowHeadersVisible = false;
            this.clientsDataGridView.RowHeadersWidth = 51;
            this.clientsDataGridView.RowTemplate.Height = 24;
            this.clientsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsDataGridView.Size = new System.Drawing.Size(1105, 519);
            this.clientsDataGridView.TabIndex = 1;
            this.clientsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsDataGridView_CellContentClick);
            // 
            // newClientButton
            // 
            this.newClientButton.Location = new System.Drawing.Point(234, 699);
            this.newClientButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newClientButton.Name = "newClientButton";
            this.newClientButton.Size = new System.Drawing.Size(309, 58);
            this.newClientButton.TabIndex = 2;
            this.newClientButton.Text = "Добавить клиента";
            this.newClientButton.UseVisualStyleBackColor = true;
            this.newClientButton.Click += new System.EventHandler(this.NewClient_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(991, 2);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(115, 42);
            this.GoBackButton.TabIndex = 3;
            this.GoBackButton.Text = "<<";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 699);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 57);
            this.button1.TabIndex = 15;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(986, 699);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 58);
            this.button2.TabIndex = 16;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dealsCountTextBox);
            this.groupBox1.Controls.Add(this.drivingLicenseTextBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.passportTextBox);
            this.groupBox1.Controls.Add(this.phoneTextBox);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.fioTextBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1091, 124);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 17);
            this.label11.TabIndex = 67;
            this.label11.Text = "Кол-во обращений";
            // 
            // dealsCountTextBox
            // 
            this.dealsCountTextBox.Location = new System.Drawing.Point(231, 81);
            this.dealsCountTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dealsCountTextBox.Name = "dealsCountTextBox";
            this.dealsCountTextBox.Size = new System.Drawing.Size(268, 22);
            this.dealsCountTextBox.TabIndex = 66;
            // 
            // drivingLicenseTextBox
            // 
            this.drivingLicenseTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.drivingLicenseTextBox.Location = new System.Drawing.Point(231, 46);
            this.drivingLicenseTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drivingLicenseTextBox.Name = "drivingLicenseTextBox";
            this.drivingLicenseTextBox.Size = new System.Drawing.Size(268, 22);
            this.drivingLicenseTextBox.TabIndex = 65;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(205, 17);
            this.label12.TabIndex = 64;
            this.label12.Text = "Водительское удостоверение";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(957, 80);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(127, 39);
            this.searchButton.TabIndex = 29;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(524, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "По номеру телефона";
            // 
            // passportTextBox
            // 
            this.passportTextBox.Location = new System.Drawing.Point(231, 14);
            this.passportTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.Size = new System.Drawing.Size(268, 22);
            this.passportTextBox.TabIndex = 21;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(695, 46);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(388, 22);
            this.phoneTextBox.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "По паспорту";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(524, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "По ФИО";
            // 
            // fioTextBox
            // 
            this.fioTextBox.Location = new System.Drawing.Point(695, 10);
            this.fioTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(388, 22);
            this.fioTextBox.TabIndex = 24;
            // 
            // manageClientButton
            // 
            this.manageClientButton.Location = new System.Drawing.Point(564, 699);
            this.manageClientButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manageClientButton.Name = "manageClientButton";
            this.manageClientButton.Size = new System.Drawing.Size(327, 58);
            this.manageClientButton.TabIndex = 18;
            this.manageClientButton.Text = "Управление выбранным";
            this.manageClientButton.UseVisualStyleBackColor = true;
            this.manageClientButton.Click += new System.EventHandler(this.ManageClientButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.параметрыСортировкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1108, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // параметрыСортировкиToolStripMenuItem
            // 
            this.параметрыСортировкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поФИОToolStripMenuItem,
            this.поДатеРожденияToolStripMenuItem,
            this.поКолвуОбращенийToolStripMenuItem});
            this.параметрыСортировкиToolStripMenuItem.Name = "параметрыСортировкиToolStripMenuItem";
            this.параметрыСортировкиToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.параметрыСортировкиToolStripMenuItem.Text = "Параметры сортировки";
            // 
            // поФИОToolStripMenuItem
            // 
            this.поФИОToolStripMenuItem.Name = "поФИОToolStripMenuItem";
            this.поФИОToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.поФИОToolStripMenuItem.Text = "По ФИО";
            // 
            // поДатеРожденияToolStripMenuItem
            // 
            this.поДатеРожденияToolStripMenuItem.Name = "поДатеРожденияToolStripMenuItem";
            this.поДатеРожденияToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.поДатеРожденияToolStripMenuItem.Text = "По дате рождения";
            // 
            // поКолвуОбращенийToolStripMenuItem
            // 
            this.поКолвуОбращенийToolStripMenuItem.Name = "поКолвуОбращенийToolStripMenuItem";
            this.поКолвуОбращенийToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.поКолвуОбращенийToolStripMenuItem.Text = "По кол-ву обращений";
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 762);
            this.Controls.Add(this.manageClientButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.newClientButton);
            this.Controls.Add(this.clientsDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Clients";
            this.Text = "Список клиентов";
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.Button newClientButton;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox passportTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button manageClientButton;
        private System.Windows.Forms.TextBox drivingLicenseTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox dealsCountTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem параметрыСортировкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поФИОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поДатеРожденияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поКолвуОбращенийToolStripMenuItem;
    }
}