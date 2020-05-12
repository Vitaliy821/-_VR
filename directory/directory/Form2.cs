using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace directory
{
    public partial class Form2 : Form
    {
        public Form2(System.IO.StreamReader reader)
        {
            InitializeComponent();
            richTextBox1.Text = reader.ReadToEnd();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
