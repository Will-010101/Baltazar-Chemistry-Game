using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Resources;

namespace Baltazar_project
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            /* OpenFileDialog OFD = new OpenFileDialog();
             if(OFD.ShowDialog()==DialogResult.OK)
             {
                 axWindowsMediaPlayer1.URL = OFD.FileName;
             }*/
            pictureBox2.Visible = false;
            comboBox1.Items.Add("موشک نیتروژن مایع😃");
            comboBox1.Items.Add("یخ داغ😜");
            comboBox1.Items.Add("گردباد یخ خشک😁");
            comboBox1.Items.Add("خمیر دندان فیل😉");
            comboBox1.Items.Add("خاموش کردن شمع با دی اکسید کربن🤔");
            p1.Visible = false;
            p2.Visible = false;
            p3.Visible = false;
            p4.Visible = false;
            p5.Visible = false;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "موشک نیتروژن مایع😃")
            {
                var strTempFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "f1.mp4");

                try
                {
                    // ResourceName = the resource you want to play
                    File.WriteAllBytes(strTempFile, Properties.Resources.f1);
                    axWindowsMediaPlayer1.URL = strTempFile;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                catch (Exception ex)
                {


                }
            }
            if (comboBox1.Text == "یخ داغ😜")
            {
                var strTempFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "f2.mp4");

                try
                {
                    // ResourceName = the resource you want to play
                    File.WriteAllBytes(strTempFile, Properties.Resources.f2);
                    axWindowsMediaPlayer1.URL = strTempFile;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                catch (Exception ex)
                {


                }
            }
            if (comboBox1.Text == "گردباد یخ خشک😁")
            {
                var strTempFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "f3.mp4");

                try
                {
                    // ResourceName = the resource you want to play
                    File.WriteAllBytes(strTempFile, Properties.Resources.f3);
                    axWindowsMediaPlayer1.URL = strTempFile;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                catch (Exception ex)
                {


                }
            }
            if (comboBox1.Text == "خمیر دندان فیل😉")
            {
                var strTempFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "f4.mp4");

                try
                {
                    // ResourceName = the resource you want to play
                    File.WriteAllBytes(strTempFile, Properties.Resources.f4);
                    axWindowsMediaPlayer1.URL = strTempFile;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                catch (Exception ex)
                {


                }
            }
            if (comboBox1.Text == "خاموش کردن شمع با دی اکسید کربن🤔")
            {
                var strTempFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "f5.mp4");

                try
                {
                    // ResourceName = the resource you want to play
                    File.WriteAllBytes(strTempFile, Properties.Resources.f5);
                    axWindowsMediaPlayer1.URL = strTempFile;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                catch (Exception ex)
                {


                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "موشک نیتروژن مایع😃")
            {
                p1.Visible = true;
                p2.Visible = false;
                p3.Visible = false;
                p4.Visible = false;
                p5.Visible = false;
            }
            if (comboBox1.Text == "یخ داغ😜")
            {
                p1.Visible = false;
                p2.Visible = true;
                p3.Visible = false;
                p4.Visible = false;
                p5.Visible = false;
            }
            if (comboBox1.Text == "گردباد یخ خشک😁")
            {
                p1.Visible = false;
                p2.Visible = false;
                p3.Visible = true;
                p4.Visible = false;
                p5.Visible = false;
            }
            if (comboBox1.Text == "خمیر دندان فیل😉")
            {
                p1.Visible = false;
                p2.Visible = false;
                p3.Visible = false;
                p4.Visible = true;
                p5.Visible = false;
            }
            if (comboBox1.Text == "خاموش کردن شمع با دی اکسید کربن🤔")
            {
                p1.Visible = false;
                p2.Visible = false;
                p3.Visible = false;
                p4.Visible = false;
                p5.Visible = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            p1.Visible = false;
            p2.Visible = false;
            p3.Visible = false;
            p4.Visible = false;
            p5.Visible = false;
        }
    }
}
