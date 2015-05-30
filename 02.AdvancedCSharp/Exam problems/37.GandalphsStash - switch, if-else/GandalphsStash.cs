using System;
using System.Linq;

namespace _02.GandalphsStash
    {
    class GandalphsStash
        {
        static void Main()
            {
            int firstMood = int.Parse(Console.ReadLine());
            string food = Console.ReadLine();
            string[] typesOfFood = food.ToLower().Split(new char[] { ' ', ',', '!', '_', ';', '@', '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string newMood = string.Empty;

            foreach (string meal in typesOfFood)
                {
                switch (meal)
                    {
                    case "cram":
                        firstMood += 2;
                        break;
                    case "lembas":
                        firstMood += 3;
                        break;
                    case "apple":
                        firstMood += 1;
                        break;
                    case "melon":
                        firstMood += 1;
                        break;
                    case "honeycake":
                        firstMood += 5;
                        break;
                    case "mushrooms":
                        firstMood -= 10;
                        break;
                    default:
                        firstMood -= 1;
                        break;
                    }
                }

            if (firstMood < -5)
                {
                newMood = "Angry";
                }
            else if (firstMood >= -5 && firstMood < 0)
                {
                newMood = "Sad";
                }
            else if (firstMood >= 0 && firstMood < 15)
                {
                newMood = "Happy";
                }
            else if (firstMood >= 15)
                {
                newMood = "Special JavaScript mood";
                }

            Console.WriteLine(firstMood);
            Console.WriteLine(newMood);
            }
        }
    }