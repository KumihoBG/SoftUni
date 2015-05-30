using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Others
{
    internal class OtherMethods
    {
        private static void Main()
        {
            {
                
            }
			// метод за reverse на стринг
			private static string Reverse(string value)
			{
				StringBuilder reversed = new StringBuilder(value.Length);
				for (int i = value.Length - 1; i >= 0; i--)
				{
					reversed.Append(value[i]);
				}

				return reversed.ToString();
			}
			
			// метод за обръщане на число/дума
			private static double GetReversedNumber(double input)
            {
            string result = string.Join("", input.ToString(CultureInfo.InvariantCulture).TrimStart('-').Reverse());
            double number = double.Parse(result);
            return number;
            }
			
			// метод за удвояване на букви в дума
				private static string DoubleEachLetter(string reversed)
			{
				StringBuilder doubled = new StringBuilder();
				for (int i = 0; i < reversed.Length; i++)
				{
					doubled.Append(new string(reversed[i], 2));
				}

				return doubled.ToString();
			}
		
			// метод за намиране на по-голямо число
			private static int GetMax(int numberOne, int numberTwo)
            {
            int max = Math.Max(numberOne, numberTwo);
            return max;
            }
			
			// връща последната цифра на число, като дума
			private static void ReturnDigitAsWord(int digit, out int lastDigit)
            {
            lastDigit = Math.Abs(digit % 10);
            switch (lastDigit)
                {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                }
            }
			
			// метод за проверка на съседни числа
			private static bool IsLargerThanNeighbors(int[] numbers, int position)
				{
				bool isLarger;

				if (position == 0)
					{
					isLarger = numbers[position + 1] < numbers[position];
					}
				else if (position > 0 && position < numbers.Length - 1)
					{
					isLarger = numbers[position - 1] < numbers[position] && numbers[position + 1] < numbers[position];
					}
				else
					{
					isLarger = numbers[position - 1] < numbers[position];
					}

				return isLarger;
				}
			
				
			// метод за намиране на минимално число
			static double Minimum(double[] arr)
            {
            double min = double.MaxValue;
            for (int i = 0; i < arr.Length; i++)
                {
                if (arr[i] < min)
                    {
                    min = arr[i];
                    }
                }
            return min;
            }
			
			// метод за намиране на максимално число
			static double Maximum(double[] arr)
            {
            double max = double.MinValue;
            for (int i = 0; i < arr.Length; i++)
                {
                if (arr[i] > max)
                    {
                    max = arr[i];
                    }
                }
            return max;
            }
			
			// метод за намиране на средна стойност
			static double Average(double[] arr)
            {
            double average = 0;
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
                {
                sum += arr[i];
                }
            average = sum / arr.Length;
            return average;
            }

			// метод за сумиране
			static double Sum(double[] arr)
            {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
                {
                sum += arr[i];
                }
            return sum;
            }
			
			// метод за умножение
			static double Product(double[] arr)
            {
            double product = 1;
            for (int i = 0; i < arr.Length; i++)
                {
                product *= arr[i];
                }
            return product;
            }
			
			//сортиране на масив
			private static string SortArray<T>(IEnumerable<T> input)
            {
            List<T> originalInput = input.ToList();
            List<T> sortedInput = new List<T>();

            while (originalInput.Count != 0)
                {
                var result = originalInput.Min();
                sortedInput.Add(result);
                originalInput.Remove(result);
                }
            return PrintArray(sortedInput);
            }
			
			// принтиране на масив
			private static string PrintArray<T>(IEnumerable<T> sortedInput)
				{
				return string.Join(", ", sortedInput);
				}
			
			// принтиране с форматиране и StringBuilder
			StringBuilder output = new StringBuilder();
            foreach (var page in validPages)
            {
                output.AppendLine(string.Format("Color: {0}", page.Key));
                output.AppendLine(string.Format("-age: {0}", page.Value.Age));
                output.AppendLine(string.Format("-name: {0}", page.Value.Name));

                string opponentsOutput = "(empty)";
                if (page.Value.Opponents.Count > 0)
                {
                    var sortedOpponents = page.Value.Opponents
                    .OrderBy(o => o, StringComparer.Ordinal);
                    opponentsOutput = string.Join(", ", sortedOpponents);
                }

                output.AppendLine(string.Format("-opponents: {0}", opponentsOutput));

                double rank = (page.Value.WinCount + 1) / (double)(page.Value.LossCount + 1);
                output.AppendLine(string.Format("-rank: {0:F2}", rank));
            }
        }
    }
}