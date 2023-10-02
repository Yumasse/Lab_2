namespace Task_2
{
    class Program
    {
        static void Main()
        {
            Point pointA = new Point(0, 0, "A");
            Point pointB = new Point(3, 0, "B");
            Point pointC = new Point(0, 4, "C");

            Figure triangle = new Figure(pointA, pointB, pointC);
            triangle.CalculatePerimeter();

            Point pointD = new Point(5, 0, "D");
            Point pointE = new Point(5, 5, "E");

            Figure pentagon = new Figure(pointA, pointB, pointC, pointD, pointE);
            pentagon.CalculatePerimeter();
        }
    }
}