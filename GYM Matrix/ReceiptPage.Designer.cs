
namespace GYM_Matrix
{
    partial class ReceiptPage
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
            this.ReceiptPanel = new System.Windows.Forms.Panel();
            this.ReceiptP = new System.Windows.Forms.Panel();
            this.ReceivedLabel = new System.Windows.Forms.Label();
            this.RenewalLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.PaymentDateLabel = new System.Windows.Forms.Label();
            this.DuesLabel = new System.Windows.Forms.Label();
            this.MembershipLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.FeesLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.MemberName = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.CancleReceipt = new System.Windows.Forms.Button();
            this.SaveReceipt = new System.Windows.Forms.Button();
            this.PrintReceiptButton = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ReceiptPanel.SuspendLayout();
            this.ReceiptP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Button)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReceiptPanel
            // 
            this.ReceiptPanel.BackColor = System.Drawing.Color.White;
            this.ReceiptPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReceiptPanel.Controls.Add(this.ReceiptP);
            this.ReceiptPanel.Controls.Add(this.CancleReceipt);
            this.ReceiptPanel.Controls.Add(this.SaveReceipt);
            this.ReceiptPanel.Controls.Add(this.PrintReceiptButton);
            this.ReceiptPanel.Font = new System.Drawing.Font("Bebas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReceiptPanel.Location = new System.Drawing.Point(15, 69);
            this.ReceiptPanel.Name = "ReceiptPanel";
            this.ReceiptPanel.Size = new System.Drawing.Size(920, 553);
            this.ReceiptPanel.TabIndex = 63;
            // 
            // ReceiptP
            // 
            this.ReceiptP.BackgroundImage = global::GYM_Matrix.Properties.Resources.Gym_Reciept_Print11;
            this.ReceiptP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReceiptP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReceiptP.Controls.Add(this.tableLayoutPanel1);
            this.ReceiptP.Controls.Add(this.label31);
            this.ReceiptP.Controls.Add(this.label32);
            this.ReceiptP.Controls.Add(this.label33);
            this.ReceiptP.Location = new System.Drawing.Point(52, 155);
            this.ReceiptP.Name = "ReceiptP";
            this.ReceiptP.Size = new System.Drawing.Size(830, 371);
            this.ReceiptP.TabIndex = 61;
            // 
            // ReceivedLabel
            // 
            this.ReceivedLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ReceivedLabel.AutoSize = true;
            this.ReceivedLabel.BackColor = System.Drawing.Color.Transparent;
            this.ReceivedLabel.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReceivedLabel.Location = new System.Drawing.Point(561, 338);
            this.ReceivedLabel.Name = "ReceivedLabel";
            this.ReceivedLabel.Size = new System.Drawing.Size(94, 24);
            this.ReceivedLabel.TabIndex = 64;
            this.ReceivedLabel.Text = "received By";
            // 
            // RenewalLabel
            // 
            this.RenewalLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RenewalLabel.AutoSize = true;
            this.RenewalLabel.BackColor = System.Drawing.Color.Transparent;
            this.RenewalLabel.Font = new System.Drawing.Font("Bebas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RenewalLabel.Location = new System.Drawing.Point(697, 58);
            this.RenewalLabel.Name = "RenewalLabel";
            this.RenewalLabel.Size = new System.Drawing.Size(92, 20);
            this.RenewalLabel.TabIndex = 64;
            this.RenewalLabel.Text = "Renewal Date";
            // 
            // IDLabel
            // 
            this.IDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDLabel.AutoSize = true;
            this.IDLabel.BackColor = System.Drawing.Color.Transparent;
            this.IDLabel.Font = new System.Drawing.Font("Bebas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDLabel.ForeColor = System.Drawing.Color.White;
            this.IDLabel.Location = new System.Drawing.Point(204, 4);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(78, 20);
            this.IDLabel.TabIndex = 64;
            this.IDLabel.Text = "Member ID: ";
            // 
            // PaymentDateLabel
            // 
            this.PaymentDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PaymentDateLabel.AutoSize = true;
            this.PaymentDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.PaymentDateLabel.Font = new System.Drawing.Font("Bebas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PaymentDateLabel.Location = new System.Drawing.Point(696, 9);
            this.PaymentDateLabel.Name = "PaymentDateLabel";
            this.PaymentDateLabel.Size = new System.Drawing.Size(93, 20);
            this.PaymentDateLabel.TabIndex = 64;
            this.PaymentDateLabel.Text = "Payment Date";
            // 
            // DuesLabel
            // 
            this.DuesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DuesLabel.AutoSize = true;
            this.DuesLabel.BackColor = System.Drawing.Color.Transparent;
            this.DuesLabel.Font = new System.Drawing.Font("Bebas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DuesLabel.Location = new System.Drawing.Point(661, 188);
            this.DuesLabel.Name = "DuesLabel";
            this.DuesLabel.Size = new System.Drawing.Size(61, 34);
            this.DuesLabel.TabIndex = 64;
            this.DuesLabel.Text = "Dues";
            // 
            // MembershipLabel
            // 
            this.MembershipLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MembershipLabel.AutoSize = true;
            this.MembershipLabel.BackColor = System.Drawing.Color.Transparent;
            this.MembershipLabel.Font = new System.Drawing.Font("Bebas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MembershipLabel.Location = new System.Drawing.Point(661, 151);
            this.MembershipLabel.Name = "MembershipLabel";
            this.MembershipLabel.Size = new System.Drawing.Size(137, 34);
            this.MembershipLabel.TabIndex = 64;
            this.MembershipLabel.Text = "Membership";
            // 
            // TotalLabel
            // 
            this.TotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalLabel.Font = new System.Drawing.Font("Bebas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalLabel.Location = new System.Drawing.Point(92, 227);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(72, 34);
            this.TotalLabel.TabIndex = 64;
            this.TotalLabel.Text = "Total";
            // 
            // FeesLabel
            // 
            this.FeesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FeesLabel.AutoSize = true;
            this.FeesLabel.BackColor = System.Drawing.Color.Transparent;
            this.FeesLabel.Font = new System.Drawing.Font("Bebas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FeesLabel.Location = new System.Drawing.Point(92, 188);
            this.FeesLabel.Name = "FeesLabel";
            this.FeesLabel.Size = new System.Drawing.Size(59, 34);
            this.FeesLabel.TabIndex = 64;
            this.FeesLabel.Text = "FEES";
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.BackColor = System.Drawing.Color.Transparent;
            this.WeightLabel.Font = new System.Drawing.Font("Bebas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WeightLabel.Location = new System.Drawing.Point(92, 151);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(85, 34);
            this.WeightLabel.TabIndex = 64;
            this.WeightLabel.Text = "Weight";
            // 
            // MemberName
            // 
            this.MemberName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MemberName.AutoSize = true;
            this.MemberName.BackColor = System.Drawing.Color.Transparent;
            this.MemberName.Font = new System.Drawing.Font("Bebas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MemberName.Location = new System.Drawing.Point(92, 106);
            this.MemberName.Name = "MemberName";
            this.MemberName.Size = new System.Drawing.Size(154, 34);
            this.MemberName.TabIndex = 64;
            this.MemberName.Text = "Member Name";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Antonio", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label31.Location = new System.Drawing.Point(120, 466);
            this.label31.Name = "label31";
            this.label31.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label31.Size = new System.Drawing.Size(38, 33);
            this.label31.TabIndex = 63;
            this.label31.Text = "ID:";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Antonio", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label32.Location = new System.Drawing.Point(120, 424);
            this.label32.Name = "label32";
            this.label32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label32.Size = new System.Drawing.Size(164, 33);
            this.label32.TabIndex = 63;
            this.label32.Text = "Membership Type";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label33.Location = new System.Drawing.Point(120, 380);
            this.label33.Name = "label33";
            this.label33.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label33.Size = new System.Drawing.Size(132, 33);
            this.label33.TabIndex = 63;
            this.label33.Text = "Saleem Khan";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CancleReceipt
            // 
            this.CancleReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(107)))), ((int)(((byte)(91)))));
            this.CancleReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancleReceipt.Font = new System.Drawing.Font("Bebas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancleReceipt.Location = new System.Drawing.Point(366, 40);
            this.CancleReceipt.Name = "CancleReceipt";
            this.CancleReceipt.Size = new System.Drawing.Size(94, 59);
            this.CancleReceipt.TabIndex = 58;
            this.CancleReceipt.Text = "Cancle";
            this.CancleReceipt.UseVisualStyleBackColor = false;
            // 
            // SaveReceipt
            // 
            this.SaveReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(107)))), ((int)(((byte)(91)))));
            this.SaveReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveReceipt.Font = new System.Drawing.Font("Bebas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveReceipt.Location = new System.Drawing.Point(211, 42);
            this.SaveReceipt.Name = "SaveReceipt";
            this.SaveReceipt.Size = new System.Drawing.Size(94, 57);
            this.SaveReceipt.TabIndex = 57;
            this.SaveReceipt.Text = "Save Receipt";
            this.SaveReceipt.UseVisualStyleBackColor = false;
            this.SaveReceipt.Click += new System.EventHandler(this.SaveReceipt_Click);
            // 
            // PrintReceiptButton
            // 
            this.PrintReceiptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(107)))), ((int)(((byte)(91)))));
            this.PrintReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintReceiptButton.Font = new System.Drawing.Font("Bebas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrintReceiptButton.Location = new System.Drawing.Point(52, 42);
            this.PrintReceiptButton.Name = "PrintReceiptButton";
            this.PrintReceiptButton.Size = new System.Drawing.Size(94, 57);
            this.PrintReceiptButton.TabIndex = 57;
            this.PrintReceiptButton.Text = "Print Receipt";
            this.PrintReceiptButton.UseVisualStyleBackColor = false;
            this.PrintReceiptButton.Click += new System.EventHandler(this.PrintReceiptButton_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.Image = global::GYM_Matrix.Properties.Resources.close_icon_png_19;
            this.Close_Button.Location = new System.Drawing.Point(917, 3);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(30, 30);
            this.Close_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_Button.TabIndex = 60;
            this.Close_Button.TabStop = false;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.44389F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.55611F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tableLayoutPanel1.Controls.Add(this.IDLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TotalLabel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.FeesLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.WeightLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.MemberName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.MembershipLabel, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.DuesLabel, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.PaymentDateLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.RenewalLabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.ReceivedLabel, 2, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.859078F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.27913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.233062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.56911F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.19512F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.56911F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.943089F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(828, 369);
            this.tableLayoutPanel1.TabIndex = 64;
            // 
            // ReceiptPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.ReceiptPanel);
            this.Controls.Add(this.Close_Button);
            this.Font = new System.Drawing.Font("Bebas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReceiptPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceiptPage";
            this.ReceiptPanel.ResumeLayout(false);
            this.ReceiptP.ResumeLayout(false);
            this.ReceiptP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Button)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ReceiptPanel;
        private System.Windows.Forms.Panel ReceiptP;
        private System.Windows.Forms.Label ReceivedLabel;
        private System.Windows.Forms.Label RenewalLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label PaymentDateLabel;
        private System.Windows.Forms.Label DuesLabel;
        private System.Windows.Forms.Label MembershipLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label FeesLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label MemberName;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button CancleReceipt;
        private System.Windows.Forms.Button SaveReceipt;
        private System.Windows.Forms.Button PrintReceiptButton;
        private System.Windows.Forms.PictureBox Close_Button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}