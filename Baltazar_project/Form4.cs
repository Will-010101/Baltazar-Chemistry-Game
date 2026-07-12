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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int count ,  zar ,zar_count,max;
        int cat_yn = 0,ani_yn=0,i,u,ba_c,ba_a;
        string cation, anion;
        string[] cat_moshkhas = { "LI", "NA", "K", "RB", "CS", "FR", "BE", "MG", "CA", "SR", "BA", "RA", "B", "AL", "GA", "IN", "TI", "NH" };
        int[] cat_moshakhas_z = { 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3 };
        string[] cat_na = { "SC", "TL", "V", "CR", "MN", "FE", "CO", "NI", "CU", "ZN", "Y", "ZR", "NB", "MO", "TC", "RU", "RH", "PD", "AG", "CD", "LU", "HF", "TA", "W", "RE", "OS", "IR", "PT", "AU", "HG", "LR", "RF", "BD", "SG", "BH", "HS", "MT", "DS", "RG", "CN" };

        private void pb_tikC_Click(object sender, EventArgs e)
        {

        }

        private void textBox_zar_MouseDown(object sender, MouseEventArgs e)
        {
            textBox_zar.Text = "";
        }

        private void textBox_give_MouseDown(object sender, MouseEventArgs e)
        {
            textBox_give.Text = "";
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.ShowDialog();
        }

        string[] ani = { "N", "P", "AS", "SB", "BI", "MC", "O", "S", "SE", "TE", "PO", "LV", "F", "CL", "BR", "I", "AT", "TS" };
        int[] ani_z = { 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1 };
        private void Form4_Load(object sender, EventArgs e)
        {
            pbhomef4C.Visible = false;
            pb_tikC.Visible = false;
            count = 0;
            lab_give.Text = "کاتیون را وارد کنید (●'◡'●) \n لطفا تمام حروف بزرگ باشد";
            textBox_give.Text = "";
            textBox_give.ForeColor = Color.Black;
            cat_yn = 0;
            zar_count = 0;
            string cation, anion;
            string[] cat_moshkhas = { "LI", "NA", "K", "RB", "CS", "FR", "BE", "MG", "CA", "SR", "BA", "RA", "B", "AL", "GA", "IN", "TI", "NH" };
            int[] cat_moshakhas_z = { 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3 };
            string[] cat_na = { "SC", "TL", "V", "CR", "MN", "FE", "CO", "NI", "CU", "ZN", "Y", "ZR", "NB", "MO", "TC", "RU", "RH", "PD", "AG", "CD", "LU", "HF", "TA", "W", "RE", "OS", "IR", "PT", "AU", "HG", "LR", "RF", "BD", "SG", "BH", "HS", "MT", "DS", "RG", "CN" };
            string[] ani = { "N", "P", "AS", "SB", "BI", "MC", "O", "S", "SE", "TE", "PO", "LV", "F", "CL", "BR", "I", "AT", "TS" };
            int[] ani_z = { 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1 };
            textBox_zar.Visible = false;
            lab_anser.Visible = false;
            pictureBox2.Visible = false;
            pictureBox4.Visible = false;
        }

        private void pbhomef4_MouseEnter(object sender, EventArgs e)
        {
            pbhomef4C.Visible = true;
        }

        private void pbhomef4_MouseLeave(object sender, EventArgs e)
        {
            pbhomef4C.Visible = false;
        }

        private void pbhomef4_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void pbtik_MouseEnter(object sender, EventArgs e)
        {
            pb_tikC.Visible = true;
        }

        private void pbtik_MouseLeave(object sender, EventArgs e)
        {
            pb_tikC.Visible = false;
        }
        
        private void pbtik_MouseDown(object sender, MouseEventArgs e)
        {
            count++;
            if(count==1)
            {
                cation = textBox_give.Text;
                textBox_give.ForeColor = Color.Black;
                for(int i=0;i<40;i++)
                {
                    if(cation==cat_na[i])
                    {
                        cat_yn = 1;
                        zar_count = 1;
                        textBox_zar.Visible = true;
                        textBox_zar.Text = "ظرفیت کاتیون را وارد کنید";
                    }
                }
                for( i=0;i<18;i++)
                {
                    if(cation==cat_moshkhas[i])
                    {
                        lab_give.Text = "آنیون را وارد کنید (●'◡'●) \n لطفا تمام حروف بزرگ باشد";
                        textBox_give.Text = "";
                        textBox_give.ForeColor = Color.Black;
                        cat_yn = 1;
                        ba_c = i;
                        break;
                    }
                }
                if(cat_yn==0)
                {
                    count = 0;
                    lab_give.Text = "کاتیون را وارد کنید (●'◡'●) \n لطفا تمام حروف بزرگ باشد";
                    textBox_give.Text = " !!دوباره امتحان کنید";
                    textBox_give.ForeColor = Color.Red;
                    Console.Beep();
                }
            }
            if(count==2 && zar_count==1)
            {
                string bbbb = textBox_zar.Text;
                zar = Convert.ToInt16(bbbb);
                textBox_zar.Visible = false;
                lab_give.Text = "آنیون را وارد کنید (●'◡'●) \n لطفا تمام حروف بزرگ باشد";
                textBox_give.Text = "";
            }
            if(count==2 && zar_count==0)
            {
                anion = textBox_give.Text;
                for(int u=0;u<18;u++)
                {
                    if(anion==ani[u])
                    {
                        lab_anser.Text = ani[u];
                        ani_yn = 1;
                        textBox_give.Visible = false;
                        textBox_zar.Visible = false;
                        lab_give.Visible = false;
                        lab_anser.Visible = true;
                        pbtik.Visible = false;
                        pb_tikC.Visible = false;
                        ba_a = u;
                        break;
                    }
                }
                if(ani_yn==1)
                {
                    if (cat_moshakhas_z[i] >= ani_z[ba_a])
                        max = cat_moshakhas_z[i];
                    else
                        max = ani_z[ba_a];
                    for(int y=2;y<=max;y++)
                    {
                        if(cat_moshakhas_z[i]%y==0 && ani_z[ba_a] %y==0)
                        {
                            cat_moshakhas_z[i] = cat_moshakhas_z[i] / y;
                            ani_z[ba_a] = ani_z[ba_a] / y;
                        }
                    }
                    ani_z[ba_a].ToString();
                    cat_moshakhas_z[ba_c].ToString();
                    lab_anser.Text = cation+ "(" + ani_z[ba_a] + ")" + anion + "(" + cat_moshakhas_z[ba_c] + ")"; 
                }
                else
                {
                    count = 0;
                    lab_give.Text = "کاتیون را وارد کنید (●'◡'●) \n لطفا تمام حروف بزرگ باشد";
                    textBox_give.Text = " !!دوباره امتحان کنید";
                    textBox_give.ForeColor = Color.Red;
                    Console.Beep();
                }
            }
            if(count==3)
            {
                anion = textBox_give.Text;
                for (int u = 0; u < 18; u++)
                {
                    if (anion == ani[u])
                    {
                        lab_anser.Text = ani[u];
                        ani_yn = 1;
                        textBox_give.Visible = false;
                        textBox_zar.Visible = false;
                        lab_give.Visible = false;
                        lab_anser.Visible = true;
                        pbtik.Visible = false;
                        pb_tikC.Visible = false;
                        ba_a = u;
                        break;
                    }
                }
                if (ani_yn == 1)
                {
                    if (zar >= ani_z[ba_a])
                        max = zar;
                    else
                        max = ani_z[ba_a];
                    for (int y = 2; y <= max; y++)
                    {
                        if (zar % y == 0 && ani_z[ba_a] % y == 0)
                        {
                            zar = zar / y;
                            ani_z[ba_a] = ani_z[ba_a] / y;
                        }
                    }
                    ani_z[ba_a].ToString();
                    zar.ToString();
                    lab_anser.Text = cation + "(" + ani_z[ba_a] + ")" + anion + "(" + zar + ")";
                }
                else
                {
                    count = 0;
                    lab_give.Text = "کاتیون را وارد کنید (●'◡'●) \n لطفا تمام حروف بزرگ باشد";
                    textBox_give.Text = " !!دوباره امتحان کنید";
                    textBox_give.ForeColor = Color.Red;
                    Console.Beep();
                }
            }
        }
    }
}
