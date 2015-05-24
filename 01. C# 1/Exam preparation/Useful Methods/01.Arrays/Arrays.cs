using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Arrays
{
    internal class Arrays
    {
        private static void Main()
        {
            //вход na масив - най-лесен вариант с using.Linq; ********************************
            int[] numbersOne = Console.ReadLine() // прочети ми го от конзолата
                .Split(new char[] {' ', ',', '!'}, StringSplitOptions.RemoveEmptyEntries)
                // раздели ми го и премахни празнотите
                .Select(int.Parse) // за всеки стринг, който си получил, парсни го
                .ToArray(); // и го направи на масив
				
			// още един подобен начин
			int[] numbers = Console.ReadLine()
			.Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
			.Select(x => int.Parse(x))
			.ToArray();
			
			// още един подобен / може и с Random
			string someNumbers = Console.ReadLine();
			// Random rand = new Random();
			string[] strNumbers = input.Split(' ');
			int[] numbers = new int[strNumbers.Length]; // or hardcoded 10
			
			for (int i = 0; i < strNumbers.Length; i++)
			{
				numbers[i] = int.Parse(strNumbers[i - 1]); //number[i] = rand.Next(0,101);
				if(i > 0)
				{
					numbers[i] += strNumbers[i]; // например ги сумираме, ако i е по-голямо от нула
				}
				Console.Write(numbers[i] + " ");
			}
			
            // вход на числа на отделен ред с END
            List<string> cages1 = new List<string>();
            string input = "";
            while (input != "END")
                {
                input = Console.ReadLine();
                if (input == "END")
                    {
                    break;
                    }
                cages1.Add(input);
                }
            Console.WriteLine(string.Join(" ", cages1));

            // вход от конзолата **************************************************************
            string input = Console.ReadLine();
            string[] text = input.Split(new char[] {' ', ',', '!'}, StringSplitOptions.RemoveEmptyEntries);

            //конвертира един масив в друг ****************************************************
            int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            // вход от конзола - друг вариант *************************************************
            string[] numbersTwo = Console.ReadLine().Split(' ');
            int[] intArray = new int[numbersTwo.Length];
            for (int i = 0; i < numbersTwo.Length; i++)
            {
                intArray[i] = int.Parse(numbersTwo[i]);
            }
            //друг начин за четене от конзолата:************************************************
            int n = int.Parse(Console.ReadLine());
            int[] newArray = new int[n];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = int.Parse(Console.ReadLine());
            }
            // за генериране на масив от числа:**************************************************
            int[] numbersSome = Enumerable.Range(1, 10).ToArray();
            int[] numbersAny = Enumerable.Range(1, 50).ToArray();
            int[] numbers2 = Enumerable.Repeat(3, 50).ToArray(); //за повторение на даден елемент брой пъти
            Random randomNumbers = new Random(); // random numbers

            for (int numbers = 1; numbers <= 10; numbers++)
            {
                Console.WriteLine("{0} -> {1}", numbers, randomNumbers.Next(200) + 100);
            }
            // За намиране на симетричност/обръщане в масиви = lenght - index - 1 ***************
            // вместо numbers[n-i-1] = numbers[i];
            int inputLine = int.Parse(Console.ReadLine());
            int[] numbers3 = new int[inputLine];
            int[] reversedNumbers = numbers3.Reverse().ToArray();

            // За принтиране на масив със запетайка:*********************************************
            int[] numbers1 = {1, 2, 3, 4, 5, 6};
            string numbersString = string.Join(", ", numbers1);
            Console.WriteLine(numbersString);

            // сортиране на масиви:**************************************************************

            //    public abstract class ArraySorting // new class created
            //{
            //public abstract void Sort(Array array); //here is the Sort method

            //private class ArraySort
            //    {
            //    private static void Main()
            //        {
            // We are using the quick sort method Array.Sort instead of Selection sort algorythm;

            Console.Write("Enter the values of the array numbers on a single line, separated by space or comma: ");
            string text4 = Console.ReadLine();
            char[] space = {',', ' '};
            string[] newStringInput = text4.Split(space, StringSplitOptions.RemoveEmptyEntries);

            int[] arr = new int[newStringInput.Length];
            int i;
            for (i = 0; i < newStringInput.Length; i++)
            {
                arr[i] = int.Parse(newStringInput[i]);
            }
            Array.Sort(arr); // calling the Sort method


            for (i = 0; i < arr.Length; i++) // printing the sorted array
            {
                if (i != arr.Length - 1)
                {
                    Console.Write(arr[i] + " ");
                }
                else
                {
                    Console.WriteLine(arr[i]);
                }
                //            }
                //        }
                //    }
                //}
                //сортиране и сравняване по дължина на str масив
                string text5 = Console.ReadLine();
                char[] space2 = {',', ' ', '.'};
                string[] newStringInput2 = text5.Split(space2, StringSplitOptions.RemoveEmptyEntries);

                //sorting strings by lenghts
                Array.Sort(newStringInput2, (x, y) => x.Length.CompareTo(y.Length));

                //printing the result of the comparison
                foreach (string str in newStringInput)
                {
                    Console.WriteLine(str, StringComparison.CurrentCultureIgnoreCase); //we ignore if the letters
                } // are capital or small - not necessary, just for
                Console.WriteLine(); // demonstration

				// Bubble sort на масив
				int[] masiv = {5, 2, 7, 1, 3};
				while(true)
				{
					bool hasSwapped = false;
					for (int i = 0; i < masiv.Length - 1; i++)
					{
						if(masiv[i] > masiv[i + 1])
						{
							int oldValue = masiv[i]; // нова променлива да пази резултата
							masiv[i] = masiv[i + 1];
							masiv[i + 1] = oldValue;
							hasSwapped = true;
						}
					}
					if(!hasSwapped)
					{
						break;
					}
				}
				for (int i = 0; i < masiv.Length; i++)
                {
                    Console.WriteLine(masiv[i]);
                }
				
                // клониране на масиви ***********************************************************
                int[] one = {5, 6, 7};
                int[] two = (int[]) one.Clone(); //нов масив, който сочи към друго парче от паметта
                // и след промяна в стойностите първият не се променя

                // прехвърляне на типа масив при клониране****************************************
                int[] numbersThree = {1, 2, 3};
                string[] stringArray = numbersThree.Select(number => number.ToString()).ToArray(); //ламбда 

                // сравняване на масиви:**********************************************************
                int numberInputOne = int.Parse(Console.ReadLine());
                int numberInputTwo = int.Parse(Console.ReadLine());
                int[] arrayOne = new int[numberInputOne]; // initializing the number one array's lenght
                int[] arrayTwo = new int[numberInputTwo]; // initializing the number two array's lenght
                bool comparer = true;
                Console.WriteLine("Enter the values of the first array, each on a separate line: ");
                for (int i = 0; i < numberInputOne; i++)
                {
                    arrayOne[i] = int.Parse(Console.ReadLine()); // initializing the values of the first array;
                }
                Console.WriteLine("Now enter the values of the second array, each on a separate line: ");
                for (int i = 0; i < numberInputTwo; i++)
                {
                    arrayTwo[i] = int.Parse(Console.ReadLine()); // initializng the values of the second array;
                }
                for (int i = 0; i < arrayOne.Length; i++) // comparing the arrays using nested loop
                {
                    // and if-else statement
                    for (int j = 0; j < arrayTwo.Length; j++)
                    {
                        if (arrayOne[i] == arrayTwo[i] && numberInputOne == numberInputTwo) // comparing array's 
                        {
                            // lenght and values!
                            comparer = true; // arrays are equal;
                        }
                        else
                        {
                            comparer = false; // arrays are not equal;
                        }
                    }
                }
                Console.WriteLine("Are these arrays equal? {0}", comparer);

                //сравняване на масиви от chars:**************************************************
                char[] text1 = Console.ReadLine().ToCharArray();
                char[] text2 = Console.ReadLine().ToCharArray();
                bool equal = text1.SequenceEqual(text2);
                if (text1 == text2)
                {
                    Console.WriteLine("Are the char arrays equal? Result: {0}", equal);
                }
                else
                {
                    Console.WriteLine("Are the char arrays equal? Result: {0}", equal);
                }
            }
            // Бинарно търсене на елемент в масив, по-малък или равен от настоящия
            int n = int.Parse(Console.ReadLine()); // дължина на масива
            int value = int.Parse(Console.ReadLine()); // максимална стойност
            int[] numbersArray = new int[n];
            int maxValue = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Array[{0}]= ", i);
                numbersArray[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbersArray); //callind the sorting method from above

            for (int i = 0; i < numbersArray.Length; i++)
            {

                if (numbersArray[i] < value)
                {
                    maxValue = numbersArray[i];
                }
            }
            Array.BinarySearch(numbersArray, maxValue); // the Array.BinarySearch method

            if (numbersArray[0] > value) // printing the result
            {
                Console.WriteLine("The given value is smaller than any number in the array.");
            }
            else
            {
                Console.WriteLine("The max value was {0}. The next bigger number after the given max value is: {1}",
                    value, maxValue);
            }
        }
		// Merge sort algorythm
		static void MergeSort(int[] arr, int left, int right)
		{
		if (right > left)
		{
		int mid = (right + left) / 2;
		MergeSort(arr, left, mid);
		MergeSort(arr, (mid+1), right);
		Merge(arr, left, (mid+1), right);
		}
		}
        // метод - създава масив от стрингс и сумира стойностите му ******************************
        private static
            int Sum
            (string
                input)
        {
            int[] array = input.Split(' ').Select(int.Parse).ToArray();
            return array.Sum(); //using Linq, the .Sum() method
        }

        // Метод за намиране на брой срещания на число в масив:
        public static int CheckForNumber(int[] array, int num)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                    count++;
            }
            return count;
        }

        /* в Main:  string text = Console.ReadLine();
            char[] space = { ',', ' ' };
            string[] newStringInput = text.Split(space, StringSplitOptions.RemoveEmptyEntries);

            int[] arrayOfIntegers = new int[newStringInput.Length];
            for (int i = 0; i < newStringInput.Length; i++)
                {
                arrayOfIntegers[i] = int.Parse(newStringInput[i]);
                }

            Console.Write("Enter the number to search for: ");
            int theNumber = int.Parse(Console.ReadLine());

            // calling our method from below
            Console.WriteLine("The number appears {0} times in the given array.", CheckForNumber(arrayOfIntegers, theNumber));*/

        // Методи за минимална, максимална, средна стойност, събиране и сума на числа в масив
        //declaring the minimum value method
        private static T GetMinimumValue<T>(params T[] array) where T : IComparable<T>
        {
            Array.Sort(array);

            return array[0];
        }

        //declaring the maximum value method
        private static T GetMaximumValue<T>(params T[] array) where T : IComparable<T>
        {
            Array.Sort(array);

            return array[array.Length - 1];
        }

        //declaring the avarage value method
        private static double GetAverageValue<T>(params T[] array)
        {
            return Convert.ToDouble(GetSum(array))/array.Length;
        }

        //declaring the sum value method
        private static dynamic GetSum<T>(params T[] array)
        {
            dynamic sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        //declaring the product value method
        private static dynamic GetProduct<T>(params T[] array)
        {
            dynamic product = 1;

            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }

            return product;
        }

        //declaring the calculation method
        private static void Calculate<T>(params T[] array)
        {
            dynamic arrForUse = array;

            var min = GetMinimumValue(arrForUse);
            var max = GetMaximumValue(arrForUse);
            var sum = GetSum(arrForUse);
            var average = GetAverageValue(arrForUse);
            var product = GetProduct(arrForUse);

            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(sum);
            Console.WriteLine(average);
            Console.WriteLine(product);
            ////в Main:            
            //decimal[] decimals = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            //float[] floats = Console.ReadLine().Split(' ').Select(float.Parse).ToArray();
            //byte[] bytes = Console.ReadLine().Split(' ').Select(byte.Parse).ToArray();
            //double[] doubles = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            //long[] longs = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            //Calculate(decimals);
            //Calculate(floats);
            //Calculate(bytes);
            //Calculate(doubles);
            //Calculate(longs);
        }
		// Fibonacci
		decimal Fibonacci(int n)
		{
		if (n == 0) return 0;
		if (n == 1) return 1;
		return Fibonacci(n - 1) + Fibonacci(n - 2);
		}
		// стринг в бинарно и пак в стринг
		    public static byte[] ConvertToByteArray(string str, Encoding encoding)
            {
            return encoding.GetBytes(str);
            }

        public static String ToBinary(Byte[] data)
            {
            return string.Join(" ", data.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));
            }
			
		// в Main с вход:
		//  string input = Console.ReadLine();
            //string[] text = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //var lines = new char();
            //for (int i = 0; i < text.Length; i++)
            //    {
            //    text[i] = Console.ReadLine();
            //    String.Join(" ", input.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));
            //    }
            //var binaryString = ToBinary(ConvertToByteArray(input, Encoding.ASCII));

            //string[] byts = binaryString.Split(new[] { '0' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}

