
namespace GMS
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            panel1 = new System.Windows.Forms.Panel();
            LoginButton = new System.Windows.Forms.Button();
            PasswordTextBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            UserNameTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            CloseApp = new System.Windows.Forms.PictureBox();
            MinimizeApp = new System.Windows.Forms.PictureBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CloseApp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeApp).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(251, 107, 91);
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(PasswordTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(UserNameTextBox);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(126, 164);
            panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(506, 348);
            panel1.TabIndex = 0;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = System.Drawing.Color.Black;
            LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            LoginButton.ForeColor = System.Drawing.Color.FromArgb(251, 107, 91);
            LoginButton.Location = new System.Drawing.Point(216, 252);
            LoginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new System.Drawing.Size(94, 42);
            LoginButton.TabIndex = 60;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PasswordTextBox.Location = new System.Drawing.Point(240, 166);
            PasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new System.Drawing.Size(165, 29);
            PasswordTextBox.TabIndex = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Bebas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(94, 169);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 23);
            label2.TabIndex = 58;
            label2.Text = "Password:";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            UserNameTextBox.Location = new System.Drawing.Point(240, 80);
            UserNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new System.Drawing.Size(165, 29);
            UserNameTextBox.TabIndex = 57;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Bebas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(94, 83);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 23);
            label1.TabIndex = 56;
            label1.Text = "Username:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Bebas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label16.Location = new System.Drawing.Point(276, 122);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(187, 29);
            label16.TabIndex = 54;
            label16.Text = "Management System";
            // 
            // CloseApp
            // 
            CloseApp.Image = (System.Drawing.Image)resources.GetObject("CloseApp.Image");
            CloseApp.Location = new System.Drawing.Point(725, 6);
            CloseApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            CloseApp.Name = "CloseApp";
            CloseApp.Size = new System.Drawing.Size(30, 30);
            CloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            CloseApp.TabIndex = 55;
            CloseApp.TabStop = false;
            CloseApp.Click += CloseApp_Click;
            // 
            // MinimizeApp
            // 
            MinimizeApp.Image = (System.Drawing.Image)resources.GetObject("MinimizeApp.Image");
            MinimizeApp.Location = new System.Drawing.Point(678, 6);
            MinimizeApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MinimizeApp.Name = "MinimizeApp";
            MinimizeApp.Size = new System.Drawing.Size(30, 30);
            MinimizeApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            MinimizeApp.TabIndex = 55;
            MinimizeApp.TabStop = false;
            MinimizeApp.Click += MinimizeApp_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Bebas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(293, 80);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(159, 42);
            label3.TabIndex = 54;
            label3.Text = "Gymnasium";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Bebas", 47.9999924F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(291, 9);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(168, 77);
            label4.TabIndex = 54;
            label4.Text = "BUETK";
            // 
            // LoginPage
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.DimGray;
            ClientSize = new System.Drawing.Size(762, 540);
            Controls.Add(MinimizeApp);
            Controls.Add(CloseApp);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label16);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.Color.Transparent;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "LoginPage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "GYM Matrix";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CloseApp).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeApp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox CloseApp;
        private System.Windows.Forms.PictureBox MinimizeApp;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}