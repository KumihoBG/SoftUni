using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace _04.StringsGeneral
    {
    class Strings
        {
        static void Main()
            {
            // стринговете са immutable = всеки път да се създава нов стринг за резултата! (read-only)
            //премахва празните пространства в стринга и прави главни букви:****************************
            string word1 = Console.ReadLine().Trim().ToUpper();

            // *****************************************************************************************
            // пропускаш X елемента, вземаш следващите Y и 
            // ги печаташ, x и y трябва да са ints, arr е името на масива.
            int[] arr = new int[5];
            int y = 0;
            int x = 0;
            Console.WriteLine(string.Join(", ", arr.Skip(x).Take(y)));

            // сравняване на стрингове: ****************************************************************
            // при ставняване се връща резултат int
            // няма унифициран начин за сравняване на стрингове. Компютърът слага малките букви преди големите. Примери:
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            Console.WriteLine(String.Compare("abc", "abcd", StringComparison.Ordinal));
            int result1 = String.Compare(str1, str2, StringComparison.OrdinalIgnoreCase); //ако е true, case-insensitive
			
			// oот стринг към чар и промяна в главни букви (ASCII)
			string textInput = "you thought this deer was real...nope, just chuck testa.";
			char[] arrayOfSymbols = textInput.ToCharArray();
			for (int i = 0; i < arrayOfSymbols.Length; i++)
                {
                if (arrayOfSymbols[i] % 3 == 0)
                    {
						arrayOfSymbols[i] = Char.ToUpper(arrayOfSymbols[i]);
                    }
                }
				
			for (int i = 0; i < arrayOfSymbols.Length; i++)
                {
					Console.Write(arrayOfSymbols[i]);
                }
				
            //друг начин за сравняване *****************************************************************
            // ако резултатът е нула - еднакви са, ако е минус - първи преди втори, ако е плюс - втори преди първи
            int result2 = String.CompareOrdinal(str1, str2); // ако е false, case-sensitive
            Console.WriteLine("pesho" == "Pesho"); // Тук обаче сравнява по ASCII таблицата, case-sensitive
            Console.WriteLine("pesho".Equals("Pesho")); //същият резултат, като горния пример, case-sensitive

            // Обръщане на стринг наобратно:
			string input = Console.ReadLine();
			string output = new string(input.Reverse().ToArray());
			Console.WriteLine(output);
			
			// Reverse на думи в изречение:****************************************************************
            string text13 = Console.ReadLine();
            char sign = text[text.Length - 1];
            text13 = text13.Remove(text.Length - 1, 1); //using Linq - method Remove

            string[] newSentence = text13.Split(' '); // new array created

            var reversed = newSentence.Reverse(); // array is now reversed
            //creating the new reversed sentence
            Console.WriteLine("{0}{1}", string.Join(" ", reversed), sign);

            // търсене в стрингове:**********************************************************************
            string text1 = "pesho";
            int index = text1.IndexOf("pes", StringComparison.Ordinal); // или ("pes", 1) от кой индекс започва - от нулев или по наш избор
            Console.WriteLine(index + "pes".Length - 1); // за да видим на кой индекс свършва
            int result8 = text1.LastIndexOf("pesho", StringComparison.Ordinal); //търси от последния индекс

            // търси за индекса на даден елемент в стринга ************************************************
            string text3 = "pesho gosho pesho tosho ivan pesho";
            index = 0;
            while (true)
                {
                int found = text3.IndexOf("pesho", index, StringComparison.Ordinal);
                if (found < 0)
                    {
                    break;
                    }
                Console.WriteLine(found);
                index = found + 1;
                }
            // Extract на изречение, което съдържа дадена дума: *******************************************
            string input = Console.ReadLine(); // изречение
            string substring = Console.ReadLine(); // дума в него
            string word2 = substring + " ";

            StringBuilder result = new StringBuilder();

            string[] text11 = input.Split('.', '!', ',', ';');
            for (int i = 0; i < text11.Length; i++)
                {
                if (text11[i].Contains(word2))
                    {
                    result.Append(text11[i] + ".");
                    }
                }
            Console.WriteLine(result);
			
            // Extract на e-mail address: *****************************************************************
            string text33 = Console.ReadLine();

            //calling the method and printing
            Console.WriteLine(String.Join("\n", ExtractEmail(text33)));
			
            // Extract на дата от текст в определен формат: ***********************************************
            string input4 = Console.ReadLine();
            string[] words = input4.Split(' ');
            for (int i = 0; i < words.Length; i++)
                {
                try
                    {
                    DateTime date = DateTime.ParseExact(words[i].TrimEnd(new char[] { ',', '.', '!', '?' }), "d.M.yyyy",
                        CultureInfo.InvariantCulture);
                    Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-CA");
                    Console.WriteLine("{0}", date.Date.ToLongDateString());
                    }
                catch (FormatException)
                    {
                    }
                }
            // Extract на думи, които се четат еднакво отзад напред и обратно: ****************************
            string text14 = Console.ReadLine();
            string[] words3 = text14.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words3)
                {
                var list = new StringBuilder(); //using StringBuilder
                for (int i = word.Length - 1; i >= 0; i--)
                    {
                    list.Append(word[i]);
                    }

                if (word == list.ToString())
                    {
                    Console.WriteLine(word);
                    }
                }
            // Extract на текст от HTML: ******************************************************************
            string text16 = Console.ReadLine();
            var extract = new StringBuilder();
            bool isText = false;
            for (int i = 0; i < text16.Length - 1; i++)
                {
                if (text16[i] == '<')
                    {
                    isText = false;
                    }
                if (isText)
                    {
                    extract.Append(text16[i]);
                    }
                if (text16[i] == '>')
                    {
                    isText = true;
                    extract.Append(' ');
                    }
                }
            Console.WriteLine(extract.ToString().Trim());
			
            // Чете стринг и брои буквите, като изписва колко пъти се срещат в текста: ********************
            string text15 = Console.ReadLine();
            //creating dictionary to store the result
            var result23 = new Dictionary<char, int>();

            for (int i = 0; i < text15.Length; i++)
                {
                if (!result23.ContainsKey(text15[i]) && char.IsLetter(text15[i]))
                    {
                    result23.Add(text15[i], 1);
                    }
                else if (result23.ContainsKey(text15[i]) && char.IsLetter(text15[i]))
                    {
                    result23[text15[i]] += 1;
                    }
                }
            Console.WriteLine();

            // printing the result
            foreach (var letter in result23)
                {
                Console.WriteLine("The letter {0} is found {1} times in the given text.", letter.Key, letter.Value);
                
				
            //Чете стринг и брои думи и колко пъти се срещат: *********************************************
            string input5 = Console.ReadLine();
            string[] text = input5.Split(new[] { ' ', ',', '!', '.' }, StringSplitOptions.RemoveEmptyEntries);

            //creating dictionary to store the result
            var dictionary = new Dictionary<string, int>();

            //sorting the array
            Array.Sort(text);

            // searching and counting
            for (int i = 0; i < text.Length; i++)
                {
                int counter = 0;
                foreach (var word in text)
                    {
                    if (word == text[i])
                        {
                        counter++;
                        }
                    }
                if (!dictionary.ContainsKey(text[i]))
                    {
                    dictionary.Add(text[i], counter);
                    }
                }
            // printing the result
            foreach (var pair in dictionary)
                {
                Console.WriteLine(pair.Key, pair.Value);
                }
				
            // Search and count - търси колко пъти се среща елемент/част от стринга: *****************************************
            string target = Console.ReadLine().ToLower(); 
            string text = Console.ReadLine().ToLower();

            int count = text.Select((c, i) => text.Substring(i)).Count(sub => sub.StartsWith(target));
			Console.WriteLine(count);

            // Substring - вади част от стринг ************************************************************
            string text4 = "pesho gosho";
            string subStr1 = text4.Substring(5); // изрязва до 5 индекс
            string subStr2 = text4.Substring(6, 3); // изрязва от 6 индекс следващите 3
			
            // Split - разделя стринга по интервал, запетайка и т.н. и го превръща в масив *****************
            string text5 = "1 2 3 4 5";
            string[] numbersAsText = text5.Split(new char[] { ' ', ',', '!', '.' }, StringSplitOptions.RemoveEmptyEntries);

            int[] newNumbers = new int[numbersAsText.Length]; // превръща в числа
            for (int i = 0; i < numbersAsText.Length; i++)
                {
                newNumbers[i] = int.Parse(numbersAsText[i]);
                }
           
            // Replace на дума със знак, цензуриране на думи: *********************************************
            string text12 = Console.ReadLine().ToLower(); // текст
            string forbiddenWords = Console.ReadLine().ToLower(); // цензурна дума
            char[] separators = { ',', ' ' };
            string[] forbiddenWordsArr = forbiddenWords.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            //finding the forbidden words, цензура
            for (int i = 0; i < forbiddenWordsArr.Length; i++)
                {
                // creating new string builder to store the new text
                StringBuilder newText = new StringBuilder();
                newText.Append('*', forbiddenWordsArr[i].Length); //replacing the forbidden words with *
                text12 = text12.Replace(forbiddenWordsArr[i], newText.ToString()); //replacing the input
                }
            Console.WriteLine(text12);
			
			// вариант с регулярен израз за цензура:
			string text = Console.ReadLine();
			string[] blackList = { "PHP", "CLR", "Microsoft" };
			string regex = string.Format(@"\b({0})\b", string.Join("|", blackList));
            Console.WriteLine("Result: \n\n{0}\n", Regex.Replace(text, regex, word => new string('*', word.Length)));
			
            // Replace на тагс с url: *********************************************************************
            string input2 = Console.ReadLine();
            // replacing
            input2 = input2.Replace("<a href=\"", "[URL=");
            input2 = input2.Replace("</a>", "[/URL]");
            input2 = input2.Replace("\">", "]");
            // printing
            Console.WriteLine(input);
			// С регулярен израз: Console.WriteLine(Regex.Replace(HTML, @"<a href=""(.*?)"">(.*?)</a>", @"[URL=$1]$2[/URL]"));
			
            // замества частта от стринга, която се намира между тагове, с главни букви:*******************
            string text10 = Console.ReadLine();
            string pattern = "<upcase>(.*?)</upcase>"; //creating a pattern for replace
			// match and print using regular expressions
            Console.WriteLine(Regex.Replace(text10, pattern, word => word.Groups[1].Value.ToUpper()));
			
            // Remove(index,lenght) - премахва от даден индекс, дадена дължина, връща изтритата част като резултат
            string text7 = "gosho";
            string newString = text7.Remove(0, 3); //обратното на Substring
			
            // Trim - зачиства white-space ****************************************************************
            string a = text7.TrimStart(); //изчиства отпред, пред стринга
            string b = text7.TrimEnd(); // изчиства след стринга
            string c = text7.Trim('a'); // изчиства определени символи
			
            // StringBuilder = по-бързи операции, да се използва за изпит, увеличава времето за изпълнение
            // using System.Text; работи като List, не е immutable, презаписва се
            StringBuilder sb = new StringBuilder();
            sb.Append("Numbers: ");
            for (index = 1; index <= 200000; index++)
                {
                sb.Append(index);
                }
            Console.WriteLine(sb.ToString().Substring(0, 1024));
			
            // string.Format("{0:F2}", 45); **************************************************************
            string text8 = string.Format("{0:F2}", 45); // използва се за template, има го в слайда
            Console.WriteLine(text8); //по-бърз performance
					
            // Парсване на дата ***************************************************************************
            DateTime parsed = DateTime.ParseExact("17.02.2015", "dd.MM.yy", CultureInfo.InvariantCulture);
            Console.WriteLine(parsed.Year);
			
            // Парсване на URL address: *******************************************************************
            string url = "http://telerikacademy.com/Courses/Courses/Details/212";
            int protocolLength = url.IndexOf(":", StringComparison.Ordinal);
            int serverLength = url.IndexOf("/", protocolLength + 3, StringComparison.Ordinal) - protocolLength - 3;
            int resoourceStartIndex = url.IndexOf("/", protocolLength + 3, StringComparison.Ordinal);

            string protocol = url.Substring(0, protocolLength);
            string server = url.Substring(protocolLength + 3, serverLength);
            string resource = url.Substring(resoourceStartIndex);
            Console.WriteLine(protocol);
            Console.WriteLine(server);
            Console.WriteLine(resource);
			
			// Парсване на URL, регулярен израз:
			const string URL = @"http://telerikacademy.com/Courses/Courses/Details/212";
			var fragments = Regex.Match(URL, "(.*)://(.*?)(/.*)").Groups;

			Console.WriteLine("URL Address: {0}", URL);
			Console.WriteLine("\n[protocol] = {0}", fragments[1]);
			Console.WriteLine("[server] = {0}", fragments[2]);
			Console.WriteLine("[resource] = {0}\n", fragments[3]);
			
            // DateTime - разлика между дни: **************************************************************
            string startingDate = Console.ReadLine();
            DateTime start = DateTime.ParseExact(startingDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            string endingDate = Console.ReadLine();
            DateTime end = DateTime.ParseExact(endingDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            // the distance between the days
            var result22 = start - end;
            // printing the result, using Math.Abs to format it
            Console.WriteLine("{0}", Math.Abs(result22.Days));
            // DateTime - добавяне на часове към времето: 
            }

        // метод за извличане на главни букви в стринг
        public static string ExtractCapitals(string str)
            {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
                {
                char ch = str[i];
                if (char.IsUpper(ch))
                    {
                    result.Append(ch);
                    }
                }
            return result.ToString();
            }
			
		// метод за конвертиране на символи в unicode:
			static string ConvertToUnicode(string word)
		{
			return word.Aggregate(string.Empty, (current, t) => current + string.Format(@"\n{0:X4}", (int)t));
		}
	
        // метод за проверка положението на скоби в стринг
        static bool ExtractBrackets(string text)
            {
            int bracketsCounter = 0; //starting to count the brackets
            if (text[0].ToString() == ")") // if the zero index is ")" the result will be false
                {
                return false;
                }
            for (int i = 0; i < text.Length; i++) // else we start a cicle to count the brackets
                {
                if (text[i].ToString() == "(")
                    {
                    bracketsCounter++;
                    }
                else if (text[i].ToString() == ")")
                    {
                    bracketsCounter--;
                    }
                }
            if (bracketsCounter == 0) // we must be sure that the brackets are not less than a zero position
                {
                return true;
                }
            return false;
            }
        // методи за криптиране на стринг с ключ
        // declaring the Encrypting method
        static string Encrypt(string str, string key)
            {
            StringBuilder cipher = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
                {
                cipher.Append((char)(str[i] ^ key[i % key.Length]));  // using XOR operator
                }
            return cipher.ToString();
            }

        // declaring the Decrypting method
        static string Decrypt(string word, string key)
            {
            return Encrypt(word, key);
            }
        // Метод за extract e-mails
        private static List<string> ExtractEmail(string text)
            {
            var emails = new List<string>();
            string[] email = text.Split(new char[] { '"', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in email)
                {
                if (word.Contains("@"))
                    {
                    emails.Add(word);
                    }
                }
            return emails;
            }
        // Reverse string using StringBuilder:
        public static string ReverseText(string text)
            {
            StringBuilder sb = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
                sb.Append(text[i]);
            return sb.ToString();
            }
        // Метод за намиране на по-голямо число измежду две:
        private static int GetMax(int first, int second)
            {
            if (first > second)
                {
                return first;
                }
            else if (second > first)
                {
                return second;
                }
            return first;
            }
        }
    }
