using System;
using System.Collections.Generic;
using System.Text;

namespace _20261021_InheritanceDemo
{
    public class Point2D : Shape2D
    {
        public Point2D(IPicture owner, int x, int y)
            : base(owner, x, y)
        {
        }

        public Point2D(Picture owner, int coord)
            : this(owner, coord, coord)
        {
        }

        public override void Resize(double factor)
        {
        }

        public override string ToString()
        {
            return $"({_x}, {_y})";
        }
    }
}
