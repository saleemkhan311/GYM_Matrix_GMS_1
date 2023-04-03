
namespace GYM_Matrix
{
    partial class CardPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardPage));
            this.MembershipCardPanel = new System.Windows.Forms.Panel();
            this.MembershipCard = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CardProfile = new System.Windows.Forms.PictureBox();
            this.CardID = new System.Windows.Forms.Label();
            this.CardName = new System.Windows.Forms.Label();
            this.CardMembershipType = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CancleButton = new System.Windows.Forms.Button();
            this.SaveCardButton = new System.Windows.Forms.Button();
            this.MembershipCardPanel.SuspendLayout();
            this.MembershipCard.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MembershipCardPanel
            // 
            this.MembershipCardPanel.BackColor = System.Drawing.Color.White;
            this.MembershipCardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MembershipCardPanel.Controls.Add(this.MembershipCard);
            this.MembershipCardPanel.Controls.Add(this.pictureBox1);
            this.MembershipCardPanel.Controls.Add(this.CancleButton);
            this.MembershipCardPanel.Controls.Add(this.SaveCardButton);
            this.MembershipCardPanel.Location = new System.Drawing.Point(109, 2);
            this.MembershipCardPanel.Name = "MembershipCardPanel";
            this.MembershipCardPanel.Size = new System.Drawing.Size(715, 598);
            this.MembershipCardPanel.TabIndex = 62;
            // 
            // MembershipCard
            // 
            this.MembershipCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MembershipCard.BackgroundImage")));
            this.MembershipCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MembershipCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MembershipCard.Controls.Add(this.tableLayoutPanel1);
            this.MembershipCard.Location = new System.Drawing.Point(61, 12);
            this.MembershipCard.Name = "MembershipCard";
            this.MembershipCard.Size = new System.Drawing.Size(357, 579);
            this.MembershipCard.TabIndex = 61;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.CardProfile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CardID, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.CardName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CardMembershipType, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.32813F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.67188F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(355, 577);
            this.tableLayoutPanel1.TabIndex = 64;
            // 
            // CardProfile
            // 
            this.CardProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CardProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardProfile.Location = new System.Drawing.Point(77, 10);
            this.CardProfile.Name = "CardProfile";
            this.CardProfile.Size = new System.Drawing.Size(200, 200);
            this.CardProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CardProfile.TabIndex = 62;
            this.CardProfile.TabStop = false;
            // 
            // CardID
            // 
            this.CardID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CardID.AutoSize = true;
            this.CardID.BackColor = System.Drawing.Color.Transparent;
            this.CardID.Font = new System.Drawing.Font("Bebas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CardID.ForeColor = System.Drawing.Color.White;
            this.CardID.Location = new System.Drawing.Point(158, 322);
            this.CardID.Name = "CardID";
            this.CardID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CardID.Size = new System.Drawing.Size(38, 32);
            this.CardID.TabIndex = 63;
            this.CardID.Text = "ID:";
            this.CardID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardName
            // 
            this.CardName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CardName.AutoSize = true;
            this.CardName.BackColor = System.Drawing.Color.Transparent;
            this.CardName.Font = new System.Drawing.Font("Bebas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CardName.ForeColor = System.Drawing.Color.White;
            this.CardName.Location = new System.Drawing.Point(109, 256);
            this.CardName.Name = "CardName";
            this.CardName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CardName.Size = new System.Drawing.Size(137, 31);
            this.CardName.TabIndex = 63;
            this.CardName.Text = "Saleem Khan";
            this.CardName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardMembershipType
            // 
            this.CardMembershipType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CardMembershipType.AutoSize = true;
            this.CardMembershipType.BackColor = System.Drawing.Color.Transparent;
            this.CardMembershipType.Font = new System.Drawing.Font("Bebas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CardMembershipType.ForeColor = System.Drawing.Color.White;
            this.CardMembershipType.Location = new System.Drawing.Point(87, 288);
            this.CardMembershipType.Name = "CardMembershipType";
            this.CardMembershipType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CardMembershipType.Size = new System.Drawing.Size(181, 32);
            this.CardMembershipType.TabIndex = 63;
            this.CardMembershipType.Text = "Membership Type";
            this.CardMembershipType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GYM_Matrix.Properties.Resources.close_icon_png_19;
            this.pictureBox1.Location = new System.Drawing.Point(681, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CancleButton
            // 
            this.CancleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(107)))), ((int)(((byte)(91)))));
            this.CancleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancleButton.Font = new System.Drawing.Font("Bebas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancleButton.Location = new System.Drawing.Point(592, 390);
            this.CancleButton.Name = "CancleButton";
            this.CancleButton.Size = new System.Drawing.Size(94, 49);
            this.CancleButton.TabIndex = 58;
            this.CancleButton.Text = "Cancle";
            this.CancleButton.UseVisualStyleBackColor = false;
            this.CancleButton.Click += new System.EventHandler(this.CancleButton_Click);
            // 
            // SaveCardButton
            // 
            this.SaveCardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(107)))), ((int)(((byte)(91)))));
            this.SaveCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveCardButton.Font = new System.Drawing.Font("Bebas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveCardButton.Location = new System.Drawing.Point(594, 80);
            this.SaveCardButton.Name = "SaveCardButton";
            this.SaveCardButton.Size = new System.Drawing.Size(94, 49);
            this.SaveCardButton.TabIndex = 57;
            this.SaveCardButton.Text = "Save Card";
            this.SaveCardButton.UseVisualStyleBackColor = false;
            this.SaveCardButton.Click += new System.EventHandler(this.SaveCardButton_Click);
            // 
            // CardPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.MembershipCardPanel);
            this.Font = new System.Drawing.Font("Bebas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CardPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CardPage";
            this.MembershipCardPanel.ResumeLayout(false);
            this.MembershipCard.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MembershipCardPanel;
        private System.Windows.Forms.Panel MembershipCard;
        private System.Windows.Forms.Label CardID;
        private System.Windows.Forms.Label CardMembershipType;
        private System.Windows.Forms.Label CardName;
        private System.Windows.Forms.PictureBox CardProfile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CancleButton;
        private System.Windows.Forms.Button SaveCardButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}