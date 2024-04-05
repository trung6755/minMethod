using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 6, 2, 6, 8, 3, 9, 1 };
            int index = Min(arr);
            Console.WriteLine("The min value is: " + arr[index]);
        }

        public static int Min(int[] arr)
        {
            int min = arr[0];
            int index = 0;

            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    index = i;
                }
            }

            return index;
        }
    }
}
