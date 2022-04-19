
namespace Lab_4.Views
{
    partial class ReceptionDialog
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
            this.damageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.conclusionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clientTextBox = new System.Windows.Forms.TextBox();
            this.closeRentButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.carTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Урон";
            // 
            // damageTextBox
            // 
            this.damageTextBox.Location = new System.Drawing.Point(168, 137);
            this.damageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.damageTextBox.Name = "damageTextBox";
            this.damageTextBox.Size = new System.Drawing.Size(707, 22);
            this.damageTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Заключение";
            // 
            // conclusionTextBox
            // 
            this.conclusionTextBox.Location = new System.Drawing.Point(168, 191);
            this.conclusionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.conclusionTextBox.Multiline = true;
            this.conclusionTextBox.Name = "conclusionTextBox";
            this.conclusionTextBox.Size = new System.Drawing.Size(707, 144);
            this.conclusionTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Клиент";
            // 
            // clientTextBox
            // 
            this.clientTextBox.Location = new System.Drawing.Point(168, 84);
            this.clientTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.clientTextBox.Name = "clientTextBox";
            this.clientTextBox.ReadOnly = true;
            this.clientTextBox.Size = new System.Drawing.Size(707, 22);
            this.clientTextBox.TabIndex = 6;
            // 
            // closeRentButton
            // 
            this.closeRentButton.Location = new System.Drawing.Point(366, 343);
            this.closeRentButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeRentButton.Name = "closeRentButton";
            this.closeRentButton.Size = new System.Drawing.Size(296, 59);
            this.closeRentButton.TabIndex = 7;
            this.closeRentButton.Text = "Закрыть аренду";
            this.closeRentButton.UseVisualStyleBackColor = true;
            this.closeRentButton.Click += new System.EventHandler(this.CloseRentButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Машина";
            // 
            // carTextBox
            // 
            this.carTextBox.Location = new System.Drawing.Point(168, 38);
            this.carTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.carTextBox.Name = "carTextBox";
            this.carTextBox.ReadOnly = true;
            this.carTextBox.Size = new System.Drawing.Size(707, 22);
            this.carTextBox.TabIndex = 9;
            // 
            // ReceptionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 438);
            this.Controls.Add(this.carTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.closeRentButton);
            this.Controls.Add(this.clientTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.conclusionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.damageTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReceptionDialog";
            this.Text = "Заключение ";
            this.Load += new System.EventHandler(this.ReceptionDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox damageTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox conclusionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clientTextBox;
        private System.Windows.Forms.Button closeRentButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox carTextBox;
    }
}