using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GYM_Matrix
{
    public partial class ViewMembers : Form
    {
        public int ID;
        public ViewMembers()
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

                cmd.CommandText = "SELECT * FROM `addmembers`;";

                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable Records = new DataTable();
                Records.Load(reader);

                ViewMembersTabel.DataSource = Records;
                /*con.Close();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Run Xampp Services or"+ex.Message);
            }
            
        }

        private void Dashboard_Label(object sender, EventArgs e)
        {
            Dashboard Dashboard = new Dashboard();
            Dashboard.Show();
            this.Hide();
        }

        private void AddMember(object sender, EventArgs e)
        {

            AddMemebers AddMembers = new AddMemebers();

            this.Hide();
            AddMembers.Show();
        }

        private void RenewMember(object sender, EventArgs e)
        {
            Renewal renew = new Renewal();
            this.Hide();
            renew.Show();
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

        private void ViewRecords(object sender, DataGridViewCellEventArgs e)
        {
            IDBox.Text = ViewMembersTabel.SelectedRows[0].Cells[0].Value.ToString();
            NameBox.Text = ViewMembersTabel.SelectedRows[0].Cells[1].Value.ToString();
            FatherBox.Text = ViewMembersTabel.SelectedRows[0].Cells[2].Value.ToString();
            PhoneBox.Text = ViewMembersTabel.SelectedRows[0].Cells[3].Value.ToString();
            GenderBox.Text = ViewMembersTabel.SelectedRows[0].Cells[4].Value.ToString();
            WeightBox.Text = ViewMembersTabel.SelectedRows[0].Cells[5].Value.ToString();
            MembershipBox.Text = ViewMembersTabel.SelectedRows[0].Cells[6].Value.ToString();
            AgeBox.Text = ViewMembersTabel.SelectedRows[0].Cells[7].Value.ToString();
            FeeBox.Text = ViewMembersTabel.SelectedRows[0].Cells[8].Value.ToString();
            DuesBox.Text = ViewMembersTabel.SelectedRows[0].Cells[9].Value.ToString();
            ProfileBox.Image = Image.FromFile(ViewMembersTabel.SelectedRows[0].Cells[14].Value.ToString());
            object joiningDateValue = ViewMembersTabel.SelectedRows[0].Cells[10].Value;
            DateTime selectedJoiningDate;
            if(DateTime.TryParse(joiningDateValue.ToString(),out selectedJoiningDate))
            {
                JoiningDate.Value = selectedJoiningDate;
            }
            object RenewaldateValue = ViewMembersTabel.SelectedRows[0].Cells[11].Value;
           
            DateTime selectedDate;
            
            if(DateTime.TryParse(RenewaldateValue.ToString(), out selectedDate) )
            {
                RenewalDate.Value = selectedDate;
            }

            object AddmissiondateValue = ViewMembersTabel.SelectedRows[0].Cells[12].Value;

            DateTime selectedAddmisionDate;

            if (DateTime.TryParse(AddmissiondateValue.ToString(), out selectedAddmisionDate))
            {
                AddmissionDate.Value = selectedAddmisionDate;
            }

        }

        private void RemoveButton(object sender, EventArgs e)
        {
            
            if(IDBox.Text != string.Empty)
            {
                ID = int.Parse(IDBox.Text);
                try
                {
                    MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                    con.Open();
                    MySqlCommand cmd;

                    cmd = con.CreateCommand();

                    cmd.CommandText = "DELETE FROM addmembers WHERE ID=@ID;";
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Run Xampp Services or "+ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Select A Member to Delete");
            }
        }

        private void UpadetButton(object sender, EventArgs e)
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
                    cmd.CommandText = "UPDATE addmembers SET ID=@ID, Member_Name=@Member_Name, Member_Father_Name=@Member_Father_Name, Member_phone=@Member_phone,Gender=@Gender,Weight=@Weight,Membership_type=@Membership_type,Member_Age=@Member_Age,Fee_Paid=@Fee_Paid,Dues=@Dues,Joining_date=@Joining_date,Renewal_Date=@Renewal_Date,Addmission_Date=@Addmission_Date,Image_Dir=@Image_Dir WHERE ID= @ID;";
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
                    cmd.Parameters.AddWithValue("@Image_Dir", ProfilePage.img_Dir);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Data Updated Succesfully");
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {   
                    

                    MessageBox.Show("Please Run Xampp Services or Enter Data in correct Manner");
                }

            }
            else
            {
                MessageBox.Show("Please Select Member to Update");
            }
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

        private void RefereshButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BrowseButton(object sender, EventArgs e)
        {
           
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeApp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void AddPicture_Click(object sender, EventArgs e)
        {
            if (NameBox.Text != string.Empty)
            {
                ProfilePage profilePage = new ProfilePage(NameBox.Text);
                profilePage.Show();

            }
            else
            {
                MessageBox.Show("Please Fill Out the form to Take picture");
            }
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
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Refresh();
            LoadData();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SearchButton(object sender, EventArgs e)
        {
            if (SearchTextBox.Text.Trim() != string.Empty)
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                    con.Open();

                    MySqlCommand cmd;
                    cmd = con.CreateCommand();

                    if (NameRadio.Checked)
                    {
                        cmd.CommandText = "SELECT * FROM addmembers WHERE Member_Name=@Member_Name";
                        cmd.Parameters.AddWithValue("@Member_Name", SearchTextBox.Text);

                    }
                    else if (IDRadio.Checked)
                    {
                        cmd.CommandText = "SELECT * FROM addmembers WHERE ID=@ID";
                        cmd.Parameters.AddWithValue("@ID", SearchTextBox.Text);
                    }
                    else
                    {
                        cmd.CommandText = "SELECT * FROM addmembers WHERE Member_Name=@Member_Name";
                        cmd.Parameters.AddWithValue("@Member_Name", SearchTextBox.Text);
                    }

                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable records = new DataTable();
                    records.Load(reader);
                    

                    if (records.Rows.Count >= 1)
                    {
                        ViewMembersTabel.DataSource = records;
                    }
                    else
                    {
                        MessageBox.Show("No Records Found");
                        LoadData();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else { MessageBox.Show("Enter Something to Search"); }
        }

        private void ResetuBtton(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
