namespace _22.HelpfulHints
    {
    class HelpfulHints
        {
        static void Main()
        {
            /* 
            1/ first "1"-bits counting algorithm
            for (int i = 0; i < 64; i++)
                {
                if (1 == (number & 1))
                    {
                        counter++;
                    }
                number = number >> 1;
                }

            2/ second "1"-bits counting algorithm 
             
            for (int i = 0; i < 64; i++)
            {
                mask = (ulong)1 << i;
                ulong result = number & mask;
                if (result == mask)
                {
                    counter++;
                }
            }

            all "1"-bits counting algorithms are string-based
            for them to work we need a binary string representation of our number
             
            ulong remainder;
            string binary = string.Empty;
            while (number > 0)
            {
                remainder = number % 2;
                number /= 2;
                binary = remainder.ToString() + binary;
            }

            3/ third "1"-bits counting algorithm
            - comment the upper one and uncomment this one if you want to try it
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    counter++;
                }
            }

            4/ forth "1"-bits counting algorithm
            counter = binary.Count(x => x == '1');

            5/ fifth "1"-bits counting algorithm
            counter = binary.Where(x => x == '1').Count();

            6/ sixth "1"-bits counting algorithm
            counter = binary.Split('1').Length - 1;

            7/ seventh "1"-bits counting algorithm
            counter = binary.Length - (binary.Replace("1", "").Length);

            8/ eighth "1"-bits counting algorithm
            string pattern = "1";
            counter = Regex.Matches(binary, pattern).Count;*/
            }
        }
    }
