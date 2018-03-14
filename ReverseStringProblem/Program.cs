using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseStringWords("Hello World"));
            Console.WriteLine(ReverseStringAndTheWords("Hello World"));           

            Console.ReadLine();
         }

        //Reverse sTring
        public static string Reverse(string s)
        {
            char[] cArray = s.ToCharArray();

            int L = 0;
            int H = cArray.Length - 1;

            while (L < H)
            {
                char temp = cArray[H];
                cArray[H] = cArray[L];
                cArray[L] = temp;
                L++;
                H--;
            }

            return new string(cArray);
        }        

        //Reverse string words Input: Hello World > ollew dlrow
        public static string ReverseStringWords(string s)
        {
            char[] cArrar = s.ToCharArray();

            int start = 0;            

            for (int i = 0; i < cArrar.Length; i++)
            {
                if(cArrar[i] == ' ')
                {                    
                    ReverseWords(cArrar, start, i - 1);
                    start = i + 1;
                }                
            }

            ReverseWords(cArrar, start, cArrar.Length - 1);

            return new string(cArrar);
        }

        private static char[] ReverseWords(char[] arr, int start, int end)
        {
            while (start < end)
            {
                char temp = arr[end];
                arr[end] = arr[start];
                arr[start] = temp;

                start++;
                end--;
            }

            return arr;
        }

        //Reverse string with words input: Hello world > world > hello
        public static string ReverseStringAndTheWords(string s)
        {
            return Reverse(ReverseStringWords(s));
        }
    }
}
