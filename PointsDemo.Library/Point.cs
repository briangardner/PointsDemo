using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsDemo.Library
{
    public class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public void OutputCoordinate()
        {
            Console.WriteLine($"({X},{Y})");
        }

        public virtual string GetCoordinate()
        {
            return $"({X}, {Y})";
        }
        /// <summary>
        /// Calculates distance from Origin
        /// </summary>
        /// <returns></returns>
        public virtual double CalculateDistance()
        {
            var distance = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            return distance;
        }
    }
}
