using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GrafikaApp1
{
    public partial class Form1 : Form
    {
        Graphics g;
        bool drawing = false;
        bool moving = false;
        bool resizing = false;

        bool line = false;
        bool rectangle = false;
        bool circle = false;

        Color color = Color.Black; //domyślny kolor

        bool isMouseDown = false;
        Rectangle rect;

        double c, m, y, k;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            if (drawing)
            {
                if (line)
                {
                    Clear();
                    g.DrawLine(new Pen(color, int.Parse(tSize.Text)), new Point(int.Parse(tX.Text), int.Parse(tY.Text)), new Point(int.Parse(tXP.Text), int.Parse(tYP.Text)));
                   // line = false;
                }
                if (rectangle)
                {
                    Clear();
                    rect = new Rectangle(int.Parse(tX.Text), int.Parse(tY.Text), int.Parse(tWidth.Text), int.Parse(tHeight.Text));
                    g.FillRectangle(new SolidBrush(color), rect);
                   // rectangle = false;
                }
                if (circle)
                {
                    Clear();
                    g.FillEllipse(new SolidBrush(color), int.Parse(tX.Text), int.Parse(tY.Text), int.Parse(tRadius.Text), int.Parse(tRadius.Text));
                   // circle = false;
                }

                ClearSelections();
            }
        }

        private void ClearSelections()
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = true;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
            
        }

        void Clear()
        {
            g.Clear(pictureBox1.BackColor);
        }

        private void BtnLine_Click(object sender, EventArgs e)
        {
            //ClearSelections();
            line = true;
            tWidth.Enabled = false;
            tHeight.Enabled = false;
            tRadius.Enabled = false;
        }

        private void BtnRectangle_Click(object sender, EventArgs e)
        {
           // ClearSelections();
            rectangle = true;
            tXP.Enabled = false;
            tYP.Enabled = false;
            tSize.Enabled = false;
            tRadius.Enabled = false;
        }

        private void BtnCircle_Click(object sender, EventArgs e)
        {
            circle = true;
           // ClearSelections();
            tXP.Enabled = false;
            tYP.Enabled = false;
            tSize.Enabled = false;
            tWidth.Enabled = false;
            tHeight.Enabled = false;
        }


        private void BtnRGB_Click(object sender, EventArgs e)
        {

            //ColorDialog colorDialog = new ColorDialog();
            //colorDialog.FullOpen = true;
            //if(colorDialog.ShowDialog() == DialogResult.OK)
            //{
            //    color = colorDialog.Color;
            //    label6.BackColor = color;
            //    label6.Text = color.R + " " + color.G + " " + color.B ;
            //}

            int red = Convert.ToInt32(TbRed.Text);
            int green = Convert.ToInt32(TbGreen.Text);
            int blue = Convert.ToInt32(TbBlue.Text);

            color = Color.FromArgb(red, green, blue);
            BtnRGB.BackColor = color;

            double r = 1 - red / 255;
            double g = 1 - green / 255;
            double b = 1 - blue / 255;

            double min =  new[]{ r, g, b }.Min();
            k = min;

            c = (r - k) / (1 - k); if (c is double) c = c;
            m = (g - k) / (1 - k);
            y = (b - k) / (1 - k);

            //c = (c * 100) + 0.5;
            //m = (m * 100) + 0.5;
            //y = (y * 100) + 0.5;
            //k = (k * 100) + 0.5;

            TbCyan.Text = c.ToString();
            TbMagenta.Text = m.ToString();
            TbYellow.Text = y.ToString();
            TbBlack.Text = k.ToString();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            if (rectangle) graphics.FillRectangle(new SolidBrush(color), rect);
            if (circle) graphics.FillEllipse(new SolidBrush(color), rect);

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            isMouseDown = true;
            rect.Location = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown == true)
            {
             
                int a = rect.Left;

                rect.Location = e.Location;

                if (rect.Right > pictureBox1.Width)
                {
                    rect.X = pictureBox1.Width - rect.Width;
                }
                if (rect.Top < 0)
                {
                    rect.Y = 0;
                }
                if (rect.Left < 0)
                {
                    rect.X = 0;
                }
                if (rect.Bottom > pictureBox1.Height)
                {
                    rect.Y = pictureBox1.Height - rect.Height;
                }
                Refresh();
                
            }
        }

        private void BtnDrawing_Click(object sender, EventArgs e)
        {
            drawing = true;
            BtnDrawing.BackColor = Color.LightSeaGreen;
        }
    }
}
