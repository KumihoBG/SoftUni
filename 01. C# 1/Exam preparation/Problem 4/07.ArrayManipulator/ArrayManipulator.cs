using System;
using System.Linq;

namespace _07.ArrayManipulator
    {
    class ArrayManipulator
        {
        static void Main()
            {
            // Input format: EDCBA\ZHGLCA\left exclude
            string input = Console.ReadLine();
            string[] data = input.Split('\\').ToArray();

            switch (data[2])
                {
                case "join": JoinStrings(data); break;
                case "right exclude": RightExclude(data); break;
                case "left exclude": LeftExclude(data); break;
                }
            }
        private static void LeftExclude(string[] data)
            {
            string a = data[0];
            string b = data[1];
            char[] c = b.Except(a).ToArray();
            Array.Sort(c);
            Console.WriteLine(string.Join("", c));
            }

        private static void RightExclude(string[] data)
            {
            string a = data[0];
            string b = data[1];
            char[] c = a.Except(b).ToArray();
            Array.Sort(c);
            Console.WriteLine(string.Join("", c));
            }

        private static void JoinStrings(string[] data)
            {
            string a = data[0];
            string temp = a;
            string b = data[1];
            temp = string.Join("", temp.Except(b));
            char[] c = a.Except(temp).ToArray();
            Array.Sort(c);
            Console.WriteLine(string.Join("", c));
            }
        }
    }
