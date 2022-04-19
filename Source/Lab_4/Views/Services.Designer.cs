namespace Lab_4.Views
{
    partial class Services
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
            this.servicesDataGridView = new System.Windows.Forms.DataGridView();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.newServiceButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.manageSelectedButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // servicesDataGridView
            // 
            this.servicesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.servicesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.servicesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.servicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesDataGridView.Location = new System.Drawing.Point(7, 81);
            this.servicesDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.servicesDataGridView.MultiSelect = false;
            this.servicesDataGridView.Name = "servicesDataGridView";
            this.servicesDataGridView.ReadOnly = true;
            this.servicesDataGridView.RowHeadersVisible = false;
            this.servicesDataGridView.RowHeadersWidth = 51;
            this.servicesDataGridView.RowTemplate.Height = 24;
            this.servicesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.servicesDataGridView.Size = new System.Drawing.Size(915, 514);
            this.servicesDataGridView.TabIndex = 1;
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(832, 2);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(104, 40);
            this.GoBackButton.TabIndex = 2;
            this.GoBackButton.Text = "<<";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // newServiceButton
            // 
            this.newServiceButton.Location = new System.Drawing.Point(144, 599);
            this.newServiceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newServiceButton.Name = "newServiceButton";
            this.newServiceButton.Size = new System.Drawing.Size(309, 50);
            this.newServiceButton.TabIndex = 3;
            this.newServiceButton.Text = "Добавить дополнительную услугу";
            this.newServiceButton.UseVisualStyleBackColor = true;
            this.newServiceButton.Click += new System.EventHandler(this.NewService_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Поиск по названию";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(165, 34);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(207, 22);
            this.nameTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 599);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 50);
            this.button1.TabIndex = 15;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(803, 599);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 50);
            this.button2.TabIndex = 16;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // manageSelectedButton
            // 
            this.manageSelectedButton.Location = new System.Drawing.Point(474, 599);
            this.manageSelectedButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manageSelectedButton.Name = "manageSelectedButton";
            this.manageSelectedButton.Size = new System.Drawing.Size(309, 50);
            this.manageSelectedButton.TabIndex = 21;
            this.manageSelectedButton.Text = "Управление выбранным";
            this.manageSelectedButton.UseVisualStyleBackColor = true;
            this.manageSelectedButton.Click += new System.EventHandler(this.ManageSelectedButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(413, 32);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 28);
            this.searchButton.TabIndex = 31;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 653);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.manageSelectedButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newServiceButton);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.servicesDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Services";
            this.Text = "Список дополнительных услуг";
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView servicesDataGridView;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button newServiceButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button manageSelectedButton;
        private System.Windows.Forms.Button searchButton;
    }
}