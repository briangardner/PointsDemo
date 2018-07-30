using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PointsDemo.Library.Tests
{
    [TestFixture]
    public class Point3DTests
    {
        [Test]
        public void Should_GetCoordinate_For_Default_3D_Point()
        {
            var point = new Point3D();
            var result = point.GetCoordinate();
            Assert.AreEqual("(0, 0, 0)", result);
        }

        [Test]
        public void Should_GetCoordinate_For_Arbitrary_3D_Point()
        {
            var x = new Random().Next(0,10);
            var y = new Random().Next(0,10);
            var z = new Random().Next(0,10);
            var point = new Point3D(x,y,z);
            var result = point.GetCoordinate();
            Assert.AreEqual($"({x}, {y}, {z})", result);
        }

        [Test]
        public void Should_Calculate_Distance_Between_2_Points_On_Same_Y_Z_Planes()
        {
            var point1 = new Point3D(1,1,1);
            var point2 = new Point3D(2,1,1);
            var result = point2.CalculateDistanceFromPoint(point1);
            Assert.AreEqual((decimal) 1, (decimal) result);
        }

        [Test]
        public void Should_Calculate_Distance_Between_2_Points_On_Same_Z_Plane()
        {
            var point1 = new Point3D(1, 5, 6);
            var point2 = new Point3D(7, 2, 6);
            var result = point2.CalculateDistanceFromPoint(point1);
            Assert.AreEqual((decimal) Math.Sqrt(45),(decimal) result);
        }

        [Test]
        public void Should_Calculate_Distance_Between_2_Points_On_Completely_Different_Planes()
        {
            var point1 = new Point3D(1, 5, 6);
            var point2 = new Point3D(7, 2, 9);
            var result = point2.CalculateDistanceFromPoint(point1);
            Assert.AreEqual((decimal) Math.Sqrt(54), (decimal) result);
        }

    }
}
