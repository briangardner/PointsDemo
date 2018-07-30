using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsDemo.Library
{
    public class Point
    {
        public Point(int x=0, int y=0)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
        
        /* Not Testable
        public void OutputCoordinate()
        {
            Console.WriteLine(GetCoordinate());
        }*/

        public virtual string GetCoordinate()
        {
            return $"({X}, {Y})";
        }

        /// <summary>
        /// Calculates distance from Origin
        /// </summary>
        /// <returns></returns>
        public virtual double CalculateDistanceFromPoint(Point otherPoint)
        {
            var xDiff = X - otherPoint.X;
            var yDiff = Y - otherPoint.Y;
            var distance = Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2));
            return distance;
        }
    }
}
