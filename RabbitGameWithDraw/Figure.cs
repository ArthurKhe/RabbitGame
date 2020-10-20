using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitGameWithDraw
{
    class Figure: Drawable
    {
        private Matrix matrix = null;
        public static Matrix offsets = new Matrix(1, 3);
        protected List<Point> points = new List<Point>();
        public Figure(List<Point> points)
        {
            this.Points = points;
        }
        public static void SetOffsets(double x, double y)
        {
            offsets[0, 0] = x;
            offsets[0, 1] = -y;
        }
        public List<Point> Points
        {
            set
            {
                matrix = new Matrix(value.Count, 3);
                for (int i = 0; i < value.Count; i++)
                {
                    matrix[i, 0] = value[i].X;
                    matrix[i, 1] = value[i].Y;
                    matrix[i, 2] = 1;
                }
            }
        }

        public void Move(double x, double y)
        {
            Matrix transform = new Matrix(3, 3);
            transform[0, 0] = 1;
            transform[1, 1] = 1;
            transform[2, 2] = 1;
            transform[2, 0] = x;
            transform[2, 1] = y;
            matrix = matrix * transform;

        }
        public void Rotate(double angle, Point rotateCenter)
        {
            Matrix transform = new Matrix(3, 3);
            Matrix center = new Matrix(1, 3);
            center[0, 0] = rotateCenter.X;
            center[0, 1] = rotateCenter.Y;
            matrix = matrix.SubRow(center);
            transform[0, 0] = Math.Cos(angle);
            transform[0, 1] = Math.Sin(angle);
            transform[1, 0] = -Math.Sin(angle);
            transform[1, 1] = Math.Cos(angle);
            transform[2, 2] = 1;
            matrix = matrix.AddRow(center);
            matrix = matrix * transform;
        }
        public void Transform(double scale) 
        {
            Matrix transform = new Matrix(3, 3);
            transform[0, 0] = scale;
            transform[1, 1] = scale;
            transform[2, 2] = 1;
            matrix = matrix * transform;
        }

        public void Draw(Graphics g, Pen pn)
        {
            Matrix drawMatrix = matrix.Clone();
            drawMatrix = drawMatrix.AddRow(offsets);

            for (int i = 0; i < drawMatrix.M; i++)
            {
                drawMatrix[i, 1] *= -1;
            }
            for (int i = 1; i < drawMatrix.M; i++)
            {
                g.DrawLine(pn, (float)drawMatrix[i - 1, 0], (float)drawMatrix[i - 1, 1], (float)drawMatrix[i, 0], (float)drawMatrix[i, 1]);
            }
            g.DrawLine(pn, (float)drawMatrix[0, 0], (float)drawMatrix[0, 1], (float)drawMatrix[matrix.M - 1, 0], (float)drawMatrix[matrix.M - 1, 1]);

        }
    }
}
