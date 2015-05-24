using System;

namespace _09.Disk
    {
    internal class Disk
        {
        private static void Main()
            {
            int size = int.Parse(Console.ReadLine());
            int radius = int.Parse(Console.ReadLine());
            int diskCenterRow = size / 2,
                diskCenterCol = size / 2;

            for (int currentRow = 0; currentRow < size; currentRow++)
                {
                for (int currentCol = 0; currentCol < size; currentCol++)
                    {
                    int height = currentCol - diskCenterCol,
                        width = currentRow - diskCenterRow;
                    double centerDistance = Math.Sqrt(height * height + width * width);
                    bool isInsideDisk = centerDistance <= radius;

                    if (isInsideDisk)
                        {
                        Console.Write('*');
                        }
                    else
                        {
                        Console.Write('.');
                        }
                    }
                Console.WriteLine();
                }
            }
        }
    }
