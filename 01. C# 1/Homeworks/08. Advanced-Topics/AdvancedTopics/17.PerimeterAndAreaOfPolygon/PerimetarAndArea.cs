namespace _17.PerimeterAndAreaOfPolygon
    {
    using System;

    public partial class PerimeterAndArea
        {
        private static double CalculateDistance(int x1, int y1, int x2, int y2)
            {
            int distanceX = x2 - x1;
            int distanceY = y2 - y1;

            double distance = Math.Sqrt((distanceX * distanceX) + (distanceY * distanceY));
            return distance;
            }

        private static double PolygonPerimeter(Point[] perimeter)
            {
            double peri = 0;
            for (int i = 0; i < perimeter.Length - 1; i++)
                {
                peri += CalculateDistance(perimeter[i].X, perimeter[i].Y,
                    perimeter[i + 1].X, perimeter[i + 1].Y);
                }
            return peri;
            }

        private static double PolygonArea(int[,] matrix, int rows)
            {
            double leftSideSum = 0;
            double rightSideSum = 0;

            for (int i = 0; i < rows - 1; i++)
                {
                leftSideSum += (matrix[i, 0] * matrix[i + 1, 1]);
                rightSideSum += (matrix[i, 1] * matrix[i + 1, 0]);
                }

            var matrixResult = Math.Abs((leftSideSum - rightSideSum) / 2);

            return matrixResult;
            }
        }
    }
