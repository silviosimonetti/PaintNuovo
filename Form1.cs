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

namespace Paint
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen;
        int x = -1;
        int y = -1;
        bool moving = false;
        bool flatStift = false;
        

        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 5);
            //pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round; //Alternativa senza usare l'using
            //pen.StartCap = pen.EndCap = LineCap.Round; //Alternativa
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
            panel1.Cursor = Cursors.Cross;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
            panel1.Cursor = Cursors.Default;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(moving && flatStift && x != -1 && y != -1) 
            {
                g.DrawLine(pen, new Point(x, y), e.Location); //location: Point
                x = e.X;
                y = e.Y;
            }
        }

        private void btnClearWindow_Click(object sender, EventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
            panel1.Controls.Clear();
            panel1.Invalidate();
        }

        private void flatStift1_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            if(p.BackColor == Color.Green) flatStift = true;
            else flatStift = false;
        }

        private void customButtonClearWindows_Click(object sender, EventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
            panel1.Controls.Clear();
            panel1.Invalidate();
        }

        private void customButtonChangeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK) pen.Color = colorDialog.Color;    
        }

        private void btnChangeColor2_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK) pen.Color = colorDialog.Color;
        }
    }
}
