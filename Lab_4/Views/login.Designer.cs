namespace Lab_4.Views
{
    partial class LoginForm
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
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            this.PassButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(173, 81);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(189, 22);
            this.loginTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(173, 129);
            this.passBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(189, 22);
            this.passBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите пароль";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(173, 174);
            this.GoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(131, 43);
            this.GoButton.TabIndex = 5;
            this.GoButton.Text = "Вход";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // PassButton
            // 
            this.PassButton.Location = new System.Drawing.Point(368, 129);
            this.PassButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PassButton.Name = "PassButton";
            this.PassButton.Size = new System.Drawing.Size(93, 27);
            this.PassButton.TabIndex = 7;
            this.PassButton.Text = "Просмотр";
            this.PassButton.UseVisualStyleBackColor = true;
            this.PassButton.Click += new System.EventHandler(this.PassButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 228);
            this.Controls.Add(this.PassButton);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Button PassButton;
    }
}