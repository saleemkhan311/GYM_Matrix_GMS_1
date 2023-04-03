using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace GYM_Matrix
{
    public partial class ProfilePage : Form
    {
        public static string img_Dir;
        string Name;
        int imageInceament;
        bool isStreaming = false;
        VideoCaptureDevice videoCapture;
        FilterInfoCollection filterInfo;
        public ProfilePage(string name)
        {
            InitializeComponent();
            Name = name;
        }

        private void StartCamera_Click(object sender, EventArgs e)
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
        }

        private void Cam_On(object sender, NewFrameEventArgs eventArgs)
        {
            CamBox.Image = (Bitmap)eventArgs.Frame.Clone();
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
                this.Close();
            }

        }

        private void CaptureButton(object sender, EventArgs e)
        {
            if (isStreaming)
            {
                PicBox.Image = CamBox.Image;
            }
            else { MessageBox.Show("Turn on Camera"); }
           

        }

        private void SavePicBtton_Click(object sender, EventArgs e)
        {
            imageInceament++;

            try
            {
                if (isStreaming)
                {
                    if (PicBox.Image == null)
                    {
                        MessageBox.Show("Please Capture Image Or Browse to Save");
                        return;
                    }
                    img_Dir = @"C:\GYM_Matrix\MembersProfiles\" + Name +imageInceament.ToString()+ ".jpg";
                    var bitmap = new Bitmap(PicBox.Width, PicBox.Height);
                    PicBox.DrawToBitmap(bitmap, PicBox.ClientRectangle);
                    System.Drawing.Imaging.ImageFormat imageFormat = null;
                    imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
                    bitmap.Save(img_Dir);
                    AddMemebers addm = new AddMemebers();
                  
                    MessageBox.Show("Image Saved To "+img_Dir);

                }
            }
            catch (Exception ex)
            {

                if (ex.Message == "A generic error occured in GDI+")
                {
                    MessageBox.Show(ex.Message);
                    
                }
            }


        }

        private void BrowseButon(object sender, EventArgs e)
        {
            if (!isStreaming)
            {
                openFileDialog1.ShowDialog();
                try
                {
                    img_Dir = openFileDialog1.FileName;
                    PicBox.Image = Image.FromFile(img_Dir);
                    AddMemebers addm = new AddMemebers();
                    addm.ProfileBox.Image = Image.FromFile(img_Dir);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not Selected any picture");
                }


            }
            else
            {
                MessageBox.Show("Stop The Camera To Browse Image");
            }

        }
    }
}
