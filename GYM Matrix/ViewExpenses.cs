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
    public partial class ViewExpenses : Form
    {
        
        public ViewExpenses()
        {
            InitializeComponent();
            UserLabel.Text = LoginPage.username;
            LoadData();
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

        private void RenewMember(object sender, EventArgs e)
        {
            Renewal renew = new Renewal();
            this.Hide();
            renew.Show();
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

        private void ViewExpenseData(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                NameBox.Text = ViewExpenseTable.SelectedRows[0].Cells[0].Value.ToString();
                ExpenseTypeBox.Text = ViewExpenseTable.SelectedRows[0].Cells[2].Value.ToString();
                DiscriptionBox.Text = ViewExpenseTable.SelectedRows[0].Cells[3].Value.ToString();
                


                //ExpenseDate.Value = ViewExpenseTable.SelectedRows[0].Cells[4].Value;


            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Please Run Xampp Services");
            }
        }

        private void LoadData()
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConString());
            con.Open();
            MySqlCommand cmd;

            cmd = con.CreateCommand();

            cmd.CommandText = "SELECT * FROM expenses";

            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable Records = new DataTable();
            Records.Load(reader);

            ViewExpenseTable.DataSource = Records;
            /*con.Close();*/
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeApp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
