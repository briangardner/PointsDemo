using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsDemo.Library
{
    class Point3D : Point
    {
        public int Z { get; set; }
        public Point3D(int x=0, int y=0, int z=0) : base(x, y)
        {
            Z = z;
        }

        /// <inheritdoc />
        public override double CalculateDistance()
        {
            return Math.Sqrt(Math.Pow(base.CalculateDistance(), 2) + Math.Pow(Z, 2));
        }

        /// <inheritdoc/>
        public override string GetCoordinate()
        {
            return $"({X}, {Y}, {Z})";
        }
    }
}
