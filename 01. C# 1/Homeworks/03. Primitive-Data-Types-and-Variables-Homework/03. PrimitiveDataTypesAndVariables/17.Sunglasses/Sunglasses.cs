namespace _17.Sunglasses
    {
    using System;

    class Sunglasses
        {
        static void Main()
        {
            int heightOfSunglasses = int.Parse(Console.ReadLine());
            int width = heightOfSunglasses*2;
            
            for (int i = 0; i < heightOfSunglasses; i++)
                {
                if (i == 0 || i == heightOfSunglasses - 1)
                    {
                    string frame = new string('*', width);
                    string emptySpace = new string(' ', heightOfSunglasses);
                    Console.WriteLine("{0}{1}{0}", frame, emptySpace);
                    }
                else
                    {
                    string lens = new string('/', width - 2);
                    string middleFrame = string.Format("{0}{1}{0}", '*', lens);
                    string connection = new string(' ', heightOfSunglasses); 
                    if (i == heightOfSunglasses / 2)
                        {
                        connection = new string('|', heightOfSunglasses);
                        }
                    Console.WriteLine("{0}{1}{0}", middleFrame, connection);
                    }
                }
            }
        }
    }
