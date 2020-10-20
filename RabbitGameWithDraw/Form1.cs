using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitGameWithDraw
{
    public partial class Form1 : Form
    {
        private Rabbit rabbit;
        public Form1()
        {
            rabbit = Rabbit.CreateRabbit(); 
            InitializeComponent();  
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
             Repaint();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void canvas_SizeChanged(object sender, EventArgs e)
        {
            Repaint();
        }

        private void RoteateBtnClick1(object sender, EventArgs e)
        {
            rabbit.Rotate(-Math.PI / 6.0);
            Repaint();
        }

        private void RoteateBtnClick2(object sender, EventArgs e)
        {
            rabbit.Rotate(Math.PI / 6.0);
            Repaint();
        } 
        
        private void ScaleBtnBigger(object sender, EventArgs e)
        {
            rabbit.Transform(1.5);
            Repaint();
        }

        private void ScaleBtnLess(object sender, EventArgs e)
        {
            rabbit.Transform(2.0/3.0);
            Repaint();
        }

        private void MoveBtnRight(object sender, EventArgs e)
        {
            rabbit.Move(5,0);
            Repaint();
        }

        private void MoveBtnLeft(object sender, EventArgs e)
        {
            rabbit.Move(-5, 0);
            Repaint();
        }

        private void MoveBtnUp(object sender, EventArgs e)
        {
            rabbit.Move(0, 5);
            Repaint();
        }

        private void MoveBtnDown(object sender, EventArgs e)
        {
            rabbit.Move(0, -5);
            Repaint();
        }

        private void Repaint()
        {
            Figure.SetOffsets(canvas.Size.Width / 2, canvas.Size.Height / 2);
            Pen pn = new Pen(Color.Black, 1);  // Перо для рисования
            Graphics g = canvas.CreateGraphics();
            Point center = new Point(0, 0);
            g.FillRectangle(Brushes.White, 0, 0, canvas.Size.Width, canvas.Size.Height);
            g.DrawLine(pn, 0, (int)canvas.Size.Height / 2, canvas.Size.Width, (int)canvas.Size.Height / 2);
            g.DrawLine(pn, (int)canvas.Size.Width / 2, 0, (int)canvas.Size.Width / 2, canvas.Size.Height);
            rabbit.Draw(g, pn);
        }
    }
}
