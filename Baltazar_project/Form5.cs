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

namespace Baltazar_project
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        string[] cat_moshkhas = { "LI", "NA", "K", "RB", "CS", "FR", "BE", "MG", "CA", "SR", "BA", "RA", "B", "AL", "GA", "IN", "TI", "NH" };
        int[] cat_moshakhas_z = { 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3 };
        string[] ani = { "N", "P", "AS", "SB", "BI", "MC", "O", "S", "SE", "TE", "PO", "LV", "F", "CL", "BR", "I", "AT", "TS" };
        int[] ani_z = { 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1 };
        int ra, em, ra1, min1, max1,kha;
        string kha2;
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] cat_moshkhas = { "LI", "NA", "K", "RB", "CS", "FR", "BE", "MG", "CA", "SR", "BA", "RA", "B", "AL", "GA", "IN", "TI", "NH" };
            int[] cat_moshakhas_z = { 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3 };
            string[] ani = { "N", "P", "AS", "SB", "BI", "MC", "O", "S", "SE", "TE", "PO", "LV", "F", "CL", "BR", "I", "AT", "TS" };
            int[] ani_z = { 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1 };
            javab = textBox1.Text;
            if (ani_z[ra1] >= cat_moshakhas_z[ra])
            {
                max1 = ani_z[ra1];
                min1 = cat_moshakhas_z[ra];
            }
            else
            {
                min1 = ani_z[ra1];
                max1 = cat_moshakhas_z[ra];
            }

            for (int y = max1; y > 1; y--)
            {
                if (min1 % y == 0)     //2,3
                {
                    if (max1 % y == 0)
                    {
                        cat_moshakhas_z[ra] /= y;
                        ani_z[ra1] /= y;
                    }
                }
            }
            javabd = cat_moshkhas[ra] + ani_z[ra1] + ani[ra1] + cat_moshakhas_z[ra];
            if (javab == javabd)
            {
                textBox1.ForeColor = Color.Black;
                StreamReader sr = File.OpenText("emtiazat");
                em2 = sr.ReadLine();
                em = Convert.ToInt16(em2);
                em += 1;
                em2 = Convert.ToString(em);
                sr.Close();
                File.WriteAllText("emtiazat", em2);
                label3.Text = em2;
                textBox1.Text = " ";
                Random generator = new Random();
                ra = generator.Next(18);
                ra1 = generator.Next(18);
                label2.Text = cat_moshkhas[ra] + " + " + ani[ra1];
                MessageBox.Show("افرین برو مرحله بعد");
            }
            else
            {
                textBox1.ForeColor = Color.Red;
                textBox1.Text = ":) دوباره امتحان کن";
                Console.Beep();
                StreamReader sr = File.OpenText("khata");
                kha2 = sr.ReadLine();
                kha = Convert.ToInt16(kha2);
                kha += 1;
                kha2 = Convert.ToString(kha);
                sr.Close();
                File.WriteAllText("khata", kha2);
            }
        }

        string em2, javab, javabd;
        private void Form5_Load(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            Random generator = new Random();
            ra = generator.Next(18);
            ra1 = generator.Next(18);
            label2.Text = cat_moshkhas[ra] + " + " + ani[ra1];
           // File.WriteAllText("khata", "0");
            StreamReader sr = File.OpenText("emtiazat");
            em2 = sr.ReadLine();
            label3.Text = em2;
            sr.Close();
            textBox1.ForeColor = Color.Black;
            textBox1.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
