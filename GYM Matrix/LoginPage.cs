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
    public partial class LoginPage : Form
    {
        public static string username;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeApp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            username = UserNameTextBox.Text;
            if (UserNameTextBox.Text == string.Empty || PasswordTextBox.Text == string.Empty)
            {
                MessageBox.Show("All Fields Are Required", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    MySqlConnection con = new MySqlConnection(AppSettings.ConString());

                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE Username=@Username",con);
                    cmd.Parameters.AddWithValue("@Username", UserNameTextBox.Text);


                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Invalid Username");
                    }
                    else
                    {
                        reader.Read();
                        string passFromDatabase = reader.GetString("Password");

                        if (PasswordTextBox.Text == passFromDatabase)
                        {
                            AppSettings app = new AppSettings();
                            Dashboard dash = new Dashboard();
                            username = UserNameTextBox.Text;
                          
                            this.Hide();
                            dash.Show();
                            
                        }
                        else
                        {
                            MessageBox.Show("Invalid Password");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Run Xampp Services or " + ex.Message);
                }


            }
        }
    }
}
