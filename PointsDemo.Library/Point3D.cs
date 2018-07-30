using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsDemo.Library
{
    public sealed class Point3D : Point
    {
        public int Z { get; set; }

        public bool Is3D => true;
        public Point3D(int x=0, int y=0, int z=0) : base(x, y)
        {
            Z = z;
        }

        /// <inheritdoc />
        public override double CalculateDistanceFromPoint(Point point)
        {
            if (!(point is Point3D otherPoint))
            {
                throw new Exception("point must be of type Point3d.");
            }

            var zDiff = Math.Abs(Z - otherPoint.Z);
            return Math.Sqrt(Math.Pow(base.CalculateDistanceFromPoint(point), 2) + Math.Pow(zDiff, 2));
        }

        /// <inheritdoc/>
        public override string GetCoordinate()
        {
            return $"({X}, {Y}, {Z})";
        }

    }
}
