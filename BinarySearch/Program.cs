using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5,6,7,8,9 };

            Console.WriteLine(BinarySearch(arr, 3));
            Console.WriteLine(BinarySearch(arr, 1));
            Console.WriteLine(BinarySearch(arr, 9));
            Console.WriteLine(BinarySearch(arr, 0));
            Console.WriteLine(BinarySearch(arr, 10));

            Console.ReadLine();

        }

        public static bool  BinarySearch(int[] arr, int key)
        {
            //Learn
            // Mid is always in the while
            // While condition check should always be <=

            int L = 0;
            int H = arr.Length - 1;            

            while (L <= H)
            {

                int Mid = L + (H - L) / 2;
                if (arr[Mid] == key)
                {
                    return true;
                }
                else if (key > arr[Mid])
                {
                    L = Mid + 1;
                }
                else
                {
                    H = Mid - 1;
                }
            }

            return false;
        }
    }
}
