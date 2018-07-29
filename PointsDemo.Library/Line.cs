using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsDemo.Library
{
    public class Line
    {
        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }
        public Point Start { get; set; }
        public Point End { get; set; }

        public double CalculateLength()
        {
            var xDiff = End.X - Start.X;
            var yDiff = End.Y - Start.Y;
            return Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2));
        }

        public void OutputLineCoordinates()
        {
            Console.WriteLine(Start.GetCoordinate() + " - " + End.GetCoordinate());
        }
    }
}
