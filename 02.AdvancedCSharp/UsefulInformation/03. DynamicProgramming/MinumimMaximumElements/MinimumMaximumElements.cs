using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MinumimMaximumElements
    {
    class MinimumMaximumElements
        {
        static void Main()
            {
            //finding the minimum element
            int[] arr = {3, 6, 3, 0, 9, 11, 20, 3};
            Console.WriteLine(FindMin(arr));
            Console.WriteLine(FindMax(arr));
            }
            
            // declaring method for minimum
            static int FindMin(int[] arr)
            {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] < min) min = arr[i];
            return min;
            }
            
            // declaring method for maximum
            static int FindMax(int[] arr)
            {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            if (arr[i] > max) max = arr[i];
            return max;
            }
        }
    }
