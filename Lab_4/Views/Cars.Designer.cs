namespace Lab_4.Views
{
    partial class Cars
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
            this.carsDataGridView = new System.Windows.Forms.DataGridView();
            this.newCarButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.endYearTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.startYearTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.driveTypeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.manageCarButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.isAvailableCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.параметрыСортировкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поМаркеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.годВыпускаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.объемДвигателяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видКузоваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.суммаЗалогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ценаПрокатаЗаОдинДеньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // carsDataGridView
            // 
            this.carsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.carsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.carsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataGridView.Location = new System.Drawing.Point(12, 162);
            this.carsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carsDataGridView.MultiSelect = false;
            this.carsDataGridView.Name = "carsDataGridView";
            this.carsDataGridView.RowHeadersVisible = false;
            this.carsDataGridView.RowHeadersWidth = 51;
            this.carsDataGridView.RowTemplate.Height = 24;
            this.carsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carsDataGridView.Size = new System.Drawing.Size(951, 415);
            this.carsDataGridView.TabIndex = 0;
            // 
            // newCarButton
            // 
            this.newCarButton.Location = new System.Drawing.Point(154, 580);
            this.newCarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newCarButton.Name = "newCarButton";
            this.newCarButton.Size = new System.Drawing.Size(329, 59);
            this.newCarButton.TabIndex = 2;
            this.newCarButton.Text = "Добавить новый автомобиль";
            this.newCarButton.UseVisualStyleBackColor = true;
            this.newCarButton.Click += new System.EventHandler(this.NewCar_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(855, 0);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(111, 37);
            this.GoBackButton.TabIndex = 3;
            this.GoBackButton.Text = "<<";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(822, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "до";
            // 
            // endYearTextBox
            // 
            this.endYearTextBox.Location = new System.Drawing.Point(854, 23);
            this.endYearTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endYearTextBox.Name = "endYearTextBox";
            this.endYearTextBox.Size = new System.Drawing.Size(81, 22);
            this.endYearTextBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(565, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "По году выпуска от";
            // 
            // startYearTextBox
            // 
            this.startYearTextBox.Location = new System.Drawing.Point(729, 23);
            this.startYearTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startYearTextBox.Name = "startYearTextBox";
            this.startYearTextBox.Size = new System.Drawing.Size(87, 22);
            this.startYearTextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "По типу";
            // 
            // driveTypeTextBox
            // 
            this.driveTypeTextBox.Location = new System.Drawing.Point(156, 55);
            this.driveTypeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.driveTypeTextBox.Name = "driveTypeTextBox";
            this.driveTypeTextBox.Size = new System.Drawing.Size(204, 22);
            this.driveTypeTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "По марке";
            // 
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(156, 23);
            this.brandTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(204, 22);
            this.brandTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 581);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 57);
            this.button1.TabIndex = 16;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(854, 580);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 57);
            this.button2.TabIndex = 17;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // manageCarButton
            // 
            this.manageCarButton.Location = new System.Drawing.Point(522, 580);
            this.manageCarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manageCarButton.Name = "manageCarButton";
            this.manageCarButton.Size = new System.Drawing.Size(309, 59);
            this.manageCarButton.TabIndex = 19;
            this.manageCarButton.Text = "Управление выбранным";
            this.manageCarButton.UseVisualStyleBackColor = true;
            this.manageCarButton.Click += new System.EventHandler(this.ManageCarButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(845, 75);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(109, 39);
            this.searchButton.TabIndex = 30;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "По цвету";
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(156, 87);
            this.colorTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(204, 22);
            this.colorTextBox.TabIndex = 31;
            // 
            // isAvailableCheckBox
            // 
            this.isAvailableCheckBox.AutoSize = true;
            this.isAvailableCheckBox.Location = new System.Drawing.Point(729, 58);
            this.isAvailableCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isAvailableCheckBox.Name = "isAvailableCheckBox";
            this.isAvailableCheckBox.Size = new System.Drawing.Size(18, 17);
            this.isAvailableCheckBox.TabIndex = 33;
            this.isAvailableCheckBox.ThreeState = true;
            this.isAvailableCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(565, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "По наличию";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.параметрыСортировкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(971, 28);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // параметрыСортировкиToolStripMenuItem
            // 
            this.параметрыСортировкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поМаркеToolStripMenuItem,
            this.цветToolStripMenuItem,
            this.годВыпускаToolStripMenuItem,
            this.объемДвигателяToolStripMenuItem,
            this.видКузоваToolStripMenuItem,
            this.суммаЗалогаToolStripMenuItem,
            this.ценаПрокатаЗаОдинДеньToolStripMenuItem});
            this.параметрыСортировкиToolStripMenuItem.Name = "параметрыСортировкиToolStripMenuItem";
            this.параметрыСортировкиToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.параметрыСортировкиToolStripMenuItem.Text = "Параметры сортировки";
            // 
            // поМаркеToolStripMenuItem
            // 
            this.поМаркеToolStripMenuItem.Name = "поМаркеToolStripMenuItem";
            this.поМаркеToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.поМаркеToolStripMenuItem.Text = "По марке";
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            this.цветToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.цветToolStripMenuItem.Text = "Цвет";
            // 
            // годВыпускаToolStripMenuItem
            // 
            this.годВыпускаToolStripMenuItem.Name = "годВыпускаToolStripMenuItem";
            this.годВыпускаToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.годВыпускаToolStripMenuItem.Text = "Год выпуска";
            // 
            // объемДвигателяToolStripMenuItem
            // 
            this.объемДвигателяToolStripMenuItem.Name = "объемДвигателяToolStripMenuItem";
            this.объемДвигателяToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.объемДвигателяToolStripMenuItem.Text = "Объем двигателя";
            // 
            // видКузоваToolStripMenuItem
            // 
            this.видКузоваToolStripMenuItem.Name = "видКузоваToolStripMenuItem";
            this.видКузоваToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.видКузоваToolStripMenuItem.Text = "Вид кузова";
            // 
            // суммаЗалогаToolStripMenuItem
            // 
            this.суммаЗалогаToolStripMenuItem.Name = "суммаЗалогаToolStripMenuItem";
            this.суммаЗалогаToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.суммаЗалогаToolStripMenuItem.Text = "Сумма залога";
            // 
            // ценаПрокатаЗаОдинДеньToolStripMenuItem
            // 
            this.ценаПрокатаЗаОдинДеньToolStripMenuItem.Name = "ценаПрокатаЗаОдинДеньToolStripMenuItem";
            this.ценаПрокатаЗаОдинДеньToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.ценаПрокатаЗаОдинДеньToolStripMenuItem.Text = "Цена проката за один день";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.brandTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.isAvailableCheckBox);
            this.groupBox1.Controls.Add(this.driveTypeTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.colorTextBox);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.startYearTextBox);
            this.groupBox1.Controls.Add(this.endYearTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(951, 115);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 650);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.carsDataGridView);
            this.Controls.Add(this.manageCarButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.newCarButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cars";
            this.Text = "Список автомобилей";
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView carsDataGridView;
        private System.Windows.Forms.Button newCarButton;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox startYearTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox driveTypeTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox endYearTextBox;
        private System.Windows.Forms.Button manageCarButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.CheckBox isAvailableCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem параметрыСортировкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поМаркеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem годВыпускаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem объемДвигателяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видКузоваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem суммаЗалогаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ценаПрокатаЗаОдинДеньToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}