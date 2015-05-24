/*Problem 4. Rectangles

Write an expression that calculates rectangle’s perimeter and area by given width and height.
Examples:

width	height	perimeter  area
3	    4	    14	       12
2.5	    3	    11         7.5
5	    5       20         25 */

using System;
using System.Globalization;
using System.Threading;

class Rectangles
    {
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter the height of the rectange:");
        double height = double.Parse(Console.ReadLine());
        Console.Write("Enter the wight of the rectange:");
        double width = double.Parse(Console.ReadLine());
        double area = height * width;
        double perimeter = 2 * (height + width);
        Console.WriteLine("The perimeter of the rectangle is: {0}", perimeter);
        Console.WriteLine("The area of the rectange is: {0}", area);
        }
    }
