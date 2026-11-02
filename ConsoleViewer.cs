using System;
using System.Collections.Generic;
using System.Text;

namespace _20261021_InheritanceDemo
{
    public class ConsoleViewer
    {
        public static void Show(Shape2D p, ConsoleColor color = ConsoleColor.Red)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            int oldX = Console.CursorLeft;
            int oldY = Console.CursorTop;

            Console.ForegroundColor = color;
            Console.SetCursorPosition(p.X, p.Y);
            Console.Write($"{p}");

            Console.SetCursorPosition(oldX, oldY);
            Console.ForegroundColor = oldColor;
        }
    }
}
