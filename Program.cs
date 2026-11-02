using _20261021_InheritanceDemo;

namespace _20261102_CompositionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Picture pict = new Picture(0, 0, 80, 25);

            Point2D p1 = new Point2D(pict, 17, 21);
            Point2D p2 = new Point2D(pict, 15, 19);
            Circle c1 = new Circle(pict, 10, 20, 5);
            Rect r1 = new Rect(pict, 35, 15, 45, 30);

            pict.AddShape(p1);
            pict.AddShape(p2);
            pict.AddShape(c1);
            pict.AddShape(r1);

            pict.ShowAllShapes();

            pict.MoveAllShapes(3, -2);

            pict.ShowAllShapes(ConsoleColor.Cyan);
        }
    }
}
