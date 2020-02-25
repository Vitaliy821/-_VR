using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        float a, b;
        bool sign = true;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            int i, j, c, count;
            int PosX, PosY;
            
            c = 1;
            PosX = 0;
            PosY = 170;
            for(i = 0; i < 3; i++)
            {
                PosX = 200;
                for (j = 0; j < 3; j++)
                {
                    Button button = new Button();
                    button.Visible = true;
                    button.Text = (c++).ToString();
                    button.Size = new Size(60, 30);
                    button.Location = new Point(PosX, PosY);
                    PosX += 70;
                    button.Click += Button_Click;
                    this.Controls.Add(button);
                    
                }
                PosY += 40;
            }

            Button zero = new Button();
            zero.Visible = true;
            zero.Text = (0).ToString();
            zero.Size = new Size(60, 30);
            zero.Location = new Point(270, 290);
            zero.Click += Button_Click;
            this.Controls.Add(zero);

            Button dot = new Button();
            dot.Visible = true;
            dot.Text = ".";
            dot.Size = new Size(60, 30);
            dot.Location = new Point(200, PosY);
            dot.Click += Button_Click;
            this.Controls.Add(dot);

            Button bracket_left = new Button();
            bracket_left.Visible = true;
            bracket_left.Text = "(";
            bracket_left.Size = new Size(60, 30);
            bracket_left.Location = new Point(200, 130);
            bracket_left.Click += Button_Click;
            this.Controls.Add(bracket_left);


            Button bracket_right = new Button();
            bracket_right.Visible = true;
            bracket_right.Text = ")";
            bracket_right.Size = new Size(60, 30);
            bracket_right.Location = new Point(270, 130);
            bracket_right.Click += Button_Click;
            this.Controls.Add(bracket_right);


            Button button_del = new Button();
            button_del.Visible = true;
            button_del.Text = "<-";
            button_del.Size = new Size(60, 30);
            button_del.Location = new Point(340, 130);
            button_del.Click += Button_Click_Del;
            this.Controls.Add(button_del);


            Button button_del_all = new Button();
            button_del_all.Visible = true;
            button_del_all.Text = "C";
            button_del_all.Size = new Size(60, 30);
            button_del_all.Location = new Point(410, 130);
            button_del_all.Click += Button_Click_Del_All;
            this.Controls.Add(button_del_all);


            Button button_add = new Button();
            button_add.Visible = true;
            button_add.Text = "+";
            button_add.Size = new Size(60, 30);
            button_add.Location = new Point(410, 170);
            button_add.Click += Button_Click_Add;
            this.Controls.Add(button_add);

            Button button_sub = new Button();
            button_sub.Visible = true;
            button_sub.Text = "-";
            button_sub.Size = new Size(60, 30);
            button_sub.Location = new Point(410, 210);
            button_sub.Click += Button_Click_Sub;
            this.Controls.Add(button_sub);

            Button button_multi = new Button();
            button_multi.Visible = true;
            button_multi.Text = "*";
            button_multi.Size = new Size(60, 30);
            button_multi.Location = new Point(410, 250);
            button_multi.Click += Button_Click_Multi;
            this.Controls.Add(button_multi);

            Button button_div = new Button();
            button_div.Visible = true;
            button_div.Text = "/";
            button_div.Size = new Size(60, 30);
            button_div.Location = new Point(410, 290);
            button_div.Click += Button_Click_Div;
            this.Controls.Add(button_div);

            Button button_calculate = new Button();
            button_calculate.Visible = true;
            button_calculate.Text = "=";
            button_calculate.Size = new Size(60, 30);
            button_calculate.Location = new Point(340, 290);
            button_calculate.Click += Button_Click_Calculate;
            this.Controls.Add(button_calculate);


        }

        private void Button_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text += (sender as Button).Text;
        }

        private void Button_Click_Del(object sender, EventArgs e)
        {
            int lenght = richTextBox1.Text.Length - 1;
            string text = richTextBox1.Text;
            richTextBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                richTextBox1.Text = richTextBox1.Text + text[i];
            }
        }

        private void Button_Click_Del_All(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void Button_Click_Add(object sender, EventArgs e)
        {
            a = float.Parse(richTextBox1.Text);
            richTextBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            sign = true;
        }

        private void Button_Click_Sub(object sender, EventArgs e)
        {
            a = float.Parse(richTextBox1.Text);
            richTextBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            sign = true;
        }

        private void Button_Click_Multi(object sender, EventArgs e)
        {
            a = float.Parse(richTextBox1.Text);
            richTextBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            sign = true;
        }

        private void Button_Click_Div(object sender, EventArgs e)
        {
            a = float.Parse(richTextBox1.Text);
            richTextBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            sign = true;
        }

        private void Button_Click_Calculate(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }


        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(richTextBox1.Text);
                    richTextBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(richTextBox1.Text);
                    richTextBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(richTextBox1.Text);
                    richTextBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(richTextBox1.Text);
                    richTextBox1.Text = b.ToString();
                    break;

                default:
                    break;
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
    }
}
