using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.UsefulLinq
    {
    class UsefulLinq
        {
        static void Main()
            {
            // Линк работи върху string, който е колекция
            string text = "pesho 123";
            var result = text.Count(s => char.IsLetter(s)); //isDigit
            Console.WriteLine(result);
            // ***************************************************************** с ints
            var numbers = new List<int>();

            numbers.Add(10);
            numbers.Add(5);
            numbers.Add(124);
            numbers.Add(15);
            numbers.Add(14);

            var result2 = numbers.Where(n => n % 5 == 0); //Where търси с ламбда израз
            var result3 = numbers.FirstOrDefault(n => n == 200); // търси първото по критерия или default - 0; другото е .LastOrDefault - същата функция, но вади последното число
            foreach (var number in result2)
                {
                Console.WriteLine(number);
                }
            // *************************************************************** стринг в инт
            var someText = new List<string>();
            someText.Add("1");
            someText.Add("2");
            someText.Add("3");
            someText.Add("4");
            someText.Add("5");

            var resultStr = someText.Select(t => int.Parse(t)) //Select ни помага да кажем какво искаме да
                .OrderBy(l => l) //подрежда по самото число           // направим с избрания стринг
                .Select(t => t + 12);
            //.Select(t => t[0]) или Select(t.First()); - селектира първа буква на стринга
            // внимаваме през какви стъпки минаваме = ако първо сортираме и после селектираме, ще работим върху сортираните и тн.                  
            foreach (var text3 in resultStr)
                {
                Console.WriteLine(text3);
                }
            // друг пример:
            // (t => t + 6) или (t => t.Lenght)
            //първо се прави това действие, което отнема по-малко ресурси, пр. 1.филтрираме 2.сортираме

            //********************************************************** Any & All - връща булев резултат
            var boolResult = someText.Any(t => t[0] == 'P'); //поне за един елемент
            var boolResult2 = someText.All(t => t.Length > 4 || t.Length < 7); // за всички в колецията
            var boolResult3 = someText.Where(t => t[0] == 'P' || t[t.Length - 1] == 'P');

            // ********************************** .ToList() .ToArray() 
            // с тях превръщаме една колекция в друга
            string[] array = someText.ToArray(); // обаче е най-добре да ползваме var

            // *********************************** .Reverse();
            var result4 = someText
                .OrderBy(t => t)
                .Reverse(); //или може да се използва .OrderByDescending();

            // ************************************
            // .Average(t => t.Lenght) или (t => t + 10) - дава средна стойност, може да се комбинира с Where и т.н.
            // .Count() - брои елементи и приема ламбда
            // .Max() и .Min() - дават минимална и максимална стойност в колецията
            // .Sum() - сумира елементите, приема ламбда

            // ******************* особености на Dictionary
            var dict = new Dictionary<string, int>();

            dict["Gosho"] = 5;
            dict["Pesho"] = 10;

            var dictResult = dict.Where(x => x.Value > 2)
                .OrderBy(x => x.Key)
                .Sum(x => x.Value);
            Console.WriteLine(dictResult);

            foreach (var dict1 in dictResult)
                {
                Console.WriteLine(dict1.Value); //задължително се посочват .Key и .Value, когато не се посочват като методи в колекцията
                }
            }
        }
    }
