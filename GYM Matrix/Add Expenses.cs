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
    public partial class Add_Expenses : Form
    {

        public Add_Expenses()
        {
            InitializeComponent();
            UserLabel.Text = LoginPage.username;
        }

        private void Dashboard_Label(object sender, EventArgs e)
        {
            Dashboard Dashboard = new Dashboard();
            Dashboard.Show();
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

        private void RunQuery()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO expenses(Expense_Name,Expense_Amount,Expense_Type,Discription,Expense_Date,ID) VALUES (@Expense_Name,@Expense_Amount,@Expense_Type,@Discription,@Expense_Date,@ID)";
                cmd.Parameters.AddWithValue("@Expense_Name", NameBox.Text);
                cmd.Parameters.AddWithValue("@Expense_Amount", AmmountBox.Text);
                cmd.Parameters.AddWithValue("@Expense_Type", ExpenseTypeBox.Text);
                cmd.Parameters.AddWithValue("@Discription", DiscriptionBox.Text);
                cmd.Parameters.AddWithValue("@Expense_Date", ExpenseDate.Value);
                cmd.Parameters.AddWithValue("@ID", IDBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Records Inserted Succesfully");


            }
            catch (Exception ex)
            {

                
                MessageBox.Show("Something Went Wrong,  try Running Xampp Services or Enter Data in Correct Manner or "+ex.Message);
            }
}

        private void CancleButton(object sender, EventArgs e)
        {
            NameBox.Clear();
            IDBox.Clear();
            DiscriptionBox.Clear();
            AmmountBox.Clear();
            ExpenseTypeBox.Text = string.Empty;
            ExpenseDate.Value = DateTime.Now.AddDays(0);
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
