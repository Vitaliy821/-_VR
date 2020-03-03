using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseMove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

   
            this.MouseMove += Form1_MouseMove;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)

        {
            int delta = 50;
            int speed = 2;
            int invis = 100;

            if (button1.Location.X + button1.Width >= this.Width)
            {
                button1.Location = new Point(5, button1.Location.Y);
            }
            else if (button1.Location.Y + button1.Height >= this.Height)
            {
                button1.Location = new Point(button1.Location.X, 5);
            }
            else if (button1.Location.X <= 0)
            {
                button1.Location = new Point(this.Width - button1.Width-delta, button1.Location.Y);
            }
            else if (button1.Location.Y <= 0)
            {
                button1.Location = new Point(button1.Location.X, this.Height - button1.Height-delta);
            }
            else if (e.X > button1.Location.X - delta && e.X < button1.Location.X && e.Y > button1.Location.Y - delta && e.Y < button1.Location.Y)
            {
                button1.Location = new Point(button1.Location.X + speed, button1.Location.Y + speed);
            }
            else if (e.X < button1.Location.X + delta && e.X > button1.Location.X && e.Y > button1.Location.Y - delta && e.Y < button1.Location.Y)
            {
                button1.Location = new Point(button1.Location.X, button1.Location.Y + speed);     
                button1.Height--;
            }
            else if (e.X < button1.Location.X + button1.Width + delta && e.X > button1.Location.X && e.Y > button1.Location.Y - delta && e.Y < button1.Location.Y)
            {
                button1.Location = new Point(button1.Location.X - speed, button1.Location.Y + speed);                
            }
            else if (e.X < button1.Location.X + button1.Width + delta && e.X > button1.Location.X && e.Y > button1.Location.Y && e.Y < button1.Location.Y + button1.Height)
            {
                button1.Location = new Point(button1.Location.X - speed, button1.Location.Y);               
            }
            else if (e.X < button1.Location.X + button1.Width + delta && e.X > button1.Location.X + button1.Width && e.Y < button1.Location.Y + button1.Height + delta && e.Y > button1.Location.Y + button1.Height)
            {
                button1.Location = new Point(button1.Location.X - speed, button1.Location.Y - speed);               
            }
            else if (e.X < button1.Location.X + button1.Width && e.X > button1.Location.X && e.Y < button1.Location.Y + button1.Height + delta && e.Y > button1.Location.Y + button1.Height)
            {
                button1.Location = new Point(button1.Location.X, button1.Location.Y - speed);
                button1.Height--;                
            }
            else if (e.X > button1.Location.X - delta && e.X < button1.Location.X && e.Y < button1.Location.Y + button1.Height + delta && e.Y > button1.Location.Y + button1.Height)
            {
                button1.Location = new Point(button1.Location.X + speed, button1.Location.Y - speed);                  
            }
            else if (e.X > button1.Location.X - delta && e.X < button1.Location.X && e.Y > button1.Location.Y + button1.Height - delta && e.Y < button1.Location.Y + button1.Height)
            {
                button1.Location = new Point(button1.Location.X + speed, button1.Location.Y);             
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "Click button 'ok'";
            timer1.Enabled = false;
            timer2.Enabled = true;
        }  
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Text = "";
            timer1.Enabled = true;
            timer2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
