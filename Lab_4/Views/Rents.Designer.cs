namespace Lab_4.Views
{
    partial class Rents
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
            this.rentsDataGridView = new System.Windows.Forms.DataGridView();
            this.NewRent = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Поиск = new System.Windows.Forms.GroupBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.clientTextBox = new System.Windows.Forms.TextBox();
            this.employeeTextBox = new System.Windows.Forms.TextBox();
            this.endDateTextBox = new System.Windows.Forms.TextBox();
            this.startDateTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.periodTextBox = new System.Windows.Forms.TextBox();
            this.manageSelectedButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.параметрыСортировкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поФИОКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЦенеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.isOpenCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.rentsDataGridView)).BeginInit();
            this.Поиск.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rentsDataGridView
            // 
            this.rentsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rentsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.rentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentsDataGridView.Location = new System.Drawing.Point(7, 171);
            this.rentsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rentsDataGridView.Name = "rentsDataGridView";
            this.rentsDataGridView.ReadOnly = true;
            this.rentsDataGridView.RowHeadersVisible = false;
            this.rentsDataGridView.RowHeadersWidth = 51;
            this.rentsDataGridView.RowTemplate.Height = 24;
            this.rentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rentsDataGridView.Size = new System.Drawing.Size(951, 428);
            this.rentsDataGridView.TabIndex = 0;
            // 
            // NewRent
            // 
            this.NewRent.Location = new System.Drawing.Point(149, 603);
            this.NewRent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewRent.Name = "NewRent";
            this.NewRent.Size = new System.Drawing.Size(293, 46);
            this.NewRent.TabIndex = 1;
            this.NewRent.Text = "Добавить аренду";
            this.NewRent.UseVisualStyleBackColor = true;
            this.NewRent.Click += new System.EventHandler(this.NewRent_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(879, 1);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(84, 38);
            this.GoBackButton.TabIndex = 2;
            this.GoBackButton.Text = "<<";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 603);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 46);
            this.button1.TabIndex = 14;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(868, 602);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 46);
            this.button2.TabIndex = 15;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Поиск
            // 
            this.Поиск.Controls.Add(this.label4);
            this.Поиск.Controls.Add(this.isOpenCheckBox);
            this.Поиск.Controls.Add(this.brandTextBox);
            this.Поиск.Controls.Add(this.clientTextBox);
            this.Поиск.Controls.Add(this.employeeTextBox);
            this.Поиск.Controls.Add(this.endDateTextBox);
            this.Поиск.Controls.Add(this.startDateTextBox);
            this.Поиск.Controls.Add(this.label16);
            this.Поиск.Controls.Add(this.label20);
            this.Поиск.Controls.Add(this.label19);
            this.Поиск.Controls.Add(this.numberTextBox);
            this.Поиск.Controls.Add(this.label18);
            this.Поиск.Controls.Add(this.searchButton);
            this.Поиск.Controls.Add(this.label17);
            this.Поиск.Controls.Add(this.label15);
            this.Поиск.Controls.Add(this.label14);
            this.Поиск.Controls.Add(this.periodTextBox);
            this.Поиск.Location = new System.Drawing.Point(7, 42);
            this.Поиск.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Поиск.Name = "Поиск";
            this.Поиск.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Поиск.Size = new System.Drawing.Size(947, 125);
            this.Поиск.TabIndex = 30;
            this.Поиск.TabStop = false;
            this.Поиск.Text = "Поиск";
            // 
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(501, 73);
            this.brandTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(194, 22);
            this.brandTextBox.TabIndex = 50;
            // 
            // clientTextBox
            // 
            this.clientTextBox.Location = new System.Drawing.Point(501, 46);
            this.clientTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientTextBox.Name = "clientTextBox";
            this.clientTextBox.Size = new System.Drawing.Size(194, 22);
            this.clientTextBox.TabIndex = 49;
            // 
            // employeeTextBox
            // 
            this.employeeTextBox.Location = new System.Drawing.Point(501, 20);
            this.employeeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.employeeTextBox.Name = "employeeTextBox";
            this.employeeTextBox.Size = new System.Drawing.Size(194, 22);
            this.employeeTextBox.TabIndex = 48;
            // 
            // endDateTextBox
            // 
            this.endDateTextBox.Location = new System.Drawing.Point(98, 70);
            this.endDateTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.endDateTextBox.Name = "endDateTextBox";
            this.endDateTextBox.Size = new System.Drawing.Size(194, 22);
            this.endDateTextBox.TabIndex = 47;
            // 
            // startDateTextBox
            // 
            this.startDateTextBox.Location = new System.Drawing.Point(98, 46);
            this.startDateTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startDateTextBox.Name = "startDateTextBox";
            this.startDateTextBox.Size = new System.Drawing.Size(194, 22);
            this.startDateTextBox.TabIndex = 46;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(318, 23);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "По сотруднику (фамилия)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 23);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 13);
            this.label20.TabIndex = 31;
            this.label20.Text = "По номеру";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(318, 76);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(137, 13);
            this.label19.TabIndex = 35;
            this.label19.Text = "По автомобилю (марка)";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(98, 20);
            this.numberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(194, 22);
            this.numberTextBox.TabIndex = 32;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 70);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(22, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "До";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(866, 90);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(82, 35);
            this.searchButton.TabIndex = 45;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 50);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "От";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(318, 49);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "По клиенту (фамилия)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 99);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "По сроку";
            // 
            // periodTextBox
            // 
            this.periodTextBox.Location = new System.Drawing.Point(98, 96);
            this.periodTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.periodTextBox.Name = "periodTextBox";
            this.periodTextBox.Size = new System.Drawing.Size(194, 22);
            this.periodTextBox.TabIndex = 39;
            // 
            // manageSelectedButton
            // 
            this.manageSelectedButton.Location = new System.Drawing.Point(508, 602);
            this.manageSelectedButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manageSelectedButton.Name = "manageSelectedButton";
            this.manageSelectedButton.Size = new System.Drawing.Size(314, 46);
            this.manageSelectedButton.TabIndex = 46;
            this.manageSelectedButton.Text = "Управление выбранной";
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(963, 24);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // параметрыСортировкиToolStripMenuItem
            // 
            this.параметрыСортировкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поФИОКлиентаToolStripMenuItem,
            this.поЦенеToolStripMenuItem});
            this.параметрыСортировкиToolStripMenuItem.Name = "параметрыСортировкиToolStripMenuItem";
            this.параметрыСортировкиToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.параметрыСортировкиToolStripMenuItem.Text = "Параметры сортировки";
            // 
            // поФИОКлиентаToolStripMenuItem
            // 
            this.поФИОКлиентаToolStripMenuItem.Name = "поФИОКлиентаToolStripMenuItem";
            this.поФИОКлиентаToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.поФИОКлиентаToolStripMenuItem.Text = "По ФИО клиента";
            // 
            // поЦенеToolStripMenuItem
            // 
            this.поЦенеToolStripMenuItem.Name = "поЦенеToolStripMenuItem";
            this.поЦенеToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.поЦенеToolStripMenuItem.Text = "По цене";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "По статусу (Галочка - открыт)";
            // 
            // isOpenCheckBox
            // 
            this.isOpenCheckBox.AutoSize = true;
            this.isOpenCheckBox.Location = new System.Drawing.Point(501, 104);
            this.isOpenCheckBox.Name = "isOpenCheckBox";
            this.isOpenCheckBox.Size = new System.Drawing.Size(15, 14);
            this.isOpenCheckBox.TabIndex = 51;
            this.isOpenCheckBox.ThreeState = true;
            this.isOpenCheckBox.UseVisualStyleBackColor = true;
            // 
            // Rents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 570);
            this.Controls.Add(this.manageSelectedButton);
            this.Controls.Add(this.Поиск);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.NewRent);
            this.Controls.Add(this.rentsDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Rents";
            this.Text = "Список аренд";
            this.Load += new System.EventHandler(this.Rents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentsDataGridView)).EndInit();
            this.Поиск.ResumeLayout(false);
            this.Поиск.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView rentsDataGridView;
        private System.Windows.Forms.Button NewRent;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox Поиск;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox periodTextBox;
        private System.Windows.Forms.Button manageSelectedButton;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.TextBox clientTextBox;
        private System.Windows.Forms.TextBox employeeTextBox;
        private System.Windows.Forms.TextBox endDateTextBox;
        private System.Windows.Forms.TextBox startDateTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem параметрыСортировкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поФИОКлиентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поЦенеToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox isOpenCheckBox;
    }
}