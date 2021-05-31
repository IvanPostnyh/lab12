using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int pop = -1;
        string texter_1 = "";
        string texter_2 = "";

        private void button1_Click(object sender, EventArgs e)
        {
            pop++;
            textBox1.Text = "";
            int[] kom_ln = new int[8] { 3, 5, 7, 4, 6, 5, 2, 7 };
            string[] kom_name = new string[8];
            kom_name[0] = label1.Text;
            kom_name[1] = label2.Text;
            kom_name[2] = label3.Text;
            kom_name[3] = label4.Text;
            kom_name[4] = label5.Text;
            kom_name[5] = label6.Text;
            kom_name[6] = label7.Text;
            kom_name[7] = label8.Text;
            string[] first_thor_label = new string[8];
            Management management = new Management();



            if (pop == 0)
            {


                textBox1.Text += "Первый раунд." + Environment.NewLine;
                textBox1.Text += "--------------------------------------------" + Environment.NewLine;
                for (int i = 0; i <= 7; i = i + 2)
                {
                    textBox1.Text += management.Match(i, i + 1, kom_name, kom_ln);
                    if (management.winner[i] == 1)
                    {
                        first_thor_label[i] = kom_name[i];
                    }
                    else
                    {
                        first_thor_label[i] = kom_name[i + 1];

                    }
                }

                label10.Text = kom_name[management.win[0]];
                label11.Text = kom_name[management.win[1]];
                label12.Text = kom_name[management.win[2]];
                label13.Text = kom_name[management.win[3]];
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;






                texter_1 += "Второй раунд." + Environment.NewLine;
                texter_1 += "--------------------------------------------" + Environment.NewLine;

                texter_1 += management.Match(management.win[0], management.win[1], kom_name, kom_ln);
                texter_1 += management.Match(management.win[2], management.win[3], kom_name, kom_ln);

                label14.Text = kom_name[management.win[0]];


                label15.Text = kom_name[management.win[1]];






                texter_2 += "!Финал!" + Environment.NewLine;
                texter_2 += "--------------------------------------------" + Environment.NewLine;
                texter_2 += management.Match(management.win[0], management.win[1], kom_name, kom_ln);
                label16.Text = kom_name[management.win[0]];



            }
            if (pop == 1)
            {
                label14.Visible = true;
                label15.Visible = true;
                textBox1.Text = texter_1;
                texter_1 = "";

            }
            if (pop == 2)
            {
                label16.Visible = true;
                textBox1.Text = texter_2;
                button1.Text = "Новое соревнование";
                texter_2 = "";
            }
            if (pop == 3)
            {
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                button1.Text = "Следующий раунд";
                pop = -1;
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}

