using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20261021_InheritanceDemo
{
    public abstract class Shape2D
    {
        #region --==##   Data  ##==--

        IPicture _owner;    // aggregation relationship to Picture

        protected int _x;
        protected int _y;

        #endregion

        #region Methods

        public Shape2D(IPicture owner, int x, int y)
        {
            _owner = owner;
            _x = x;
            _y = y;
        }

        public bool IsValidXCoord(int x)
        {
            return x >= _owner.Left && x <= _owner.Right;
        }

        public bool IsValidYCoord(int y)
        {
            return y >= _owner.Top && y <= _owner.Bottom;
        }

        public virtual void Move(int dx, int dy)
        {
            _x += dx;
            _y += dy;
        }

        public abstract void Resize(double factor);

        #endregion

        #region --==   Properties  ===---

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                // validation
                if (!IsValidXCoord(value))
                {
                    return;
                }

                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                // validation
                if (!IsValidYCoord(value))
                {
                    return;
                }

                _y = value;
            }
        }

        #endregion
    }
}