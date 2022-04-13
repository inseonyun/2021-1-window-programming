using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointIndexerWindowApp
{
    public delegate void MyDelegate(int x, int y);

    class Point
    {
        int x;
        int y;

        public Point()
        {
            this.x = 0;
            this.y = 0;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public void MoveTo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void MoveBy(int moveX, int moveY)
        {
            this.x += moveX;
            this.y += moveY;
        }
        public override string ToString()
        {
            return "x : " + x + ", y : " + y;
        }
        public static Point operator +(Point p1, Point p2)
        {
            Point p3 = new Point();
            p3.X = p1.X + p2.X;
            p3.Y = p1.Y + p2.Y;
            return p3;
        }
        public static Point operator -(Point p1, Point p2)
        {
            Point p3 = new Point();
            p3.X = p1.X - p2.X;
            p3.Y = p1.Y - p2.Y;
            return p3;
        }
    }
}
