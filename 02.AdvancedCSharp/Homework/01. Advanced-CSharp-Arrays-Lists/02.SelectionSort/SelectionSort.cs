/*Write a program to sort an array of numbers and then print them back on the console. The numbers should be entered from the console on a single line, separated by a space. Refer to the examples for problem 1.
Note: Do not use the built-in sorting method, you should write your own. Use the selection sort algorithm. 
 Info http://bg.wikipedia.org/wiki/%D0%A1%D0%BE%D1%80%D1%82%D0%B8%D1%80%D0%B0%D0%BD%D0%B5_%D1%87%D1%80%D0%B5%D0%B7_%D0%BF%D1%80%D1%8F%D0%BA%D0%B0_%D1%81%D0%B5%D0%BB%D0%B5%D0%BA%D1%86%D0%B8%D1%8F: Алгоритъмът има сложност от Θ(n2), т.е. времето за изпълнението му е пропорционално на квадрата на броя на елементите в масива. Това го прави неефикасен при големи списъци и като цяло работи по-зле от подобния му алгоритъм за сортиране чрез вмъкване (insertion sort).
 Алгоритъмът работи по следния начин:
    Намира най-малкия елемент в списъка като сравнява първият елемент с всички останали
    Разменя го с елемента на първа позиция
    Повтаря горните две стъпки за всеки следващ елемент
*/
namespace _02.SelectionSort
{
    using System;
    using System.Linq;

    internal class SelectionSort
    {
        private static void Main()
        {
            Console.WriteLine("Enter the values of the array numbers on a single line, separated by space or comma: ");
            int[] arrInts = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] arr = Sort(arrInts);
            Console.WriteLine(string.Join(" ", arr));
        }

        static int[] Sort(params int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
    }
}
