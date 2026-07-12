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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            pbsettingf1.Visible = false;
            progressBarlood.Visible = true;
            labellood.Visible = true;
            pictureBoxlood.Visible = true;
            pbselect.Visible = false;
            pbclose.Visible = false;
            pbcloseC.Visible = false;
            pbsettingf1C.Visible = false;
            pbperpell.Visible = false;
            labperpellC.Visible = false;
            lab_perpell.Visible = false;
            lab_greenC.Visible = false;
            lab_green.Visible = false;
            pbgreen.Visible = false;
            pb_di_perpell.Visible = false;
            pb_di_green.Visible = false;
            lab_orengeC.Visible = false;
            lab_orenge.Visible = false;
            pb_di_orenge.Visible = false;
            pborenge.Visible = false;
            lab_yellow.Visible = false;
            lab_yellowC.Visible = false;
            pb_di_yellow.Visible = false;
            pbyellow.Visible = false;
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            timerlood.Start();
        }

        private void timerlood_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter<=100)
            {
                
                progressBarlood.Visible = false;
                labellood.Visible = false;
                axWindowsMediaPlayer1.Visible =true;
                //axWindowsMediaPlayer1.URL = @"C:\Users\blueNoteBooResources\film.mp4";
                //axWindowsMediaPlayer1.Ctlcontrols.play();
                var strTempFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "film.mp4");

                try
                {
                    // ResourceName = the resource you want to play
                    File.WriteAllBytes(strTempFile, Properties.Resources.film);
                    axWindowsMediaPlayer1.URL = strTempFile;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                catch (Exception ex)
                {

                    // Manage me
                }
            }
            if(counter>100 && counter<200)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                progressBarlood.Value = (counter - 100) ;
                axWindowsMediaPlayer1.Visible = false;
                progressBarlood.Visible = true;
                
            }
            if(counter>200)
            {
                timerlood.Stop();
                progressBarlood.Visible = false;
                labellood.Visible = false;
                pictureBoxlood.Visible = false;
                pbsettingf1.Visible = true;
                pbselect.Visible = true;
                pbclose.Visible = true;
                pbsettingf1.Visible = true;
                lab_perpell.Visible = true;
                lab_green.Visible = true;
                lab_orenge.Visible = true;
                lab_yellow.Visible = true;
                pictureBox1.Visible = true;
                Stream stream = Properties.Resources.aaa;
                SoundPlayer player = new SoundPlayer(stream);
                player.Play();
            }
        }

        private void pbsettingf1_Click(object sender, EventArgs e)
        {
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
        }

        private void pbclose_MouseEnter(object sender, EventArgs e)
        {
            pbcloseC.Visible = true;
            pbclose.Visible = false;
        }

        private void pbclose_MouseLeave(object sender, EventArgs e)
        {
            pbcloseC.Visible = false;
            pbclose.Visible = true;
        }

        private void pbcloseC_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void pbclose_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void pbsettingf1_MouseEnter(object sender, EventArgs e)
        {
            pbsettingf1C.Visible = true;
            pbsettingf1.Visible = false;
        }

        private void pbsettingf1_MouseLeave(object sender, EventArgs e)
        {
            pbsettingf1C.Visible = false;
            pbsettingf1.Visible = true;
        }

        private void pbsettingf1_MouseDown(object sender, MouseEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void lab_perpell_MouseEnter(object sender, EventArgs e)
        {
            pbperpell.Visible = true;
            labperpellC.Visible = true;
            pb_di_perpell.Visible = true;
        }

        private void lab_perpell_MouseLeave(object sender, EventArgs e)
        {
            pbperpell.Visible = false;
            labperpellC.Visible = false;
            pb_di_perpell.Visible = false;
        }

        private void labperpellC_Click(object sender, EventArgs e)
        {

        }

        private void lab_green_MouseEnter(object sender, EventArgs e)
        {
            pbgreen.Visible = true;
            lab_greenC.Visible = true;
            pb_di_green.Visible = true;
        }

        private void lab_green_MouseLeave(object sender, EventArgs e)
        {
            pbgreen.Visible = false;
            lab_greenC.Visible = false;
            pb_di_green.Visible = false;
        }

        private void lab_orenge_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void lab_orenge_DragLeave(object sender, EventArgs e)
        {
            
        }

        private void lab_orenge_MouseEnter(object sender, EventArgs e)
        {
            pborenge.Visible = true;
            lab_orengeC.Visible = true;
            pb_di_orenge.Visible = true;
        }

        private void lab_orenge_MouseLeave(object sender, EventArgs e)
        {
            pborenge.Visible = false;
            lab_orengeC.Visible = false;
            pb_di_orenge.Visible = false;
        }

        private void lab_yellow_MouseEnter(object sender, EventArgs e)
        {
            pbyellow.Visible = true;
            lab_yellowC.Visible = true;
            pb_di_yellow.Visible = true;
        }

        private void lab_yellow_MouseLeave(object sender, EventArgs e)
        {
            pbyellow.Visible = false;
            lab_yellowC.Visible = false;
            pb_di_yellow.Visible = false;
        }

        private void lab_yellow_MouseDown(object sender, MouseEventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void lab_perpell_MouseDown(object sender, MouseEventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void lab_orenge_MouseDown(object sender, MouseEventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void lab_green_MouseDown(object sender, MouseEventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void pbselect_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }
    }
}
