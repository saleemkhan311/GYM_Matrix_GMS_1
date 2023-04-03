
namespace GYM_Matrix
{
    partial class UserPanel
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
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.Close_Admin_Panel = new System.Windows.Forms.PictureBox();
            this.UsersDataTable = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label41 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.ConfirmPassBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RefereshButton = new System.Windows.Forms.Button();
            this.AdminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Admin_Panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataTable)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminPanel
            // 
            this.AdminPanel.BackColor = System.Drawing.Color.White;
            this.AdminPanel.Controls.Add(this.Close_Admin_Panel);
            this.AdminPanel.Controls.Add(this.UsersDataTable);
            this.AdminPanel.Controls.Add(this.panel5);
            this.AdminPanel.Controls.Add(this.label1);
            this.AdminPanel.Controls.Add(this.RefereshButton);
            this.AdminPanel.Font = new System.Drawing.Font("Bebas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdminPanel.Location = new System.Drawing.Point(44, 50);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(1050, 700);
            this.AdminPanel.TabIndex = 30;
            // 
            // Close_Admin_Panel
            // 
            this.Close_Admin_Panel.Image = global::GYM_Matrix.Properties.Resources.close_icon_png_19;
            this.Close_Admin_Panel.Location = new System.Drawing.Point(1018, 5);
            this.Close_Admin_Panel.Name = "Close_Admin_Panel";
            this.Close_Admin_Panel.Size = new System.Drawing.Size(27, 33);
            this.Close_Admin_Panel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_Admin_Panel.TabIndex = 58;
            this.Close_Admin_Panel.TabStop = false;
            this.Close_Admin_Panel.Click += new System.EventHandler(this.Close_click);
            // 
            // UsersDataTable
            // 
            this.UsersDataTable.AllowUserToAddRows = false;
            this.UsersDataTable.AllowUserToDeleteRows = false;
            this.UsersDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataTable.Location = new System.Drawing.Point(514, 75);
            this.UsersDataTable.Name = "UsersDataTable";
            this.UsersDataTable.ReadOnly = true;
            this.UsersDataTable.RowHeadersWidth = 51;
            this.UsersDataTable.RowTemplate.Height = 29;
            this.UsersDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersDataTable.Size = new System.Drawing.Size(500, 297);
            this.UsersDataTable.TabIndex = 57;
            this.UsersDataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewUserDataTable);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(107)))), ((int)(((byte)(91)))));
            this.panel5.Controls.Add(this.label41);
            this.panel5.Controls.Add(this.label33);
            this.panel5.Controls.Add(this.label30);
            this.panel5.Controls.Add(this.ConfirmPassBox);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.PasswordBox);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.EmailBox);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.label29);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.IDBox);
            this.panel5.Controls.Add(this.label40);
            this.panel5.Controls.Add(this.NameBox);
            this.panel5.Location = new System.Drawing.Point(56, 75);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(400, 531);
            this.panel5.TabIndex = 56;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label41.Location = new System.Drawing.Point(19, 407);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(153, 24);
            this.label41.TabIndex = 53;
            this.label41.Text = "Confirm Password: ";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label33.Location = new System.Drawing.Point(19, 328);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(90, 24);
            this.label33.TabIndex = 53;
            this.label33.Text = "Password: ";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label30.Location = new System.Drawing.Point(19, 247);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(93, 24);
            this.label30.TabIndex = 53;
            this.label30.Text = "UserEmail: ";
            // 
            // ConfirmPassBox
            // 
            this.ConfirmPassBox.Location = new System.Drawing.Point(174, 406);
            this.ConfirmPassBox.Name = "ConfirmPassBox";
            this.ConfirmPassBox.PasswordChar = '*';
            this.ConfirmPassBox.Size = new System.Drawing.Size(201, 25);
            this.ConfirmPassBox.TabIndex = 54;
            this.ConfirmPassBox.Leave += new System.EventHandler(this.ConfirmPassBox_Leave);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(107)))), ((int)(((byte)(91)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bebas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(307, 469);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 49);
            this.button4.TabIndex = 48;
            this.button4.Text = "Cancle";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.CancleButton);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(158, 327);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(201, 25);
            this.PasswordBox.TabIndex = 54;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(107)))), ((int)(((byte)(91)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bebas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(208, 469);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 49);
            this.button3.TabIndex = 47;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.RemoveButton);
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(158, 246);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(201, 25);
            this.EmailBox.TabIndex = 54;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(107)))), ((int)(((byte)(91)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bebas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(110, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 48);
            this.button2.TabIndex = 46;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.UpdateButton);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label29.Location = new System.Drawing.Point(19, 24);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(28, 24);
            this.label29.TabIndex = 51;
            this.label29.Text = "ID:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(107)))), ((int)(((byte)(91)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bebas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 49);
            this.button1.TabIndex = 45;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.SaveButton);
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(49, 22);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(110, 25);
            this.IDBox.TabIndex = 52;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label40.Location = new System.Drawing.Point(19, 160);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(90, 24);
            this.label40.TabIndex = 21;
            this.label40.Text = "UserName: ";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(158, 159);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(201, 25);
            this.NameBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(529, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Users of the GYM Matrix Management System";
            // 
            // RefereshButton
            // 
            this.RefereshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(107)))), ((int)(((byte)(91)))));
            this.RefereshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefereshButton.Font = new System.Drawing.Font("Bebas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RefereshButton.Location = new System.Drawing.Point(933, 378);
            this.RefereshButton.Name = "RefereshButton";
            this.RefereshButton.Size = new System.Drawing.Size(82, 33);
            this.RefereshButton.TabIndex = 48;
            this.RefereshButton.Text = "Refresh";
            this.RefereshButton.UseVisualStyleBackColor = false;
            this.RefereshButton.Click += new System.EventHandler(this.RefreshButton);
            // 
            // UserPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1138, 800);
            this.Controls.Add(this.AdminPanel);
            this.Font = new System.Drawing.Font("Bebas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserPanel";
            this.AdminPanel.ResumeLayout(false);
            this.AdminPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Admin_Panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataTable)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AdminPanel;
        private System.Windows.Forms.PictureBox Close_Admin_Panel;
        private System.Windows.Forms.DataGridView UsersDataTable;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox ConfirmPassBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RefereshButton;
    }
}