using Microsoft.Win32;
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

namespace work_with_register
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();

            this.FormClosing += Form1_FormClosing;
            /*XML
            textBox1.Text = Properties.Settings.Default.text_box;
            checkBox1.Checked = Properties.Settings.Default.check_box1;
            checkBox2.Checked = Properties.Settings.Default.check_box2;
            this.Width = Properties.Settings.Default.width;
            this.Height = Properties.Settings.Default.height;
            this.Location = new Point(Properties.Settings.Default.x, Properties.Settings.Default.y);
            Properties.Settings.Default.Save();
            */


            /*TXT
            System.IO.File.AppendAllText(@"D:\\C#_works\\work_with_register\\file1.txt", null);
            System.IO.StreamReader file = new System.IO.StreamReader(@"D:\\C#_works\\work_with_register\\file1.txt");
            using (file)
            {
                try
                {
                    textBox1.Text = file.ReadLine(); ;
                    checkBox1.Checked = Convert.ToBoolean(file.ReadLine());
                    checkBox2.Checked = Convert.ToBoolean(file.ReadLine());
                    this.Width = Int32.Parse(file.ReadLine());
                    this.Height = Int32.Parse(file.ReadLine());
                    this.Location = new Point(Int32.Parse(file.ReadLine()), Int32.Parse(file.ReadLine()));
                }
                catch { }

            }
            */

            /*BINARY
            string path = @"D:\\C#_works\\work_with_register\\states.dat";
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
               
                while (reader.PeekChar() > -1)
                {
                    textBox1.Text = reader.ReadString();
                    checkBox1.Checked = reader.ReadBoolean();
                    checkBox2.Checked = reader.ReadBoolean();
                    this.Width = reader.ReadInt32();
                    this.Height = reader.ReadInt32();
                    this.Location = new Point(reader.ReadInt32(), reader.ReadInt32());
                }
            }
            */

            /*REGISTRY*/
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\myProgramm");
            textBox1.Text = key.GetValue("textBox1").ToString();
            checkBox1.Checked = Convert.ToBoolean(key.GetValue("checkBox1"));
            checkBox2.Checked = Convert.ToBoolean(key.GetValue("checkBox2"));
            this.Width = Convert.ToInt32(key.GetValue("Width"));
            this.Height = Convert.ToInt32(key.GetValue("Height"));
            this.Location = new Point(Convert.ToInt32(key.GetValue("X")), Convert.ToInt32(key.GetValue("Y")));
            key.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, EventArgs e)
        {
            /*XML
            Properties.Settings.Default.text_box = this.textBox1.Text;
            Properties.Settings.Default.check_box1 = this.checkBox1.Checked;
            Properties.Settings.Default.check_box2 = this.checkBox2.Checked;
            Properties.Settings.Default.width = this.Width;
            Properties.Settings.Default.height = this.Height;
            Properties.Settings.Default.x = this.Location.X;
            Properties.Settings.Default.y = this.Location.Y;
            Properties.Settings.Default.Save();
            */
            /*TXT
            string path = @"D:\\C#_works\\work_with_register\\file1.txt";
            using (StreamWriter sw = new StreamWriter(path, false))
            {

                sw.WriteLine(textBox1.Text);
                sw.WriteLine(this.checkBox1.Checked);
                sw.WriteLine(this.checkBox2.Checked);
                sw.WriteLine(this.Width);
                sw.WriteLine(this.Height);
                sw.WriteLine(this.Location.X);
                sw.WriteLine(this.Location.Y);
            }
            */
            /*BINARY
             string path = @"D:\\C#_works\\work_with_register\\states.dat";
                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
                {
                    writer.Write(textBox1.Text);
                    writer.Write(this.checkBox1.Checked);
                    writer.Write(this.checkBox2.Checked);
                    writer.Write(this.Width);
                    writer.Write(this.Height);
                    writer.Write(this.Location.X);
                    writer.Write(this.Location.Y);
                }
            */
            /*REGISTRY*/
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\myProgramm");
            key.SetValue("textBox1", textBox1.Text);
            key.SetValue("checkBox1", this.checkBox1.Checked);
            key.SetValue("checkBox2", this.checkBox2.Checked);
            key.SetValue("Width", this.Width);
            key.SetValue("Height", this.Height);
            key.SetValue("X", this.Location.X);
            key.SetValue("Y", this.Location.Y);
            key.Close();
        }
    }
}
