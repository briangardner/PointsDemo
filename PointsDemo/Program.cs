using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointsDemo.Library;

namespace PointsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var startPoint = new Point(3, 4);
            var endPoint = new Point(5, 8);
            var line = new Line(startPoint, endPoint);

            startPoint.OutputCoordinate();
            var distance = startPoint.CalculateDistance();
            Console.WriteLine($"{distance:N}");

            //moving the point
            /*point.X = 5;
            point.OutputCoordinate();
            distance = point.CalculateDistance();
            Console.WriteLine($"{distance:N}");
            Console.ReadKey();*/

            Console.WriteLine("Line Details:");
            line.OutputLineCoordinates();
            Console.WriteLine("Length:" + line.CalculateLength());
            Console.ReadKey();
        }
    }
}
