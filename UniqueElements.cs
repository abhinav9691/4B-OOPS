using System;
using System.Collections.Generic;
using System.Text;

namespace _4B_OOPS
{
    internal class UniqueElements
    {
        public void checkUniqueElements()
        {
            int[] arr = new int[6];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                int j;
                for (j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        break;
                    }
                }
                if (i == j)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}