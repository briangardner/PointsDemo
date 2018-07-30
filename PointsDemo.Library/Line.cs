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
            return End.CalculateDistanceFromPoint(Start);
        }

        public string GetLineCoordinates()
        {
            return $"{Start.GetCoordinate()} - {End.GetCoordinate()}";
        }
    }
}
