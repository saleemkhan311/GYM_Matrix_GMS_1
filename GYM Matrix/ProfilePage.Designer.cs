
namespace GYM_Matrix
{
    partial class ProfilePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilePage));
            this.PicturePanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.StartCamera = new System.Windows.Forms.Button();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CamBox = new System.Windows.Forms.PictureBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SavePicBtton = new System.Windows.Forms.Button();
            this.CloseButon = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PicturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CamBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButon)).BeginInit();
            this.SuspendLayout();
            // 
            // PicturePanel
            // 
            this.PicturePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicturePanel.Controls.Add(this.comboBox1);
            this.PicturePanel.Controls.Add(this.StartCamera);
            this.PicturePanel.Controls.Add(this.PicBox);
            this.PicturePanel.Controls.Add(this.label27);
            this.PicturePanel.Controls.Add(this.label25);
            this.PicturePanel.Controls.Add(this.label9);
            this.PicturePanel.Controls.Add(this.CamBox);
            this.PicturePanel.Controls.Add(this.button8);
            this.PicturePanel.Controls.Add(this.button6);
            this.PicturePanel.Controls.Add(this.SavePicBtton);
            this.PicturePanel.Location = new System.Drawing.Point(106, 70);
            this.PicturePanel.Name = "PicturePanel";
            this.PicturePanel.Size = new System.Drawing.Size(720, 463);
            this.PicturePanel.TabIndex = 56;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(18, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 26);
            this.comboBox1.TabIndex = 59;
            // 
            // StartCamera
            // 
            this.StartCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(107)))), ((int)(((byte)(91)))));
            this.StartCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartCamera.Font = new System.Drawing.Font("Bebas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartCamera.Location = new System.Drawing.Point(592, 390);
            this.StartCamera.Name = "StartCamera";
            this.StartCamera.Size = new System.Drawing.Size(94, 49);
            this.StartCamera.TabIndex = 58;
            this.StartCamera.Text = "StartCam";
            this.StartCamera.UseVisualStyleBackColor = false;
            this.StartCamera.Click += new System.EventHandler(this.StartCamera_Click);
            // 
            // PicBox
            // 
            this.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBox.Location = new System.Drawing.Point(290, 87);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(271, 272);
            this.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBox.TabIndex = 0;
            this.PicBox.TabStop = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Bebas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label27.Location = new System.Drawing.Point(403, 362);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(49, 18);
            this.label27.TabIndex = 50;
            this.label27.Text = "Picture";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Bebas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(121, 362);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(48, 18);
            this.label25.TabIndex = 50;
            this.label25.Text = "Camera";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bebas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(17, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 18);
            this.label9.TabIndex = 50;
            this.label9.Text = "Select Camera Device";
            // 
            // CamBox
            // 
            this.CamBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CamBox.Location = new System.Drawing.Point(18, 87);
            this.CamBox.Name = "CamBox";
            this.CamBox.Size = new System.Drawing.Size(266, 272);
            this.CamBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CamBox.TabIndex = 0;
            this.CamBox.TabStop = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(107)))), ((int)(((byte)(91)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Bebas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(592, 282);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 49);
            this.button8.TabIndex = 57;
            this.button8.Text = "Browse";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.BrowseButon);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(107)))), ((int)(((byte)(91)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Bebas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(592, 177);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 49);
            this.button6.TabIndex = 57;
            this.button6.Text = "Capture";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.CaptureButton);
            // 
            // SavePicBtton
            // 
            this.SavePicBtton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(107)))), ((int)(((byte)(91)))));
            this.SavePicBtton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavePicBtton.Font = new System.Drawing.Font("Bebas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SavePicBtton.Location = new System.Drawing.Point(592, 75);
            this.SavePicBtton.Name = "SavePicBtton";
            this.SavePicBtton.Size = new System.Drawing.Size(94, 49);
            this.SavePicBtton.TabIndex = 56;
            this.SavePicBtton.Text = "Save";
            this.SavePicBtton.UseVisualStyleBackColor = false;
            this.SavePicBtton.Click += new System.EventHandler(this.SavePicBtton_Click);
            // 
            // CloseButon
            // 
            this.CloseButon.Image = global::GYM_Matrix.Properties.Resources.close_icon_png_19;
            this.CloseButon.Location = new System.Drawing.Point(908, 12);
            this.CloseButon.Name = "CloseButon";
            this.CloseButon.Size = new System.Drawing.Size(30, 30);
            this.CloseButon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButon.TabIndex = 60;
            this.CloseButon.TabStop = false;
            this.CloseButon.Click += new System.EventHandler(this.CloseButon_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ProfilePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.CloseButon);
            this.Controls.Add(this.PicturePanel);
            this.Font = new System.Drawing.Font("Bebas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProfilePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfilePage";
            this.PicturePanel.ResumeLayout(false);
            this.PicturePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CamBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PicturePanel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button StartCamera;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox CamBox;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button SavePicBtton;
        private System.Windows.Forms.PictureBox CloseButon;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}