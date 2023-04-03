using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Drawing.Printing;

namespace GYM_Matrix
{
    public partial class Renewal : Form
    {

        private int ID;
        public Renewal()
        {

            InitializeComponent();
            UserLabel.Text = LoginPage.username;
            LoadData();
            

        }

        private void LoadData()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                con.Open();
                MySqlCommand cmd;

                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * FROM addmembers";

                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable Records = new DataTable();
                Records.Load(reader);

                RenewalTabel.DataSource = Records;
                /*con.Close();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Run Xampp Services or " + ex.Message);
            }


        }

        private void Dashboard_Label(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void AddMember(object sender, EventArgs e)
        {
            Dashboard Dashboard = new Dashboard();
            AddMemebers AddMembers = new AddMemebers();

            Dashboard.Hide();
            AddMembers.Show();
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

        private void ViewRenewalMembersRecords(object sender, DataGridViewCellEventArgs e)
        {
            IDBox.Text = RenewalTabel.SelectedRows[0].Cells[0].Value.ToString();
            NameBox.Text = RenewalTabel.SelectedRows[0].Cells[1].Value.ToString();
            FatherBox.Text = RenewalTabel.SelectedRows[0].Cells[2].Value.ToString();
            PhoneBox.Text = RenewalTabel.SelectedRows[0].Cells[3].Value.ToString();
            GenderBox.Text = RenewalTabel.SelectedRows[0].Cells[4].Value.ToString();
            WeightBox.Text = RenewalTabel.SelectedRows[0].Cells[5].Value.ToString();
            MembershipBox.Text = RenewalTabel.SelectedRows[0].Cells[6].Value.ToString();
            AgeBox.Text = RenewalTabel.SelectedRows[0].Cells[7].Value.ToString();
            FeeBox.Text = RenewalTabel.SelectedRows[0].Cells[8].Value.ToString();
            DuesBox.Text = RenewalTabel.SelectedRows[0].Cells[9].Value.ToString();
            ProfileBox.Image = Image.FromFile(RenewalTabel.SelectedRows[0].Cells[14].Value.ToString());
            object joiningDateValue = RenewalTabel.SelectedRows[0].Cells[10].Value;

            DateTime selectedJoiningDate;
            if (DateTime.TryParse(joiningDateValue.ToString(), out selectedJoiningDate))
            {
                JoiningDate.Value = selectedJoiningDate;
            }
            object RenewaldateValue = RenewalTabel.SelectedRows[0].Cells[11].Value;

            DateTime selectedDate;

            if (DateTime.TryParse(RenewaldateValue.ToString(), out selectedDate))
            {
                RenewalDate.Value = selectedDate;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (IDBox.Text != string.Empty)
            {
                ID = int.Parse(IDBox.Text);
                try
                {
                    MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                    con.Open();
                    MySqlCommand cmd;
                    cmd = con.CreateCommand();
                    cmd.CommandText = "UPDATE addmembers SET ID=@ID, Member_Name=@Member_Name, Member_Father_Name=@Member_Father_Name, Member_phone=@Member_phone,Gender=@Gender,Weight=@Weight,Membership_type=@Membership_type,Member_Age=@Member_Age,Fee_Paid=@Fee_Paid,Dues=@Dues,Joining_date=@Joining_date,Renewal_Date=@Renewal_Date WHERE ID= @ID;";
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
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Data Updated Succesfully");
                }
                catch (Exception ex)
                {


                    MessageBox.Show("Please Run Xampp Services or Enter Data in correct Manner or "+ex.Message);
                }
            }
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeApp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void GenerateCard_Click(object sender, EventArgs e)
        {
           
                if (NameBox.Text != string.Empty)
                {

                       ID = int.Parse(IDBox.Text);

                     CardPage cardPage = new CardPage(NameBox.Text, MembershipBox.Text, ID);
                     cardPage.Show();
                }
                else
                {
                    MessageBox.Show("Please Fill out form to Generate Card");
                }
            
        }

       

       

        

        private void GenerateBill_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == String.Empty)
            {
                MessageBox.Show("Fill out the Form to Generate Receipt");
                return;
            }
            int fee = Convert.ToInt32(FeeBox.Text);
            int dues = Convert.ToInt32(DuesBox.Text);
            
            ReceiptPage receiptPage = new ReceiptPage(NameBox.Text, ID, WeightBox.Text, FeeBox.Text, DuesBox.Text, MembershipBox.Text, LoginPage.username, JoiningDate.Value.ToString("dd-MM-yyyy"), RenewalDate.Value.ToString("dd-MM-yyyy"));
            receiptPage.Show();
        }

       

        private void CancleButton_Click(object sender, EventArgs e)
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

        private void AddPicture_Click(object sender, EventArgs e)
        {
            ProfilePage profilePage = new ProfilePage(NameBox.Text);
            profilePage.Show();
        }

        private void RefershButton_Click(object sender, EventArgs e)
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
    }
}
