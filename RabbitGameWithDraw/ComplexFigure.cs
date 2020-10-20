using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitGameWithDraw
{
    class ComplexFigure
    {
        List<Figure> figures = null;
        Point center = null;
        public ComplexFigure(List<Figure> figures, Point center) 
        {
            this.figures = figures;
            this.center = center;
        }
        public void Draw(Graphics g, Pen pn)
        {
            foreach (Figure figure in figures)
            {
                figure.Draw(g, pn);
            }
        }

        public void Rotate(double angle)
        {
            foreach (Figure figure in figures)
            {
                figure.Rotate(angle, center);
            }
        }
        public void Move(double x, double y)
        {
            foreach (Figure figure in figures)
            {
                figure.Move(x, y);
            }
        }
        public void Transform(double scale)
        {
            foreach (Figure figure in figures)
            {
                figure.Transform(scale);
            }
        }

    }
}
