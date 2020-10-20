using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitGameWithDraw
{
    class Rabbit : ComplexFigure
    {
        public Rabbit(List<Figure> figures, Point center): base(figures, center)
        {

        }
        public static Rabbit CreateRabbit()
        {
            List<Point> bodyPoints = new List<Point>
            {
                new Point(-30, 60),
                new Point(-10, 60),
                new Point(-10, 20),
                new Point(10, 20),
                new Point(10, 60),
                new Point(30, 60),
                new Point(30, -30),
                new Point(30, -50),
                new Point(25, -60),
                new Point(20, -50),
                new Point(15, -60),
                new Point(10, -50),
                new Point(5, -60),
                new Point(0, -50),
                new Point(-5, -60),
                new Point(-10, -50),
                new Point(-15, -60),
                new Point(-20, -50),
                new Point(-25, -60),
                new Point(-30, -50),
            };
            List<Figure> figures = new List<Figure> 
            {
                new Figure(bodyPoints),
                Rectangle.CreateRectangle(new Point(-20, 10), new Point(-10, 0)),
                Rectangle.CreateRectangle(new Point(10, 10), new Point(20, 0)),
                Rectangle.CreateRectangle(new Point(-10, -10), new Point(10, -20))

            };
            return new Rabbit(figures, new Point(0, 0));
        }
    }
}
