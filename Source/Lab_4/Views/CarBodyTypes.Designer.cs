
namespace Lab_4.Views
{
    partial class CarBodyTypes
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
            this.label2 = new System.Windows.Forms.Label();
            this.delButton = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.bodyTypeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.carBodyTypesComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Тип автомобиля";
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(654, 131);
            this.delButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(152, 47);
            this.delButton.TabIndex = 12;
            this.delButton.Text = "Удалить";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(474, 131);
            this.editBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(152, 47);
            this.editBtn.TabIndex = 11;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(291, 131);
            this.createButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(152, 47);
            this.createButton.TabIndex = 10;
            this.createButton.Text = "Добавить";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // bodyTypeTextBox
            // 
            this.bodyTypeTextBox.Location = new System.Drawing.Point(171, 70);
            this.bodyTypeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bodyTypeTextBox.Name = "bodyTypeTextBox";
            this.bodyTypeTextBox.Size = new System.Drawing.Size(828, 22);
            this.bodyTypeTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Список типов";
            // 
            // carBodyTypesComboBox
            // 
            this.carBodyTypesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carBodyTypesComboBox.FormattingEnabled = true;
            this.carBodyTypesComboBox.Location = new System.Drawing.Point(171, 15);
            this.carBodyTypesComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carBodyTypesComboBox.Name = "carBodyTypesComboBox";
            this.carBodyTypesComboBox.Size = new System.Drawing.Size(828, 24);
            this.carBodyTypesComboBox.TabIndex = 7;
            this.carBodyTypesComboBox.SelectedIndexChanged += new System.EventHandler(this.CarBodyTypesComboBox_SelectedIndexChanged);
            // 
            // CarBodyTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 191);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.bodyTypeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carBodyTypesComboBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CarBodyTypes";
            this.Text = "Типы автомобилей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox bodyTypeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox carBodyTypesComboBox;
    }
}