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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        float count;
        float vazn, ghad, bmi,faren;
        string vazn1, ghad1,faren1;
        private void Form6_Load(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            l7.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
        }
        
        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)//////////////////
        {
            
            if (count == 1)
            {
                vazn1 = textBox1.Text;
                ghad1 = textBox2.Text;
                vazn = Convert.ToInt16(vazn1);
                ghad = Convert.ToInt16(ghad1);
                bmi = 10000 * vazn / (ghad * ghad);
                if (bmi < 18.5)
                {
                    l7.ForeColor = Color.Red;
                    Console.Beep();
                    l7.Text = "BMI=" + bmi + "\n\n\n" + "!!! شما دچار کمبود وزن هستید\n" + "با مصرف تمامی گروه های غذایی از جمله پروتئین و نان و غلات و لبنیات وزن خود را به اندازه نرمال افزایش دهید";
                }
                if (bmi >= 18.5 && bmi < 25)
                {
                    l7.ForeColor = Color.Gold;
                    l7.Text = "BMI=" + bmi + "\n\n\n" + "وزن شما نرمال است\n" + "رژیم مناسبی دارید با همین روش ادامه دهید و وزن خود را نرمال نگه دارید";
                }
                if (bmi >= 25 && bmi < 30)
                {
                    l7.ForeColor = Color.Gold;
                    Console.Beep();
                    l7.Text = "BMI=" + bmi + "\n\n\n" + "!شما دارای اضافه وزن هستید\n" + "سعی کنید سیستم غذایی خود را کنترل کنید و کمتر مواد قندی مصرف نمایید";

                }
                if (bmi >= 30 && bmi < 35)
                {
                    l7.ForeColor = Color.OrangeRed;
                    Console.Beep();
                    l7.Text = "BMI=" + bmi + "\n\n\n" + "!! شما چاق هستید \n" + "سعی کنید با مصرف کمتر مواد قندی و کمتر کردن حجم غذایی وزن خود را به محدوده ایده ال برسانید ";
                }
                if (bmi > 35)
                {
                    l7.ForeColor = Color.Red;
                    Console.Beep();
                    l7.Text = "BMI=" + bmi + "\n\n\n" + "!!! وزن شما در محدوده غیرمجاز است\n" + "سعی کنید رژیم غذایی خود را تغییر دهید و به پزشک مراجعه کنید تا با برنامه غذایی درست وزن خود را به محدوده ایده ال برسانید";
                }
            }
            if (count == 2)
            {
                faren1 = textBox1.Text;
                faren = Convert.ToInt16(faren1);
                faren = 9 * faren / 5 + 32;
                l7.ForeColor = Color.Turquoise;
                l7.Text = "دما به فارنهایت می شود:" + "\n\n\n" + faren;
            }
            if (count == 3)
            {
                faren1 = textBox1.Text;
                faren = Convert.ToInt16(faren1);
                faren += 273;
                l7.ForeColor = Color.Turquoise;
                l7.Text = "دما به کلوین می شود:" + "\n\n\n" + faren;
            }
            if (count == 4)
            {
                vazn1 = textBox1.Text;
                ghad1 = textBox2.Text;
                vazn = Convert.ToInt16(vazn1);
                ghad = Convert.ToInt16(ghad1);
                bmi = 10 * vazn * ghad;
                l7.ForeColor = Color.Turquoise;
                l7.Text = "فشار مایع می شود:" + "\n\n\n" + bmi + "پاسکال";
            }
            if (count == 5)
            {
                vazn1 = textBox1.Text;
                ghad1 = textBox2.Text;
                vazn = Convert.ToInt16(vazn1);
                ghad = Convert.ToInt16(ghad1);
                bmi = vazn / ghad;
                l7.ForeColor = Color.Turquoise;
                l7.Text = "چگالی می شود:" + "\n\n\n" + bmi + "کیلوگرم بر مترمکعب";
            }
            if (count == 6)
            {
                vazn1 = textBox1.Text;
                ghad1 = textBox2.Text;
                vazn = Convert.ToInt16(vazn1);
                ghad = Convert.ToInt16(ghad1);
                bmi = vazn * ghad * 10;
                l7.ForeColor = Color.Turquoise;
                l7.Text = "نیروی شناوری می شود:" + "\n\n\n" + bmi + "نیوتن";
            }
            l7.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Height -= 3;
            button1.Width -= 3;
            button1.Top -= 3;
            button1.Left -= 3;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Height += 3;
            button1.Width += 3;
            button1.Top += 3;
            button1.Left += 3;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Height -= 3;
            button2.Width -= 3;
            button2.Top -= 3;
            button2.Left -= 3;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Height += 3;
            button2.Width += 3;
            button2.Top += 3;
            button2.Left += 3;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Height -= 3;
            button3.Width -= 3;
            button3.Top -= 3;
            button3.Left -= 3;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Height += 3;
            button3.Width += 3;
            button3.Top += 3;
            button3.Left += 3;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.Height -= 3;
            button4.Width -= 3;
            button4.Top -= 3;
            button4.Left -= 3;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Height += 3;
            button4.Width += 3;
            button4.Top += 3;
            button4.Left += 3;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.Height -= 3;
            button5.Width -= 3;
            button5.Top -= 3;
            button5.Left -= 3;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.Height += 3;
            button5.Width += 3;
            button5.Top += 3;
            button5.Left += 3;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.Height -= 3;
            button6.Width -= 3;
            button6.Top -= 3;
            button6.Left -= 3;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.Height += 3;
            button6.Width += 3;
            button6.Top += 3;
            button6.Left += 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Text = "*-* وزن خود را به کیلوگرم وارد کنید";
            label2.Text = "*-* قد خود را به متر وارد کنید";
            textBox1.Text = "";
            textBox2.Text = "";
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            count = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            textBox1.Visible = true;
            label1.Visible = true;
            label1.Text = "^-^ دما را به سانتیگراد وارد کنید";
            label2.Visible = false;
            textBox1.Text = "";
            textBox2.Visible = false;
            count = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            label1.Visible = true;
            label2.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = false;
            label1.Text = "^-^ دما را به سانتیگراد وارد کنید";
            textBox1.Text = "";
            count = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Text = "^-^ چگالی مایع را به واحد\n کیلوگرم بر متر مکعب وارد کنید";
            label2.Text = "^-^ ارتفاع را به متر وارد کنید";
            textBox1.Text = "";
            textBox2.Text = "";
            count = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Text = "^-^ جرم را به کیلوگرم وارد کنید";
            label2.Text = "^-^ حجم را به مترمکعب وارد کنید";
            textBox1.Text = "";
            textBox2.Text = "";
            count = 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Text = "^-^ چگالی مایع را به واحد \nکیلوگرم بر متر مکعب وارد کنید";
            label2.Text = "^-^ حجم را به مترمکعب وارد کنید";
            textBox1.Text = "";
            textBox2.Text = "";
            count = 6;
        }
    }
}
