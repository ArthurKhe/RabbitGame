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
        public ComplexFigure(List<Figure> figures) 
        {
            this.figures = figures;    
        }
        public void Draw(Graphics g, Pen pn)
        {
            foreach (Figure figure in figures)
            {
                figure.Draw(g, pn);
            }
        }
        private void Move(float x, float y)
        {

        }
        private void Rotate(float angle)
        {

        }
        private void Transform(float scale) { }
    }
}
