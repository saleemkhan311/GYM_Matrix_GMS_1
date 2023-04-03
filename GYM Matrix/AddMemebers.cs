using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using System.Drawing.Drawing2D;

namespace GYM_Matrix
{
    public partial class AddMemebers : Form 
    {
        public static int ID;
        public string fileName;
        public string Img_Dir;
        
        
       
        public AddMemebers()
        {
            InitializeComponent();
            UserLabel.Text = LoginPage.username;
           
            
            
            
            
        }
        Dashboard dashboard = new Dashboard();

        public void RunQuery()
        {
            
            if(IDBox.Text != string.Empty)
            {
                ID = int.Parse(IDBox.Text);
                try
                {
                    if (ProfilePage.img_Dir == string.Empty || ProfilePage.img_Dir == null)
                    { MessageBox.Show("Null Image Directory");
                        return;
                    }
                   


                    MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                    con.Open();
                    MySqlCommand cmd;
                    cmd = con.CreateCommand();

                    cmd.CommandText = "INSERT INTO addmembers(ID, Member_Name, Member_Father_Name, Member_phone,Gender,Weight,Membership_type,Member_Age,Fee_Paid,Dues,Joining_date,Renewal_Date,Addmission_Date,Image_Dir,receivedby) VALUES (@ID,@Member_Name,@Member_Father_Name,@Member_phone,@Gender,@Weight,@Membership_type,@Member_Age,@Fee_Paid,@Dues,@Joining_date,@Renewal_Date,@Addmission_Date,@Image_Dir,@receivedby);";
                    
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@Member_Name", NameBox.Text);
                    cmd.Parameters.AddWithValue("@Member_Father_Name", FatherBox.Text);
                    cmd.Parameters.AddWithValue("@Member_Phone", PhoneBox.Text);
                    cmd.Parameters.AddWithValue("@Gender", GenderBox.Text);
                    cmd.Parameters.AddWithValue("@Weight", WeightBox.Text);
                    cmd.Parameters.AddWithValue("@Membership_type", MembershipBox.Text);
                    cmd.Parameters.AddWithValue("@Member_Age", AgeBox.Text);
                    cmd.Parameters.AddWithValue("@Fee_Paid", FeeBox.Text);
                    cmd.Parameters.AddWithValue("@Dues", DuesBox.Text);
                    cmd.Parameters.AddWithValue("@Joining_Date", JoiningDate.Value);
                    cmd.Parameters.AddWithValue("@Renewal_Date", RenewalDate.Value);
                    cmd.Parameters.AddWithValue("@Addmission_Date", AddmissionDate.Value);
                    cmd.Parameters.AddWithValue("@receivedby", LoginPage.username);
                    MessageBox.Show(ProfilePage.img_Dir);
                    cmd.Parameters.AddWithValue("@Image_Dir", ProfilePage.img_Dir);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Succesfully");
                }catch(Exception ex)
                {
                    MessageBox.Show("Please Run Xampp Services or "+ex.Message+fileName);
                }

            }else
            {
                MessageBox.Show("Please Input Data in correct Manner");
            }

        }
        private void Dashboard(object sender, EventArgs e)
        {
           
            this.Close();
            dashboard.Show();
        }

        private void RenewMember(object sender, EventArgs e)
        {
            Renewal Renew = new Renewal();
            this.Hide();
            Renew.Show();
        }



        private void Add_Staff(object sender, EventArgs e)
        {
            AddStaff addStaff = new AddStaff();
            this.Hide();
            addStaff.Show();
        }

        private void Add_Expenses_Label(object sender, EventArgs e)
        {
            Add_Expenses addExpenses = new Add_Expenses();
            this.Hide();
            addExpenses.Show();
        }

        private void View_Members_Label(object sender, EventArgs e)
        {
            ViewMembers viewMembers = new ViewMembers();
            this.Hide();
            viewMembers.Show();

        }

        private void View_Staff_Label(object sender, EventArgs e)
        {
            View_Staff viewStaff = new View_Staff();
            this.Hide();
            viewStaff.Show();
        }

        private void View_Expense_Label(object sender, EventArgs e)
        {
            ViewExpenses viewExpenses = new ViewExpenses();
            this.Hide();
            viewExpenses.Show();
        }

        private void SaveButton(object sender, EventArgs e)
        {
            
                RunQuery();
                
            
        }

        private void AddPicture_Click(object sender, EventArgs e)
        {
            if(NameBox.Text !=string.Empty)
            {
                ProfilePage profilePage = new ProfilePage(NameBox.Text);
                profilePage.Show();

            }
            else
            {
                MessageBox.Show("Please Fill Out the form to Take picture");
            }
        }

       

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void SaveCardButton(object sender, EventArgs e)
        {

        }

        private void GenerateCard(object sender, EventArgs e)
        {

            if (NameBox.Text != string.Empty)
                
            {
                ID = int.Parse(IDBox.Text);
                CardPage cardPage = new CardPage(NameBox.Text,MembershipBox.Text,ID);
                cardPage.Show();
            }else
            {
                MessageBox.Show("Please Fill out form to Generate Card");
            }
        }

        private void GenerateBill(object sender, EventArgs e)
        {
            ID = int.Parse(IDBox.Text);
            if(NameBox.Text == String.Empty)
            {
                MessageBox.Show("Fill out the Form to Generate Receipt");
                return;
            }
           
           
            ReceiptPage receiptPage = new ReceiptPage(NameBox.Text,ID,WeightBox.Text,FeeBox.Text,DuesBox.Text,MembershipBox.Text,LoginPage.username, JoiningDate.Value.ToString("dd-MM-yyyy"), RenewalDate.Value.ToString("dd-MM-yyyy"));
            receiptPage.Show();
        }

      

        private void CancleButton(object sender, EventArgs e)
        {

            IDBox.Clear();
            NameBox.Clear();
            FatherBox.Clear();
            PhoneBox.Clear();
            FeeBox.Clear();
            DuesBox.Clear();
            WeightBox.Clear();
            MembershipBox.Clear();
            AgeBox.Clear();
            GenderBox.SelectedIndex = 0;
            
            JoiningDate.Value = DateTime.Now;
            RenewalDate.Value = DateTime.Now;
        }

        

       

        
        private void MinimizeApp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Refresh()
        {
            try
            {
                ProfileBox.Image = Image.FromFile(ProfilePage.img_Dir);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Null Image Directory or " + ex.Message);
            }
        }
        private void RefreshButton(object sender, EventArgs e)
        {

            Refresh();
        }
       
    }
}
