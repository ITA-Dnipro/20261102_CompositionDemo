using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20261021_InheritanceDemo
{
    public class Picture : IPicture
    {
        const int LEFT = 0;
        const int TOP = 0;
        const int RIGHT = 80;
        const int BOTTOM = 25;

        private int _left, 
                    _top, 
                    _right, 
                    _bottom;

        private List<Shape2D> _shapes;    // composition relationships to Shape2D

        public Picture(int left = LEFT, int top = TOP, int right = RIGHT, int bottom = BOTTOM)
        {
            _shapes = new List<Shape2D>();

            _left = left;
            _top = top;
            _right = right;
            _bottom = bottom;
        }

        public int Left
        {
            get
            {
                return _left;
            }
        }

        public int Top
        {
            get
            {
                return _top;
            }
        }

        public int Right
        {
            get
            {
                return _right;
            }
        }

        public int Bottom
        {
            get
            {
                return _bottom;
            }
        }

        public void AddShape(Shape2D shape)
        {
            _shapes.Add(shape);
        }

        public void ShowAllShapes(ConsoleColor color = ConsoleColor.Red)
        {
            for (int i = 0; i < _shapes.Count; i++)
            {
                ConsoleViewer.Show(_shapes[i], color);
            }
        }

        public void MoveAllShapes(int dx, int dy)
        {
            for (int i = 0; i < _shapes.Count; i++)
            {
                _shapes[i].Move(dx, dy);
            }
        }

        public void ResizeAllShapes(double factor)
        {
            for (int i = 0; i < _shapes.Count; i++)
            {
                _shapes[i].Resize(factor);
            }
        }
    }
}