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
    public partial class UserPanel : Form
    {
        private int ID;
        public UserPanel()
        {
            InitializeComponent();
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

                cmd.CommandText = "SELECT * FROM users";

                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable Records = new DataTable();
                Records.Load(reader);

                UsersDataTable.DataSource = Records;
                /*con.Close();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Run Xampp Services or" + ex.Message);
            }
        }

        private void Close_click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Close();
            dashboard.Show();
        }

        private void SaveButton(object sender, EventArgs e)
        {
            if (IDBox.Text != string.Empty)
            {
               if(ConfirmPassBox.Text==PasswordBox.Text)
                {
                    ID = int.Parse(IDBox.Text);
                    try
                    {
                        MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                        con.Open();
                        MySqlCommand cmd;
                        cmd = con.CreateCommand();
                        cmd.CommandText = "INSERT INTO users(ID, Username, Email,Password) VALUES (@ID, @Username, @Email,@Password);";
                        cmd.Parameters.AddWithValue("@ID", ID);
                        cmd.Parameters.AddWithValue("@Username", NameBox.Text);
                        cmd.Parameters.AddWithValue("@Email", EmailBox.Text);
                        cmd.Parameters.AddWithValue("@Password", PasswordBox.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Inserted Succesfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please Run Xampp Services or " + ex.Message);
                    }
                }
                else { MessageBox.Show("Password and Confirm Password are not same"); }

            }
            else
            {
                MessageBox.Show("Please Input Data in correct Manner");
            }

            
        }

        private void UpdateButton(object sender, EventArgs e)
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
                    cmd.CommandText = "UPdate users SET ID=@ID, Username=@Username, Email=@Email,Password=@Password WHERE ID=@ID;";
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@Username", NameBox.Text);
                    cmd.Parameters.AddWithValue("@Email", EmailBox.Text);
                    cmd.Parameters.AddWithValue("@Password", PasswordBox.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Succesfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Run Xampp Services or " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Please Input Data in correct Manner");
            }
        }

        private void RemoveButton(object sender, EventArgs e)
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

                    cmd.CommandText = "DELETE FROM addmembers WHERE ID=@ID;";
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
                MessageBox.Show("Please Select A User to Delete");
            }
        }

        private void CancleButton(object sender, EventArgs e)
        {
            IDBox.Clear();
            PasswordBox.Clear();
            NameBox.Clear();
            EmailBox.Clear();
            ConfirmPassBox.Clear();
        }

        private void ViewUserDataTable(object sender, DataGridViewCellEventArgs e)
        {
            IDBox.Text = UsersDataTable.SelectedRows[0].Cells[0].Value.ToString();
            NameBox.Text = UsersDataTable.SelectedRows[0].Cells[1].Value.ToString();
            EmailBox.Text = UsersDataTable.SelectedRows[0].Cells[2].Value.ToString();
            PasswordBox.Text = UsersDataTable.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void ConfirmPassBox_Leave(object sender, EventArgs e)
        {
            if (PasswordBox.Text != ConfirmPassBox.Text)
            {
                MessageBox.Show("Please Enter Same Password and Confirm Password");

            }
        }

        private void RefreshButton(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
