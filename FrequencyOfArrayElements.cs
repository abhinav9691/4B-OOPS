using System;
using System.Collections.Generic;
using System.Text;

namespace _4B_OOPS
{
    internal class FrequencyOfArrayElements
    {
        public void FrequencyofElements()
        {
            int n = Convert.ToInt16(Console.ReadLine());
            int count;
            int[] arr = new int[10];
            int[] arr1 = new int[10];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt16(Console.ReadLine());
                arr1[i] = -1;
            }
            for (int i = 0; i <= n; i++)
            {
                count = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        arr1[j] = 0;
                    }
                }
                if (arr1[i] != 0)
                {
                    arr1[i] = count;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (arr1[i] != 0)
                {
                    Console.WriteLine(arr[i] + " Occurs  : " + arr1[i] + " Times");
                }
            }
        }
    }
}









