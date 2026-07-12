using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baltazar_project
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
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

        private void Form8_Load(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox5.Visible = false;
            pb1.Visible = true;
            label1.Visible = true;
            label2.Visible = false;
        }
        int count = 0;
        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            count++;
            if(count==0)
            {
                pb1.Visible = true;
                label1.Visible = true;
                label2.Visible = false;
            }
            if(count==1)
            {
                count = -1;
                pb1.Visible = false;
                label1.Visible = false;
                label2.Visible = true;
            }

        }
    }
}
