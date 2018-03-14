using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockBuySell
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 100, 40, 300, 30, 500, 20 };

            MaxProfit(arr);

            Console.ReadLine();
        }

        public static void MaxProfit(int[] arr)
        {
            int maxProfit = 0;
            int curMin = arr[0];
            int buy = 0;
            int sell = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < curMin)
                {
                    curMin = arr[i];
                }

                int currProfit = arr[i] - curMin;

                if(currProfit > maxProfit)
                {
                    maxProfit = currProfit;
                    buy = curMin;
                    sell = arr[i];
                }
            }

            Console.WriteLine($"Buy {buy} Sell {sell}");
        }
    }
}
