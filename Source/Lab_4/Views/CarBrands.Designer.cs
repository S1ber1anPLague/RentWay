
namespace Lab_4.Views
{
    partial class CarBrands
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
            this.carBrandsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.markTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // carBrandsComboBox
            // 
            this.carBrandsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carBrandsComboBox.FormattingEnabled = true;
            this.carBrandsComboBox.Location = new System.Drawing.Point(167, 34);
            this.carBrandsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.carBrandsComboBox.Name = "carBrandsComboBox";
            this.carBrandsComboBox.Size = new System.Drawing.Size(828, 24);
            this.carBrandsComboBox.TabIndex = 0;
            this.carBrandsComboBox.SelectedIndexChanged += new System.EventHandler(this.CarBrandsComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список марок";
            // 
            // markTextBox
            // 
            this.markTextBox.Location = new System.Drawing.Point(167, 90);
            this.markTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.markTextBox.Name = "markTextBox";
            this.markTextBox.Size = new System.Drawing.Size(828, 22);
            this.markTextBox.TabIndex = 2;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(283, 146);
            this.createButton.Margin = new System.Windows.Forms.Padding(4);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(152, 53);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Добавить";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(466, 146);
            this.editBtn.Margin = new System.Windows.Forms.Padding(4);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(152, 53);
            this.editBtn.TabIndex = 4;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(646, 146);
            this.delButton.Margin = new System.Windows.Forms.Padding(4);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(152, 53);
            this.delButton.TabIndex = 5;
            this.delButton.Text = "Удалить";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Марка";
            // 
            // CarBrands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 212);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.markTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carBrandsComboBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CarBrands";
            this.Text = "Марки автомобилей";
            this.Load += new System.EventHandler(this.CarBrands_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox carBrandsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox markTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Label label2;
    }
}