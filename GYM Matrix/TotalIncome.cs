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
    public partial class TotalIncome : Form
    {
        public TotalIncome()
        {
            InitializeComponent();
            LoadDailyData();
            LoadMonthlyData();
        }

        private void LoadMonthlyData()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM monthlyincome";

                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable records = new DataTable();

                records.Load(reader);

                MonthlyIncomeTable.DataSource = records;
            }catch(Exception ex)
            {
                MessageBox.Show("Please Run Xampp Services or " + ex.Message);
            }
        }

        private void LoadDailyData()
        {
            try { 
            MySqlConnection con = new MySqlConnection(AppSettings.ConString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM dailyincome";

            MySqlDataReader reader = cmd.ExecuteReader();

            DataTable records = new DataTable();

            records.Load(reader);

            DailyIncomeTable.DataSource = records;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Run Xampp Services or " + ex.Message);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Close();
            dashboard.Show();
        }

        private void SaveDaily_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                con.Open();

                MySqlCommand cmd;

                cmd = con.CreateCommand();

                cmd.CommandText = "INSERT INTO dailyincome(ID,Amount,Date) VALUES(@ID,@Amount,@Date)";
                cmd.Parameters.AddWithValue("@ID",DailyIDBox.Text);
                cmd.Parameters.AddWithValue("@Amount",DailyAmount.Text);
                cmd.Parameters.AddWithValue("@Date",DailyIncomeDate.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully");
                LoadDailyData();
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Please Run Xampp Services or " + ex.Message);
            }

        }

        private void SaveMonthly_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                con.Open();

                MySqlCommand cmd;

                cmd = con.CreateCommand();

                cmd.CommandText = "INSERT INTO monthlyincome(ID,Amount,Date) VALUES(@ID,@Amount,@Date)";
                cmd.Parameters.AddWithValue("@ID", MonthlyIDBox.Text);
                cmd.Parameters.AddWithValue("@Amount", MonthlyAmountBox.Text);
                cmd.Parameters.AddWithValue("@Date", MonthlyDate.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully");
                LoadMonthlyData();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Run Xampp Services or " + ex.Message);
            }
        }

        private void UpdateDaily_Click(object sender, EventArgs e)
        {
            if(DailyIDBox.Text != string.Empty)
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                    con.Open();

                    MySqlCommand cmd;

                    cmd = con.CreateCommand();

                    cmd.CommandText = "UPDATE dailyincome SET ID=@ID,Amount=@Amount,Date=@Date";
                    cmd.Parameters.AddWithValue("@ID", DailyIDBox.Text);
                    cmd.Parameters.AddWithValue("@Amount", DailyAmount.Text);
                    cmd.Parameters.AddWithValue("@Date", DailyIncomeDate.Value);
                    cmd.ExecuteNonQuery();
                    LoadMonthlyData();
                    MessageBox.Show("Daily Data Updated Successfully");

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Run Xampp Services or " + ex.Message);
                }
            }
            else { MessageBox.Show("Please Select Data To Update"); }
        }

        private void UpdateMonthly_Click(object sender, EventArgs e)
        {
            if(MonthlyIDBox.Text != String.Empty)
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                    con.Open();

                    MySqlCommand cmd;

                    cmd = con.CreateCommand();

                    cmd.CommandText = "UPDATE monthlyincome SET ID=@ID,Amount=@Amount,Date=@Date";
                    cmd.Parameters.AddWithValue("@ID", MonthlyIDBox.Text);
                    cmd.Parameters.AddWithValue("@Amount", MonthlyAmountBox.Text);
                    cmd.Parameters.AddWithValue("@Date", MonthlyDate.Value);
                    cmd.ExecuteNonQuery();
                    LoadDailyData();
                    MessageBox.Show("Monthly Data Updated Successfully");

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Run Xampp Services or " + ex.Message);
                }
            }
            else { MessageBox.Show("Please Select Data to Update"); }
        }

        private void MonthlyIncomeTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MonthlyIDBox.Text = MonthlyIncomeTable.SelectedRows[0].Cells[0].Value.ToString();
            MonthlyAmountBox.Text = MonthlyIncomeTable.SelectedRows[0].Cells[1].Value.ToString();
           
            object MonthlyDateValue = MonthlyIncomeTable.SelectedRows[0].Cells[2].Value;
            DateTime selectedMonthlyDate;
            if (DateTime.TryParse(MonthlyDateValue.ToString(), out selectedMonthlyDate))
            {
                MonthlyDate.Value = selectedMonthlyDate;
            }
        }

        private void DailyIncomeTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DailyIDBox.Text = DailyIncomeTable.SelectedRows[0].Cells[0].Value.ToString();
            DailyAmount.Text = DailyIncomeTable.SelectedRows[0].Cells[1].Value.ToString();

            object DailyDateValue = DailyIncomeTable.SelectedRows[0].Cells[2].Value;
            DateTime selectedDailyDate;
            if (DateTime.TryParse(DailyDateValue.ToString(), out selectedDailyDate))
            {
                DailyIncomeDate.Value = selectedDailyDate;
            }
        }

        private void RefreshButton(object sender, EventArgs e)
        {
            LoadDailyData();
            LoadMonthlyData();
        }

        private void CancleButton(object sender, EventArgs e)
        {
            DailyIDBox.Clear();
            DailyAmount.Clear();
        }

        private void MonthlyCancle(object sender, EventArgs e)
        {
            MonthlyIDBox.Clear();
            MonthlyAmountBox.Clear();
        }

        private void DailyRemove(object sender, EventArgs e)
        {
            if (DailyIDBox.Text != string.Empty)
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                    con.Open();

                    MySqlCommand cmd;

                    cmd = con.CreateCommand();

                    cmd.CommandText = "DELETE FROM dailyincome WHERE ID=@ID";
                    cmd.Parameters.AddWithValue("@ID", DailyIDBox.Text);

                    cmd.ExecuteNonQuery();
                    LoadMonthlyData();
                    MessageBox.Show("Daily Data Removed  Successfully");

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Run Xampp Services or " + ex.Message);
                }
            }
            else { MessageBox.Show("Please Select Data to Remove"); }
        }

        private void RemoveMontlhy(object sender, EventArgs e)
        {
            if (MonthlyIDBox.Text != string.Empty)
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                    con.Open();

                    MySqlCommand cmd;

                    cmd = con.CreateCommand();

                    cmd.CommandText = "DELETE FROM Monthlyincome WHERE ID=@ID";
                    cmd.Parameters.AddWithValue("@ID", MonthlyIDBox.Text);

                    cmd.ExecuteNonQuery();
                    LoadMonthlyData();
                    MessageBox.Show("Monthly Data Removed  Successfully");

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Run Xampp Services or " + ex.Message);
                }
            }
            else { MessageBox.Show("Please Select Data to Remove"); }
        }
    }
}
