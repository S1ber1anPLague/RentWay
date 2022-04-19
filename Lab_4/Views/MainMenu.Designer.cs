namespace Lab_4.Views
{
    partial class MainMenu
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
            this.RentOrdering = new System.Windows.Forms.Button();
            this.CarList = new System.Windows.Forms.Button();
            this.ClientList = new System.Windows.Forms.Button();
            this.ServiceList = new System.Windows.Forms.Button();
            this.EmployeeList = new System.Windows.Forms.Button();
            this.RentList = new System.Windows.Forms.Button();
            this.carBrandsButton = new System.Windows.Forms.Button();
            this.carBodyTypesButton = new System.Windows.Forms.Button();
            this.summariesBtn = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RentOrdering
            // 
            this.RentOrdering.Location = new System.Drawing.Point(467, 39);
            this.RentOrdering.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RentOrdering.Name = "RentOrdering";
            this.RentOrdering.Size = new System.Drawing.Size(196, 53);
            this.RentOrdering.TabIndex = 1;
            this.RentOrdering.Text = "Оформить договор";
            this.RentOrdering.UseVisualStyleBackColor = true;
            this.RentOrdering.Click += new System.EventHandler(this.RentOrdering_Click);
            // 
            // CarList
            // 
            this.CarList.Location = new System.Drawing.Point(237, 39);
            this.CarList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CarList.Name = "CarList";
            this.CarList.Size = new System.Drawing.Size(196, 53);
            this.CarList.TabIndex = 2;
            this.CarList.Text = "Список автомобилей";
            this.CarList.UseVisualStyleBackColor = true;
            this.CarList.Click += new System.EventHandler(this.CarList_Click);
            // 
            // ClientList
            // 
            this.ClientList.Location = new System.Drawing.Point(12, 96);
            this.ClientList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientList.Name = "ClientList";
            this.ClientList.Size = new System.Drawing.Size(196, 37);
            this.ClientList.TabIndex = 3;
            this.ClientList.Text = "Список клиентов";
            this.ClientList.UseVisualStyleBackColor = true;
            this.ClientList.Click += new System.EventHandler(this.ClientList_Click);
            // 
            // ServiceList
            // 
            this.ServiceList.Location = new System.Drawing.Point(237, 96);
            this.ServiceList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ServiceList.Name = "ServiceList";
            this.ServiceList.Size = new System.Drawing.Size(196, 36);
            this.ServiceList.TabIndex = 4;
            this.ServiceList.Text = "Список доп.услуг";
            this.ServiceList.UseVisualStyleBackColor = true;
            this.ServiceList.Click += new System.EventHandler(this.ServiceList_Click);
            // 
            // EmployeeList
            // 
            this.EmployeeList.Location = new System.Drawing.Point(698, 97);
            this.EmployeeList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.Size = new System.Drawing.Size(196, 36);
            this.EmployeeList.TabIndex = 5;
            this.EmployeeList.Text = "Список сотрудников";
            this.EmployeeList.UseVisualStyleBackColor = true;
            this.EmployeeList.Click += new System.EventHandler(this.EmployeeList_Click);
            // 
            // RentList
            // 
            this.RentList.Location = new System.Drawing.Point(467, 96);
            this.RentList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RentList.Name = "RentList";
            this.RentList.Size = new System.Drawing.Size(196, 37);
            this.RentList.TabIndex = 6;
            this.RentList.Text = "Список текущих аренд";
            this.RentList.UseVisualStyleBackColor = true;
            this.RentList.Click += new System.EventHandler(this.RentList_Click);
            // 
            // carBrandsButton
            // 
            this.carBrandsButton.Location = new System.Drawing.Point(12, 39);
            this.carBrandsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carBrandsButton.Name = "carBrandsButton";
            this.carBrandsButton.Size = new System.Drawing.Size(196, 53);
            this.carBrandsButton.TabIndex = 8;
            this.carBrandsButton.Text = "Список марок автомобилей";
            this.carBrandsButton.UseVisualStyleBackColor = true;
            this.carBrandsButton.Click += new System.EventHandler(this.CarBrandsButton_Click);
            // 
            // carBodyTypesButton
            // 
            this.carBodyTypesButton.Location = new System.Drawing.Point(698, 39);
            this.carBodyTypesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carBodyTypesButton.Name = "carBodyTypesButton";
            this.carBodyTypesButton.Size = new System.Drawing.Size(196, 53);
            this.carBodyTypesButton.TabIndex = 9;
            this.carBodyTypesButton.Text = "Список типов автомобилей";
            this.carBodyTypesButton.UseVisualStyleBackColor = true;
            this.carBodyTypesButton.Click += new System.EventHandler(this.CarBodyTypesButton_Click);
            // 
            // summariesBtn
            // 
            this.summariesBtn.Location = new System.Drawing.Point(178, 148);
            this.summariesBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.summariesBtn.Name = "summariesBtn";
            this.summariesBtn.Size = new System.Drawing.Size(196, 37);
            this.summariesBtn.TabIndex = 10;
            this.summariesBtn.Text = "Сводки";
            this.summariesBtn.UseVisualStyleBackColor = true;
            this.summariesBtn.Click += new System.EventHandler(this.SummariesBtn_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(537, 148);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(196, 37);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "Выход";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 196);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.summariesBtn);
            this.Controls.Add(this.carBodyTypesButton);
            this.Controls.Add(this.carBrandsButton);
            this.Controls.Add(this.RentList);
            this.Controls.Add(this.EmployeeList);
            this.Controls.Add(this.ServiceList);
            this.Controls.Add(this.ClientList);
            this.Controls.Add(this.CarList);
            this.Controls.Add(this.RentOrdering);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RentOrdering;
        private System.Windows.Forms.Button CarList;
        private System.Windows.Forms.Button ClientList;
        private System.Windows.Forms.Button ServiceList;
        private System.Windows.Forms.Button EmployeeList;
        private System.Windows.Forms.Button RentList;
        private System.Windows.Forms.Button carBrandsButton;
        private System.Windows.Forms.Button carBodyTypesButton;
        private System.Windows.Forms.Button summariesBtn;
        private System.Windows.Forms.Button closeButton;
    }
}