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
                    rect = new Rectangle(int.Parse(tX.Text), int.Parse(tY.Text), int.Parse(tRadius.Text), int.Parse(tRadius.Text));
                    g.FillEllipse(new SolidBrush(color), rect);
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
            rectangle = false;
            circle = false;
        }

        private void BtnRectangle_Click(object sender, EventArgs e)
        {
            // ClearSelections();
            rect = new Rectangle();
            rectangle = true;
            tXP.Enabled = false;
            tYP.Enabled = false;
            tSize.Enabled = false;
            tRadius.Enabled = false;
            line = false;
            circle = false;
        }

        private void BtnCircle_Click(object sender, EventArgs e)
        {
            circle = true;
            rect = new Rectangle();

            // ClearSelections();
            tXP.Enabled = false;
            tYP.Enabled = false;
            tSize.Enabled = false;
            tWidth.Enabled = false;
            tHeight.Enabled = false;
            line = false;
            rectangle = false;
        }


        private void BtnRGB_Click(object sender, EventArgs e)
        {

            //ColorDialog colorDialog = new ColorDialog();
            //colorDialog.FullOpen = true;
            //if (colorDialog.ShowDialog() == DialogResult.OK)
            //{
            //    color = colorDialog.Color;
            //    //.BackColor = color;
            //   // label6.Text = color.R + " " + color.G + " " + color.B;
            //}

            //var red1 = TbRed.Text;
            int red = Convert.ToInt32(TbRed.Text);
            int green = Convert.ToInt32(TbGreen.Text);
            int blue = Convert.ToInt32(TbBlue.Text);

            color = Color.FromArgb(red, green, blue);
            //BtnRGB.BackColor = color;
            label6.BackColor = color;

            float r = red / 255f;
            float g = green / 255f;
            float b = blue / 255f;

            float min = new[] { 1-r, 1-g, 1-b }.Min();
            k = min;

            c = (1 - r - k) / (1 - k); if (c < 0) c = 0;
            m = (1 - g - k) / (1 - k); if (m < 0) m = 0;
            y = (1 - b - k) / (1 - k); if (y < 0) y = 0;

            c = Math.Round(c * 100);
            m = Math.Round(m * 100);
            y = Math.Round(y * 100);
            k = Math.Round(k * 100);

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

        private void BtnResizing_Click(object sender, EventArgs e)
        {
            BtnResizing.BackColor = Color.LightSeaGreen;
            BtnDrawing.BackColor = default(Color);
            rect.Width = Convert.ToInt32(tWidth.Text);
            rect.Height = Convert.ToInt32(tHeight.Text);
        }

        private void BtnCMYK_Click(object sender, EventArgs e)
        {
            int cyan = Convert.ToInt32(TbCyan.Text);
            int magenta = Convert.ToInt32(TbMagenta.Text);
            int yellow = Convert.ToInt32(TbYellow.Text);
            int black = Convert.ToInt32(TbBlack.Text);



            c = cyan / 100;
            m = magenta / 100;
            y = yellow / 100;
            k = black / 100;

            var r = 1 - Math.Min(1, c * (1 - k) + k);
            var g = 1 - Math.Min(1, m * (1 - k) + k);
            var b = 1 - Math.Min(1, y * (1 - k) + k);

            r = Math.Round(r * 255);
            g = Math.Round(g * 255);
            b = Math.Round(b * 255);

          

            TbRed.Text = r.ToString();
            TbGreen.Text = g.ToString();
            TbBlue.Text = b.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
                label6.BackColor = color;
                // label6.Text = color.R + " " + color.G + " " + color.B;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
                //if (rect.Left < e.X && e.X < rect.Right && rect.Top < e.Y && e.Y < rect.Bottom)
               // {
            if (isMouseDown == true)
            {

                    //int a = rect.Left;
                    rect.Location = e.Location;
                    //rect.X = e.X - rect.X;
                    //rect.Y = e.Y - rect.Y;

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
                    
                //}
            }
        }

        private void BtnDrawing_Click(object sender, EventArgs e)
        {
            drawing = true;
            BtnDrawing.BackColor = Color.LightSeaGreen;
            BtnResizing.BackColor = default(Color);
        }
    }
}
