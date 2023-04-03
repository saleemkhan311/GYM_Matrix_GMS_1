using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AForge.Video;
using AForge.Video.DirectShow;

namespace GYM_Matrix
{
    public partial class AddStaff : Form
    {
        public static int staffID;
        public string fileName;
        bool isStreaming = false;
        VideoCaptureDevice videoCapture;
        FilterInfoCollection filterInfo;
        public AddStaff()
        {
            InitializeComponent();
            UserLabel.Text = LoginPage.username;
            //PicturePanel.Hide();
        }

        private void RenewMember(object sender, EventArgs e)
        {
            Renewal renew = new Renewal();
            renew.Show();
            this.Hide();
        }

        private void Dashboad_Label(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            this.Hide();
            dash.Show();
        }


        private void Dashboard_Label(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }


        private void AddMember(object sender, EventArgs e)
        {
            
            AddMemebers AddMembers = new AddMemebers();

            this.Hide();
            AddMembers.Show();
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ProfileBox.Image != null)
            {
                runQuery();
            }
            else
            {
                MessageBox.Show("Please Add Image First");
            }
            
        }

       /* private void StartCamera_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex >= 0)
            {

                if (!isStreaming)
                {
                    isStreaming = true;
                    StartCamera.Text = "StopCam";
                    try
                    {
                        filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                        videoCapture = new VideoCaptureDevice(filterInfo[comboBox1.SelectedIndex].MonikerString);
                        videoCapture.NewFrame += new NewFrameEventHandler(Cam_On);
                        videoCapture.Start();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (isStreaming)
                {
                    StartCamera.Text = "StartCam";
                    videoCapture.SignalToStop();
                    isStreaming = false;
                }
            }
            else
            {
                MessageBox.Show("Select Camera Device Before Starting Camera");
            }
        }*/

        private void Cam_On(object sender, NewFrameEventArgs eventArgs)
        {
            //CamBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void CloseButon_Click(object sender, EventArgs e)
        {


            if (isStreaming)
            {
                videoCapture.SignalToStop();
                MessageBox.Show("Wait for Webcam to stop and try Agian");
                isStreaming = false;
            }
            else if (!isStreaming)
            {
                //PicturePanel.Hide();
            }

        }

        private void CaptureButton(object sender, EventArgs e)
        {
            //PicBox.Image = CamBox.Image;


        }



        private void BrowseButon(object sender, EventArgs e)
        {
            if (!isStreaming)
            {
                openFileDialog1.ShowDialog();
                fileName = openFileDialog1.FileName;
              //  PicBox.Image = Image.FromFile(fileName);
                ProfileBox.Image = Image.FromFile(fileName);
            }
            else
            {
                MessageBox.Show("Stop The Camera To Browse Image");
            }

        }

        /*private void SavePicBtton_Click_1(object sender, EventArgs e)
        {
            try {
                if (isStreaming)
                {

                    fileName = @"C:\GYM_Matrix\StaffProfiles" + NameBox.Text + ".jpg";
                    var bitmap = new Bitmap(PicBox.Width, PicBox.Height);
                    PicBox.DrawToBitmap(bitmap, PicBox.ClientRectangle);
                    System.Drawing.Imaging.ImageFormat imageFormat = null;
                    imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
                    bitmap.Save(fileName);
                    ProfileBox.Image = Image.FromFile(fileName);
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/
        private void runQuery()
        {
            staffID = int.Parse(IDBox.Text);
            if (staffID != 0)
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                    con.Open();
                    MySqlCommand cmd;
                    cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO staff(ID,Name,Father,Phone,Shift_Timing,Age,Salary,Dues,Gender,Designation,Joining_Date,Image_Dir) VALUES (@ID,@Name,@Father,@Phone,@Shift_Timing,@Age,@Salary,@Dues,@Gender,@Designation,@Joining_Date,@Image_Dir);";
                    cmd.Parameters.AddWithValue("@ID", staffID);
                    cmd.Parameters.AddWithValue("@Name", NameBox.Text);
                    cmd.Parameters.AddWithValue("@Father", FatherBox.Text);
                    cmd.Parameters.AddWithValue("@Phone", PhoneBox.Text);
                    cmd.Parameters.AddWithValue("@Shift_Timing", TimingBox.Text);
                    cmd.Parameters.AddWithValue("@Age", AgeBox.Text);
                    cmd.Parameters.AddWithValue("@Salary", SalaryBox.Text);
                    cmd.Parameters.AddWithValue("@Dues", DuesBox.Text);
                    cmd.Parameters.AddWithValue("@Gender", GenderBox.Text);
                    cmd.Parameters.AddWithValue("@Designation", DesignationBox.Text);
                    cmd.Parameters.AddWithValue("@Joining_Date", JoiningDate.Value);
                    cmd.Parameters.AddWithValue("@Image_Dir", ProfilePage.img_Dir);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Succesfully");
                }catch(Exception ex)
                {
                    MessageBox.Show("Please Run Xampp Services or"+ex.Message);
                }

            }
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

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeApp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
