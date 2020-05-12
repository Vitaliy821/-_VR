using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace directory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path = @"D:\C#_works\directory";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <101;i++)
            Directory.CreateDirectory(path + @"\Folder_" + i);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 101; i++)
                Directory.Delete(path + @"\Folder_" + i);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            for (int i = 1; i < 101; i++)
            { 
                string addPath = path + @"\Folder_" + i;
                Directory.CreateDirectory(addPath + @"\Folder_" + i);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 101; i++)
            {
                string addPath = path + @"\Folder_" + i;
                Directory.Delete(addPath + @"\Folder_" + i);
            }

            for (int i = 1; i < 101; i++)
            {
                Directory.Delete(path + @"\Folder_" + i);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int count = 0;
            string addPath = path + @"\Folder";
            try
            {
                while (true)
                {
                    Directory.CreateDirectory(addPath + @"\Folder_" + count);
                    addPath = addPath + @"\Folder_" + count;
                    count++;
                }
            }
            catch
            {
                this.textBox1.Text = count.ToString() + " maximum";
            }
            //maximum 22
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i = 0;
            string addPath = path + @"\" + i.ToString();
            string str = addPath + i.ToString();
            try
            {
                while (true)
                {
                    str = str + i.ToString();
                    addPath = str;
                    Directory.CreateDirectory(addPath);
                    Directory.Delete(addPath);
                    i++;
                }
            }
            catch
            {
                this.textBox2.Text = str.Length.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<string> files = GetFiles(@"D:\", textBox3.Text);
            if (files.Count > 0)
            {
                MessageBox.Show("Found!");
                StreamReader reader = new StreamReader(files.First(), Encoding.Default);
                Form2 newf = new Form2(reader);
                reader.Close();
                newf.Show();

            }
            else
                MessageBox.Show("Not found!");
        }

        private List<string> GetFiles(string path, string file)
        {
            var files = new List<string>();

            try
            {
                files.AddRange(Directory.GetFiles(path, file, SearchOption.TopDirectoryOnly));
                foreach (var dir in Directory.GetDirectories(path))
                    files.AddRange(GetFiles(dir, file));
            }
            catch (Exception ex) { }

            return files;
        }
    }
    
}
