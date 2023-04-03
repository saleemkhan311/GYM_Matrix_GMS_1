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
    public partial class View_Staff : Form
    {
        int ID;
        public View_Staff()
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

                cmd.CommandText = "SELECT * FROM staff";

                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable Records = new DataTable();
                Records.Load(reader);

                StaffTable.DataSource = Records;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Please Run Xampp Services");
            }
        }

        private void Dashboard_Labe(object sender, EventArgs e)
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

        private void View_Members_Label(object sender, EventArgs e)
        {
            ViewMembers viewMembers = new ViewMembers();
            this.Hide();
            viewMembers.Show();
        }

        private void View_Expense_Label(object sender, EventArgs e)
        {
            ViewExpenses viewExpenses = new ViewExpenses();
            this.Hide();
            viewExpenses.Show();
        }

        private void ViewStaffRecords(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IDBox.Text = StaffTable.SelectedRows[0].Cells[0].Value.ToString();
                NameBox.Text = StaffTable.SelectedRows[0].Cells[1].Value.ToString();
                FatherBox.Text = StaffTable.SelectedRows[0].Cells[2].Value.ToString();
                PhoneBox.Text = StaffTable.SelectedRows[0].Cells[3].Value.ToString();
                ShiftBox.Text = StaffTable.SelectedRows[0].Cells[4].Value.ToString();
                AgeBox.Text = StaffTable.SelectedRows[0].Cells[5].Value.ToString();
                SalaryBox.Text = StaffTable.SelectedRows[0].Cells[6].Value.ToString();
                DuesBox.Text = StaffTable.SelectedRows[0].Cells[7].Value.ToString();
                GenderBox.Text = StaffTable.SelectedRows[0].Cells[8].Value.ToString();
                DesignationBox.Text = StaffTable.SelectedRows[0].Cells[9].Value.ToString();
                object joiningDateValue = StaffTable.SelectedRows[0].Cells[10].Value;
                ProfileBox.Image = Image.FromFile(StaffTable.SelectedRows[0].Cells[11].Value.ToString());
                DateTime selectedJoiningDate;
                if (DateTime.TryParse(joiningDateValue.ToString(), out selectedJoiningDate))
                {
                    JoiningDate.Value = selectedJoiningDate;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CancleButton_Click(object sender, EventArgs e)
        {
            IDBox.Clear();
            NameBox.Clear();
            FatherBox.Clear();
            PhoneBox.Clear();
            AgeBox.Clear();
            ShiftBox.Clear();
            SalaryBox.Clear();
            DuesBox.Clear();
            GenderBox.Text = string.Empty;
            DesignationBox.Clear();

        }
        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeApp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
                    cmd.CommandText = "UPDATE staff SET ID=@ID, Name=@Name, Father=@Father, Phone=@Phone,Shift_Timing=Shift_Timing,Age=@Age,Salary=@Salary,Dues=@Dues,Gender=@Gender,Designation=@Designation,Joining_Date=@Joining_Date,Image_Dir=@Image_Dir WHERE ID= @ID;";
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@Name", NameBox.Text);
                    cmd.Parameters.AddWithValue("@Father", FatherBox.Text);
                    cmd.Parameters.AddWithValue("@Phone", PhoneBox.Text);
                    cmd.Parameters.AddWithValue("@Shift_Timing", ShiftBox.Text);
                    cmd.Parameters.AddWithValue("@Age", AgeBox.Text);
                    cmd.Parameters.AddWithValue("@Salary", int.Parse(SalaryBox.Text));
                    cmd.Parameters.AddWithValue("@Dues", DuesBox.Text);
                    cmd.Parameters.AddWithValue("@Gender", GenderBox.Text);
                    cmd.Parameters.AddWithValue("@Designation", DesignationBox.Text);
                    cmd.Parameters.AddWithValue("@Joining_Date", JoiningDate.Value);
                    cmd.Parameters.AddWithValue("@Image_Dir", ProfilePage.img_Dir);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Data Updated Succesfully");
                }
                catch (Exception ex)
                {


                    MessageBox.Show("Please Run Xampp Services or Enter Data in correct Manner and" + ex.Message);
                }
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
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

                    cmd.CommandText = "DELETE FROM staff WHERE ID=@ID;";
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Run Xampp Services or " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Select A Member to Delete");
            }
        }

        private void RefereshButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SearchButton_Click(object sender, EventArgs e)
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
                        cmd.CommandText = "SELECT * FROM staff WHERE Name=@Name";
                        cmd.Parameters.AddWithValue("@Name", SearchTextBox.Text);

                    }
                    else if (IDRadio.Checked)
                    {
                        cmd.CommandText = "SELECT * FROM staff WHERE ID=@ID";
                        cmd.Parameters.AddWithValue("@ID", SearchTextBox.Text);
                    }
                    else
                    {
                        cmd.CommandText = "SELECT * FROM staff WHERE Name=@Name";
                        cmd.Parameters.AddWithValue("@Name", SearchTextBox.Text);
                    }

                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable records = new DataTable();
                    records.Load(reader);


                    if (records.Rows.Count >= 1)
                    {
                        StaffTable.DataSource = records;
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

        private void AddPicture_Click(object sender, EventArgs e)
        {
            ProfilePage profile = new ProfilePage(NameBox.Text);
            profile.Show();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ProfileBox.Image = Image.FromFile(ProfilePage.img_Dir);
        }
    }
}
