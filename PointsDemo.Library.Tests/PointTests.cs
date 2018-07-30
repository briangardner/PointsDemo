using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PointsDemo.Library.Tests
{
    [TestFixture]
    public class PointTests
    {
        [Test]
        public void Should_Return_Default_X_and_Y_Coordinates_With_Parentheses()
        {
            //Arrange
            var point = new Point();
            //Act
            var result = point.GetCoordinate();
            //Assert
            Assert.AreEqual("(0, 0)", result);
        }

        [Test]
        public void Should_Return_Provided_X_and_Y_Coordinates_With_Parentheses()
        {
            //Arrange
            var point = new Point(1,2);
            //Act
            var result = point.GetCoordinate();
            //Assert
            Assert.AreEqual("(1, 2)", result);
        }

        [Test]
        public void CalculateDistance_Should_Return_Correct_Distance_From_Origin()
        {
            var point = new Point(3, 4);
            var result = point.CalculateDistanceFromPoint(new Point(0,0));
            Assert.AreEqual(5, result);
        }
    }
}
