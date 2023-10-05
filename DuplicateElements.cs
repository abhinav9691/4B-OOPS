using System;
using System.Collections.Generic;
using System.Text;

namespace _4B_OOPS
{
    internal class DuplicateElements
    {
        public void getDuplicateElements()
        {
            int count = 0;
            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("Total duplicate is :" + count);
        }
    }
}