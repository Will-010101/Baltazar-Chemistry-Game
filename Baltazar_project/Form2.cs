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

namespace Baltazar_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pb_score.Visible = false;
            pb_aboutus.Visible = false;
            pbhomef2C.Visible = false;
            rezome.Visible = false;
            pb_logo_az.Visible = false;
            pb_logo_pf.Visible = false;
            pb_logo_sam.Visible = false;
            label1.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
        }

        private void button_aboutus_MouseEnter(object sender, EventArgs e)
        {
            button_aboutus.Height -= 3;
            button_aboutus.Width -= 3;
            button_aboutus.Top -= 3;
            button_aboutus.Left -= 3;
            pb_aboutus.Visible = true;
        }

        private void button_aboutus_MouseLeave(object sender, EventArgs e)
        {
            button_aboutus.Height += 3;
            button_aboutus.Width += 3;
            button_aboutus.Top += 3;
            button_aboutus.Left += 3;
            pb_aboutus.Visible = false;
           
        }

        private void button_aboutus_Click(object sender, EventArgs e)
        {
            button_aboutus.Location = new Point(104, 92);
            button_Score.Location = new Point(104, 400);
            rezome.Visible = true;
            pb_logo_az.Visible = true;
            pb_logo_pf.Visible = true;
            pb_logo_sam.Visible = true;
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
        }

        private void button_Score_MouseEnter(object sender, EventArgs e)
        {
            button_Score.Height -= 3;
            button_Score.Width -= 3;
            button_Score.Top -= 3;
            button_Score.Left -= 3;
            pb_score.Visible = true;
            pb_score.Location = new Point(42, button_Score.Location.Y);
        }

        private void button_Score_MouseLeave(object sender, EventArgs e)
        {
            button_Score.Height += 3;
            button_Score.Width += 3;
            button_Score.Top += 3;
            button_Score.Left += 3;
            pb_score.Visible = false;
        }
        string em2, kha2;
        int em, kha,dar;
        private void button_Score_Click(object sender, EventArgs e)
        {
            button_aboutus.Location = new Point(104, 92);
            button_Score.Location = new Point(104, 150);
            rezome.Visible = false;
            pb_logo_az.Visible = false;
            pb_logo_pf.Visible = false;
            pb_logo_sam.Visible = false;
            label1.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            StreamReader sr = File.OpenText("khata");
            kha2 = sr.ReadLine();
            sr.Close();
            StreamReader sb = File.OpenText("emtiazat");
            em2 = sb.ReadLine();
            sb.Close();
            kha = Convert.ToInt16(kha2);
            em = Convert.ToInt16(em2);
            if (em + kha != 0)
                dar = (em * 100) / (em + kha);
            else
                dar = 0;
            label1.Text = "امتیازات شما          " + em2 + "\nخطا های شما          " + kha2 + "\nعملکرد شما        " + dar.ToString()+"%";
        }
        private void pbhomef2C_Click(object sender, EventArgs e)
        {
        }
        private void pbhomef2_Click(object sender, EventArgs e)
        {
        }

        private void pbhomef2_MouseEnter(object sender, EventArgs e)
        {
            pbhomef2C.Visible = true;
            pbhomef2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream stream = Properties.Resources.aaa;
            SoundPlayer player = new SoundPlayer(stream);
            player.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stream stream = Properties.Resources.aaa;
            SoundPlayer player = new SoundPlayer(stream);
            player.Stop();
        }

        private void pbhomef2_MouseLeave(object sender, EventArgs e)
        {
            pbhomef2C.Visible = false;
            pbhomef2.Visible = true;
        }

        private void pbhomef2_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
           
        }

        private void pb_logo_az_Click(object sender, EventArgs e)
        {

        }
    }
}
