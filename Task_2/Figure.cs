using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Figure
    {
        private Point[] points;

        public Figure(Point point1, Point point2, Point point3)
        {
            points = new Point[3];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            points = new Point[4];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
            points[3] = point4;
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            points = new Point[5];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
            points[3] = point4;
            points[4] = point5;
        }

        public double GetSideLength(Point A, Point B)
        {
            double deltaX = A.X - B.X;
            double deltaY = A.Y - B.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        public void CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length; i++)
            {
                Point currentPoint = points[i];
                Point nextPoint = points[(i + 1) % points.Length]; // To connect the last point to the first point
                perimeter += GetSideLength(currentPoint, nextPoint);
            }
            Console.WriteLine($"Назва фігури: {points.Length}-кут, Периметр: {perimeter}");
        }
    }
}
