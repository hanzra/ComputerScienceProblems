using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSimpleProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";

            s.
            //Console.WriteLine(FindIfStringContainsUniqueChar("testc"));

            //   Console.WriteLine(UrlfyString(new char[] { 'm', 'r', ' ', 'j', 'o', 'h', 'n', ' ', 'i', 's', ' ', ' ', ' ', ' ' }
            //   , 10));

              Console.WriteLine(CompressString("aabcccccaa"));
              Console.ReadLine();
        }

        //public static bool IfStringRotation(string s1, string s2)
        //{

        //}

        /// <summary>
        /// aabcccccaa > a2b1c5a2
        /// </summary>
        /// <returns></returns>
        public static string CompressString(string s)
        {
            int count = 1;
            StringBuilder sb = new StringBuilder();
            sb.Append(s.ElementAt(0));

            for (int i = 1; i < s.Length; i++)
            {
                if(s.ElementAt(i) == s.ElementAt(i - 1))
                {
                    count++;
                }
                else
                {
                    sb.Append(count);
                    sb.Append(s.ElementAt(i));
                    count = 1;
                }
            }

            sb.Append(count);

            string resultStr = sb.ToString();

            return resultStr.Length < s.Length ? resultStr : s;

        }

        /// <summary>
        ///  pale, ple > true
        ///  pales, pale > true
        ///  pale, base > true
        ///  pale, bae > false
        /// </summary>     
        public static bool CheckIfTwoStringsAreEditAway(string a, string b) {

            //Could not solve in first attempt

            return true;
        }

        


        public static string CheckIfStringIsaPermutationOfPalindrom()
        {
            return "";
        }

        // "Mr John is    " -> "Mr%20John"
        public static string UrlfyString(char[] str, int trueLength)
        {
            int endOfTrueLength = trueLength - 1;
            int tempIndex = str.Length - 1;

           for (int i = trueLength - 1; i >=0; i--)
            {
                if(str[i] == ' ')
                {
                    while (endOfTrueLength > i)
                    {
                        str[tempIndex--] = str[endOfTrueLength--];
                    }
                    str[tempIndex--] = '0';
                    str[tempIndex--] = '2';
                    str[tempIndex--] = '%';
                    endOfTrueLength--;
                }
            }

            return new string(str);
        }

        public static bool FindIfOneStringIsPermutationOfOther()
        {
            //do it efficiently afterwards
            return true;
        }

        public static bool FindIfStringContainsUniqueChar(string s) // T:O(n), S:O(1) 
        {
            if(s == null)
            {
                throw new ArgumentException("");
            }

            if (s.Length == 1)
            {
                return true;
            }

            int[] lookup = new int[128];

            for (int i = 0; i < s.Length; i++)
            {
                if(lookup[s.ElementAt(i)] == 1)
                {
                    return false;
                }
                else
                {
                    lookup[s.ElementAt(i)]++;
                }
            }
            return true;
        }
    }
}
