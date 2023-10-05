using System;
using System.Collections.Generic;
using System.Text;

namespace _4B_OOPS
{
    internal class MaxAndMinElement
    {
        public void FindMaxAndMin()
        {
            int n = Convert.ToInt16(Console.ReadLine());
            int[] arr = new int[6];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            int max = arr[0];
            int min = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                else if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Maximum Element is : " + max);
            Console.WriteLine("Minimum Element is : " + min);
        }
    }
}