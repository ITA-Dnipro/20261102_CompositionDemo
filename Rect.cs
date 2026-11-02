using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20261021_InheritanceDemo
{
    public class Rect : Shape2D
    {
        protected int _x2;
        protected int _y2;

        public Rect(Picture owner, int x1, int y1, int x2, int y2) 
            : base(owner, x1, y1)
        {
            _x2 = x2;
            _y2 = y2;
        }

        public int X2
        {
            get
            {
                return _x2;
            }
            set
            {
                if (!IsValidXCoord(value))
                {
                    return;
                }
                _x2 = value;
            }
        }

        public int Y2
        {
            get
            {
                return _y2;
            }
            set
            {
                if (!IsValidYCoord(value))
                {
                    return;
                }
                _y2 = value;
            }
        }

        public override void Move(int dx, int dy)
        {
            base.Move(dx, dy);

            _x2 += dx;
            _y2 += dy;
        }

        public override void Resize(double factor)
        {
            
        }

        public override string ToString()
        {
            return $"({_x}, {_y}) - ({_x2}, {_y2})";
        }
    }
}