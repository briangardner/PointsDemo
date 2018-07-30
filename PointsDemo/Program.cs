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

            Console.WriteLine(startPoint.GetCoordinate());
            var distance = startPoint.CalculateDistanceFromPoint(new Point(0,0));
            Console.WriteLine($"{distance:N}");

            Console.WriteLine("Line Details:");
            Console.WriteLine(line.GetLineCoordinates());
            Console.WriteLine("Length:" + line.CalculateLength());
            Console.ReadKey();
            Console.WriteLine();

            var line3D = new Line(new Point3D(3,4,5), new Point3D(1,2,3));
            Console.WriteLine($"Distance: {line3D.CalculateLength():N}");
            Console.WriteLine($"Coordinates: {line3D.GetLineCoordinates()}");
            Console.ReadKey();


            Console.WriteLine();
            Console.WriteLine("Polymorphism in action!!!");
            var listOfPoints = new List<Point>()
            {
                new Point(),
                new Point(1, 4),
                new Point3D(4, 3, 2),
                new Point(9, 9),
                new Point3D(9, 9, 9)
            };
            foreach (Point point in listOfPoints)
            {                
                Console.WriteLine(point.GetCoordinate());
            }

            Console.ReadKey();
        }
    }
}
