/*Write a program that calculates the perimeter and the area of given polygon (not necessarily convex) consisting of n floating-point coordinates in the 2D plane. Print the result rounded to two decimal digits after the decimal point. Use the input and output format from the examples. To hold the points, define a class Point(x, y). To hold the polygon use a Polygon class which holds a list of points. Find in Internet how to calculate the polygon perimeter and how to calculate the area of a polygon. */

namespace _17.PerimeterAndAreaOfPolygon
    {
    using System;

        partial class PerimeterAndArea
        {
        static void Main()
            {
            int pointsNumber = int.Parse(Console.ReadLine());
            int[,] matrix = new int[pointsNumber, 2];

            Point[] perimeter = new Point[pointsNumber];

            for (int i = 0; i < pointsNumber; i++)
                {
                string pointCoordinates = Console.ReadLine();
                string[] coordinate = pointCoordinates.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); 

                perimeter[i] = new Point() { X = int.Parse(coordinate[0]), Y = int.Parse(coordinate[1]) };
                matrix[i, 0] = int.Parse(coordinate[0]);
                matrix[i, 1] = int.Parse(coordinate[1]);
                }
            Console.WriteLine("The Perimeter of the polygon is {0:F2}", PolygonPerimeter(perimeter));
            Console.WriteLine("The Area of the polygon is {0:F2}", PolygonArea(matrix, pointsNumber));
            }
        }
    }
