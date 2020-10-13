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
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void canvas_Click(object sender, EventArgs e)
        {
            Pen pn = new Pen(Color.Black, 1);  // Перо для рисования
            Graphics g = canvas.CreateGraphics();
            Point center = new Point(0, 0);
            g.DrawLine(pn, 0, (int)canvas.Size.Height / 2, canvas.Size.Width, (int)canvas.Size.Height / 2);
            g.DrawLine(pn, (int)canvas.Size.Width / 2, 0, (int)canvas.Size.Width / 2, canvas.Size.Height);
            Rabbit rabbit = Rabbit.CreateRabbit();
            rabbit.Draw(g, pn);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Figure.SetOffsets(canvas.Size.Width / 2, canvas.Size.Height / 2);
        }
    }
}
