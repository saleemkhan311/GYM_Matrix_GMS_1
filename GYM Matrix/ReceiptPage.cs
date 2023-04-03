using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace GYM_Matrix
{
    public partial class ReceiptPage : Form
    {
        string memberName;
        


        public ReceiptPage(string name, int id, string weight, string fee, string dues,string membership,string receivedby,string paymentdate,string renewaldate)
        {
            try
            {
                InitializeComponent();

                memberName = name;
                FeesLabel.Text = fee;
                DuesLabel.Text = dues;
                int Fee = int.Parse(fee); ;
                int Dues = Convert.ToInt32(dues);
                TotalLabel.Text = (Fee - Dues).ToString();
                MemberName.Text = name;
                IDLabel.Text = "Member ID: " + id.ToString();
                WeightLabel.Text = weight;
                MembershipLabel.Text = membership;
                PaymentDateLabel.Text = paymentdate;
                RenewalLabel.Text = renewaldate;
                ReceivedLabel.Text = receivedby;

            }catch(Exception ex)
            {
                MessageBox.Show("Please Fill out form completely and Enter Data in Correct Manner to Generate Receipt " + ex.Message);
                this.Hide();
            }

        }
        public ReceiptPage()
        {
           
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintReceipt()
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += new PrintPageEventHandler(printDocument_printPage);

            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private Bitmap memorying;
        private void printDocument_printPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                memorying = new Bitmap(ReceiptP.Width, ReceiptP.Height);
                ReceiptP.DrawToBitmap(memorying, new Rectangle(0, 0, ReceiptP.Width, ReceiptP.Height));
                Rectangle pageArea = e.PageBounds;
                e.Graphics.DrawImage(memorying, (pageArea.Width / 2) - (ReceiptP.Width / 2), ReceiptP.Location.Y);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PrintReceiptButton_Click(object sender, EventArgs e)
        {
            PrintReceipt();
        }
        private void SaveReceipt_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(ReceiptP.Width, ReceiptP.Height);
            Graphics g = Graphics.FromImage(bmp);
            ReceiptP.DrawToBitmap(bmp, new Rectangle(0, 0, ReceiptP.Width, ReceiptP.Height));
            bmp.Save("C:\\GYM_Matrix\\MembersReceipts\\" + memberName + ".png", System.Drawing.Imaging.ImageFormat.Png);
            MessageBox.Show("Receipt Has been Saved to C:\\GYM_Matrix\\MembersReceipts");
            this.Close();
        }

        private void CancleReceipt_Click(object sender, EventArgs e)
        {
            ReceiptPanel.Hide();
        }
       
    }
}
