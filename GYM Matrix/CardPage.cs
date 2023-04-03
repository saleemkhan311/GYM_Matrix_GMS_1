using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GYM_Matrix
{
    public partial class CardPage : Form
    {
        string Name;
        
        public CardPage(string name, string membership,int id)
        {
            InitializeComponent();

            CardName.Text = name;
            Name = name;
            CardMembershipType.Text = membership;
            CardID.Text ="ID: "+ id.ToString();
            if(ProfilePage.img_Dir != string.Empty || ProfilePage.img_Dir != null)
            {
                CardProfile.Image = Image.FromFile(ProfilePage.img_Dir);
            }
        }

        private void SaveCardButton_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap bmp = new Bitmap(MembershipCard.Width, MembershipCard.Height);
                Graphics g = Graphics.FromImage(bmp);
                MembershipCard.DrawToBitmap(bmp, new Rectangle(0, 0, MembershipCard.Width, MembershipCard.Height));
                bmp.Save("C:\\GYM_Matrix\\MembershipCards\\" + Name + ".png", System.Drawing.Imaging.ImageFormat.Png);
                MessageBox.Show("Membership Card Has Been Saved to C:\\GYM_Matrix\\MembershipCards");
            }catch(Exception ex)
            {
                MessageBox.Show("Card Already Saved by Name: " + Name+" or "+ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
