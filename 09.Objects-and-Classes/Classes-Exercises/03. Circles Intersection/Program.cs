using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circles_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstCircle = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            var secondCircle = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            var raduisCircleOne = firstCircle[2];
            var radiusCircleTwo = secondCircle[2];
           

            //var firstPointParts = Console.ReadLine()
            //    .Split(' ')
            //    .Select(double.Parse)
            //    .ToArray();


            //var secondPointParts = Console.ReadLine()
            //    .Split(' ')
            //    .Select(double.Parse)
            //    .ToArray();

            var firstPoint = new Point
            {
                X =  firstCircle[0],
                Y =  firstCircle[1]
            };

            var secondPoint = new Point
            {
                X =  secondCircle[0],
                Y =  secondCircle[1]
            };

            var distanceTwoPoints = CalculateDistance(
                firstPoint, secondPoint);


            if (distanceTwoPoints<=raduisCircleOne+radiusCircleTwo)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            


        }

        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var diffX = firstPoint.X - secondPoint.X;
            var diffY = firstPoint.Y - secondPoint.Y;

            var powX = Math.Pow(diffX, 2);
            var powY = Math.Pow(diffY, 2);

            return Math.Sqrt(powX + powY);

            
        }
    }
}
