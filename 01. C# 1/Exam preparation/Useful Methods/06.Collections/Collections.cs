using System;
using System.Collections.Generic;

namespace _06.Collections
    {
    class Collections
        {
        static void Main()
            {
            // *********************************************************************************** List
            List<int> numbers1 = new List<int>();
            numbers1.Add(10);
            Console.WriteLine(numbers1.Count);
            Console.WriteLine(numbers1[1]);
            
            // List<T> как да добавяме, трием, броим елементи, като Т е типът променливи в листа:
            List<int> List = new List<int>();
            List.Add(); //- добавя елементи
            List.Remove(); //- премахва елементи //маха най-левия елемент
            List.Count(); //- връща големината на листа = Length при масиви
			List.RemoveAt() //- премахва елемент на съответната позиция
			List.Capacity() //- показва колко е капацитетът на листа
			List.TrimExcess() //- не добавя излишен капацитет
			List.Insert(index,value) //- на даден индекс добавя стойност и избутва елементите надясно
			List<int> numbersList = new List<int>();
			numbersList.Add(1);
			Console.WriteLine("Count: {0}", numbersList.Count);
			Console.WriteLine(string.Join(", ", numbersList)); // принтира листа
			List<int> nums = arr.ToList(); // масивът става лист
			
			// превръща лист от инт в лист от стринг: **************************************************
			List<int> numbers = new List<int>();
			numbers.Add(1);
			numbers.Add(5);
			string numbersAsString = string.Join(",", numbers); // or a simple space " "

            // ******************************************************************************** HashSet
            // съдържа уникални стойности
            // няма индекси, не може да се ползва for цикъл, а само foreach
            // Принтирането не гарантира реда, по който да се принтира
            HashSet<int> numbersSet = new HashSet<int>(); 
            numbersSet.Add(1);
            numbersSet.Add(1);
            Console.WriteLine(numbersSet.Count);
            
            foreach (int number in numbersSet)
                {
                Console.WriteLine(number);
                }
            
            // ******************************************************************************* SortedSet
            // сортира и пази уникалните, а не пази и не принтира всички
            SortedSet<int> numbersGroup = new SortedSet<int>();
            numbersGroup.Add(2);
            numbersGroup.Add(1);
            numbersGroup.Add(5);
            foreach (int number in numbersGroup)
                {
                Console.WriteLine(number);
                }
            // ******************************************************************************* Dictionary
            // работи като масив, но задаваме индекса какъв тип данни да бъде
            // първият параметър е индексатор/ключ/, а втория е стойността му.
            // търси за елемент и връща булев отговор
            // удобно е да се използва var 
            // не сортира
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict["pesho"] = 5;
            Console.WriteLine(dict["pesho"]);
            bool cont = dict.ContainsKey("pesho");
            Console.WriteLine(cont);
            var dictio = new Dictionary<string, int>();
            dictio["pesho"] = 5;
            dictio["gosho"] = 10;
            dictio["ivan"] = 15;
            foreach (var item in dictio)
                {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
                Console.WriteLine(item.Key + "-" + item.Value);
                }

            // ************************************************************************* Sorted Dictionary
            // принтира и сортира
            var sortedDict = new SortedDictionary<int, string>();
            sortedDict[5] = "Gosho";
            sortedDict[26] = "Ivan";
            sortedDict[11] = "Pesho";
            foreach (var item in sortedDict)
                {
                Console.WriteLine(item.Key);
                }

            // ************************************************************************************* Stack
            // като ракла с възглавници, изваждаме първо последната, за да стигнем до първата;
            // Може да си събираме методи вътре един след друг, контролираме извикването на методи
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(5);
            stack.Push(10);
            foreach (var item in stack)
                {
                Console.WriteLine(stack.Count);
                }
            int nextNumber = stack.Pop(); // изважда последния елемент
            Console.WriteLine(nextNumber);
            nextNumber = stack.Pop(); // изважда последния елемент
            Console.WriteLine(nextNumber);
            nextNumber = stack.Pop(); // изважда последния елемент
            Console.WriteLine(nextNumber);
            nextNumber = stack.Peek(); //погледни какво има отгоре, но не го вади
            Console.WriteLine(nextNumber);

            // ******************************************************************************Queue - опашка
            // обратното на стека, започва да вади от първия елемент към последния
            var queue = new Queue<int>();
            queue.Enqueue(5); // добавяне на елемент
            queue.Enqueue(10);
            queue.Enqueue(15);
            queue.Dequeue(); //премахване на елемент
            Console.WriteLine(queue.Dequeue());
            while (true) // алгоритъм за изваждане на всички елементи от опашката
                {
                if (queue.Count == 0)
                    {
                    break;
                    }
                Console.WriteLine(queue.Dequeue());
                }
            // втори вариант
            while (queue.Count != 0)
                {
                Console.WriteLine(queue.Dequeue());
                }
            }
        // метод за принтиране: ********************************************************************
			static void Print<T>(T number)
			{
				Console.WriteLine(number);
			}
			// в Main = > Print<string>("pesho");
        }
    }
