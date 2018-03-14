using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArrayProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 10, 12, 11, 24, 1,1 };
            int[] arr2 = { 1,12, 11, 24, 10 };

            Console.WriteLine(CheckIfTwoArraysArePermutationsOfEachOther(arr1, arr2));
            Console.ReadLine();
        }

        public static bool CheckIfTwoArraysArePermutationsOfEachOther(int[] arr1, int[] arr2)
        {
            Dictionary<int, int> lookup1 = new Dictionary<int, int>();
            Dictionary<int, int> lookup2 = new Dictionary<int, int>();

            for (int i = 0; i < arr1.Length; i++)
            {
                if (lookup1.ContainsKey(arr1[i]))
                {
                    lookup1[arr1[i]]++;
                }
                else
                {
                    lookup1.Add(arr1[i], 1);
                }
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                if (lookup2.ContainsKey(arr2[i]))
                {
                    lookup2[arr2[i]]++;
                }
                else
                {
                    lookup2.Add(arr2[i], 1);
                }
            }

            foreach (var item in lookup2)
            {
                if (lookup1.ContainsKey(item.Key))
                {
                    if(item.Value != lookup1[item.Key])
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
