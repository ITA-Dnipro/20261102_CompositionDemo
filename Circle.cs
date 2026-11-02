using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20261021_InheritanceDemo
{
    public class Circle : Shape2D
    {
        protected int _r;

        public Circle(IPicture owner, int x, int y, int r)
            : base(owner, x, y)
        {
            _r = r;
        }

        public int R
        {
            get
            {
                return _r;
            }
            set
            {
                // validation
                if (value <= 0)
                {
                    return;
                }

                _r = value;
            }
        }

        public override void Resize(double factor)
        {

        }


        public override string ToString()
        {
            return $"({_x}, {_y}), r = {_r}";
        }
    }
}