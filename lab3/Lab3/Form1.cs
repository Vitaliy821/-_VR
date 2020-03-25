using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    { 
        List<string> numbers = new List<string>();
        int a;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();

            CreateButtons();
            this.tabPage1.Text = "Завдання 1";
            this.tabPage2.Text = "Завдання 2";
        }

        private void CreateButtons()
        {
            for (int i = 0; i < 16; i++)
            {
                numbers.Add((i + 1).ToString());
            }

            int PosX = 110, PosY = 50;


            for (int i = 0; i < 4; i++)
            {
                PosX = 110;
                for (int j = 0; j < 4; j++)
                {
                    Button button = new Button();
                    button.Visible = true;
                    a = rnd.Next(0, numbers.Count);
                    button.Text = numbers[a];
                    numbers.RemoveAt(a);
                    button.Size = new Size(60, 30);
                    button.Location = new Point(PosX, PosY);
                    PosX += 70;
                    button.Click += Button_Click;
                    tabPage2.Controls.Add(button);
                }
                PosY += 40;
            }
        }

        int position = 1;
        
        

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            int a = Int32.Parse(button.Text);
            if (a == position)
            {
                button.Visible = false;
                position++;
                FillButtons();
            }
            else if (position != 1 && position < 5)
            {
                foreach (var item in this.tabPage2.Controls)
                {
                    if (item is Button)
                    {
                        position = 1;
                        Button btn = item as Button;
                        if (btn.Visible == false) btn.Visible = true;
                        FillButtons();
                    }
                }
            }
            else
            {
                FillButtons();
            }

            if (position == 17)
            {
                this.textBox2.TextAlign = HorizontalAlignment.Center;
                this.textBox2.Text = "Молодець!!!";
            }
        }

        private void FillButtons()
        {
            for (int i = position-1; i < 16; i++)
            {
                numbers.Add((i + 1).ToString());
            }

            foreach (var item in this.tabPage2.Controls)
            {
                if (item is Button)
                {
                    Button button = item as Button;
                    if (button.Visible == true)
                    {
                        a = rnd.Next(0, numbers.Count);
                        button.Text = numbers[a];
                        numbers.RemoveAt(a);
                    }
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(this.textBox1.Text);
            this.textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.RemoveAt(comboBox1.Items.Count-1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
