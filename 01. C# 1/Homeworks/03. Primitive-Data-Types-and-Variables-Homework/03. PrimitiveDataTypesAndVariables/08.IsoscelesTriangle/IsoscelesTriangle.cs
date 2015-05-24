/* Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
   ©
  © ©
 ©   ©
© © © ©
Note that the © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console. Note also, that under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.*/

namespace _08.IsoscelesTriangle
    {
    using System;
    using System.Text;

    class IsoscelesTriangle
        {
        static void Main()
            {
            Console.OutputEncoding = Encoding.Unicode;
            char copyright = '©';
            Console.WriteLine("{0,4}", copyright);
            Console.WriteLine();
            Console.WriteLine("{0,3}" + "{0,2}", copyright);
            Console.WriteLine();
            Console.WriteLine("{0,2}" + "{0,4}", copyright);
            Console.WriteLine();
            Console.WriteLine("{0}" + "{0,2}" + "{0,2}" + "{0,2}", copyright);
            }
        }
    }
