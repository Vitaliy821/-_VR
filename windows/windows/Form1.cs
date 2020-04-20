using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows
{
    public partial class Form1 : Form
    {
        int count = 100;
        int counter_windows = 0;
        public Form1()
        {
            InitializeComponent();
            this.toolStripTextBox1.Text = counter_windows.ToString();
            this.toolStripTextBox2.Text = "Child";
            this.toolStripTextBox3.Text = count.ToString();
            this.toolStripComboBox1.Text = ("Increment Num");
            this.toolStripComboBox1.Items.Add("Increment Num");
            this.toolStripComboBox1.Items.Add("Decrement Num");
            this.toolStripComboBox1.Items.Add("Same Num");
        }

      
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form newMDIChild = new Form();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
            if(this.toolStripComboBox1.Text == "Increment Num") count++;
            if (this.toolStripComboBox1.Text == "Decrement Num") count--;
            this.toolStripTextBox3.Text = count.ToString();
            counter_windows++;
            this.toolStripTextBox1.Text = counter_windows.ToString();
            newMDIChild.Text = this.toolStripTextBox2.Text + " " + this.toolStripTextBox3.Text;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
