using Maze_kursova;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeKursova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private int CellWid, CellHgt;
        Maze inMaze = new Maze(10, 10);
        Bitmap inBm = new Bitmap(1, 1);

       



        private void createBtn_Click(object sender, EventArgs e)
        {
            
            int width = 0;
            int hight = 0;

            try
            {
                width = int.Parse(txtWidth.Text);
                hight = int.Parse(txtHeight.Text);
                //перевірка розмірів
                if (width <= 0 || hight <= 0)
                {
                    throw new FormatException();
                }

            }
            catch (System.FormatException)
            {
                string message = "The dimension must be a number greater than 0.";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                txtWidth.Text = "10";
                txtHeight.Text = "10";

                return;
            }


            int oddW = 0;
            int oddH = 0;
            //для випадку з непарними розмірами 
            if (width % 2 != 0 && width != 0)
            {
                oddW = 1;
            }
            if (width % 2 != 0 && hight != 0)
            {
                oddH = 1;
            }

            //розраховується ширина і висота клітинки для маштабування
            CellWid = picMaze.ClientSize.Width / (width + 2);
            CellHgt = picMaze.ClientSize.Height / (hight + 2);

           
            int CellMin = 10;
            if (CellWid < CellMin)
            {
                CellWid = CellMin;
                CellHgt = CellWid;
            }
            else if (CellHgt < CellMin)
            {
                CellHgt = CellMin;
                CellWid = CellHgt;
            }
            else if (CellWid > CellHgt) CellWid = CellHgt;
            else CellHgt = CellWid;


            Maze maze = new Maze(width, hight);

           
            maze.finish.X = maze.finish.X + oddW;
            maze.finish.Y = maze.finish.Y + oddH;
            maze.CreateMaze();
            DrawMaze();

            inMaze = maze;

            void DrawMaze()
            {
                inBm.Dispose();
                
                Bitmap bm = new Bitmap(
                    CellWid * (maze.finish.X + 2),
                    CellHgt * (maze.finish.Y + 2), System.Drawing.Imaging.PixelFormat.Format16bppRgb555);

                Brush whiteBrush = new SolidBrush(Color.White);
                Brush blackBrush = new SolidBrush(Color.Black);

                using (Graphics gr = Graphics.FromImage(bm))
                {

                    gr.SmoothingMode = SmoothingMode.AntiAlias;
                    for (var i = 0; i < maze._cells.GetUpperBound(0) + oddW; i++)
                        for (var j = 0; j < maze._cells.GetUpperBound(1) + oddH; j++)
                        {
                            Point point = new Point(i * CellWid, j * CellWid);
                            Size size = new Size(CellWid, CellWid);
                            Rectangle rec = new Rectangle(point, size);
                            if (maze._cells[i, j]._isCell)
                            {
                                gr.FillRectangle(whiteBrush, rec);
                            }
                            else
                            {

                                gr.FillRectangle(blackBrush, rec);
                            }
                        }

                    gr.FillRectangle(new SolidBrush(Color.Green), 
                        new Rectangle(new Point(maze.start.X * CellWid, maze.start.Y * CellWid),
                        new Size(CellWid, CellWid)));
                    gr.FillRectangle(new SolidBrush(Color.Red), 
                        new Rectangle(new Point(maze.finish.X * CellWid, maze.finish.Y * CellWid),
                        new Size(CellWid, CellWid)));
                }

                picMaze.Image = bm;
                inBm = bm;

            }
        }

    }
}
