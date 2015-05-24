using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Beers
    {
    class Beers
        {
        static void Main()
            {
            int beers = 0;
            for (int loops = 1; loops < 999; loops++)
                {
                string input = Console.ReadLine();
                if (input == "End")
                    {
                    break;
                    }

                string[] data = input.Split(' ');
                var count = int.Parse(data[0]);
                string measure = data[1];

                if (measure == "stacks")
                    {
                    beers += count * 20;
                    }
                else
                    {
                    beers += count;
                    }
                }
            int stacksTotal = beers / 20;
            int beersTotal = beers % 20;
            Console.WriteLine("{0} stacks + {1} beers", stacksTotal, beersTotal);
            }
        }
    }