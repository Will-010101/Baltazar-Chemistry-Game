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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int count;
        private void pbnext_MouseEnter(object sender, EventArgs e)
        {
            pbnextC.Visible = true;
        }

        private void pbnext_MouseLeave(object sender, EventArgs e)
        {
            pbnextC.Visible = false;
        }

        private void pbnext_MouseDown(object sender, MouseEventArgs e)
        {
            count++;
            if (count == 0)
            {
                help1.Visible = true;
                help2.Visible = false;
                help3.Visible = false;
                help4.Visible = false;
                help5.Visible = false;
                help6.Visible = false;
            }
            if (count == 1)
            {
                help1.Visible = false;
                help2.Visible = true;
                help3.Visible = false;
                help4.Visible = false;
                help5.Visible = false;
                help6.Visible = false;
            }
            if (count == 2)
            {
                help1.Visible = false;
                help2.Visible = false;
                help3.Visible = true;
                help4.Visible = false;
                help5.Visible = false;
                help6.Visible = false;
            }
            if (count == 3)
            {
                help1.Visible = false;
                help2.Visible = false;
                help3.Visible = false;
                help4.Visible = true;
                help5.Visible = false;
                help6.Visible = false;
            }
            if (count == 4)
            {
                help1.Visible = false;
                help2.Visible = false;
                help3.Visible = false;
                help4.Visible = false;
                help5.Visible = true;
                help6.Visible = false;
            }
            if (count == 5)
            {
                help1.Visible = false;
                help2.Visible = false;
                help3.Visible = false;
                help4.Visible = false;
                help5.Visible = false;
                help6.Visible = true;
            }
            if (count == 6)
            {
                count = 0;
                help1.Visible = true;
                help2.Visible = false;
                help3.Visible = false;
                help4.Visible = false;
                help5.Visible = false;
                help6.Visible = false;
            }
        }
        
        private void Form3_Load(object sender, EventArgs e) ///////////////////////////
        {
            pbnextC.Visible = false;
            pbhomef3C.Visible = false;
            count = 0;
            help1.Visible = true;
            help2.Visible = false;
            help3.Visible = false;
            help4.Visible = false;
            help5.Visible = false;
            help6.Visible = false;
        }

        private void pbhomef3_MouseEnter(object sender, EventArgs e)
        {
            pbhomef3C.Visible = true;
        }

        private void pbhomef3_MouseLeave(object sender, EventArgs e)
        {
            pbhomef3C.Visible = false;
        }

        private void pbhomef3_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
            
        }
    }
}
