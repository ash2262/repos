using System;

namespace BestTimeStockTrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StockBuySell stock = new StockBuySell();

            // stock prices on consecutive days
            int[] price = { 100, 180, 260, 310, 40, 535, 695 };
            int n = price.Length;

            // function call
            stock.stockBuySell(price, n);

        }
    }
    public class StockBuySell
    {

        public void stockBuySell(int[] price, int n)
        {
            int maxprofit = 0;
            int minprice = int.MaxValue;
            for (int i = 1; i < price.Length; i++)
            {
                if (price[i] < minprice)
                {
                    minprice = price[i];
                }
                else if (price[i] - minprice > maxprofit)
                {
                    maxprofit = price[i] - minprice;
                }
            }
            Console.WriteLine(maxprofit);
        }
    }
}
  
            //int min = 10000;
            //int max = -1;
            //int minindex = -1;
            //for (int i = 0; i < price.Length; i++)
            //{
            //    if (price[i] < min)
            //    {
            //        min = price[i];
            //        minindex = i;
            //    }
            //    if (price[i] > max && i > minindex)
            //    {
            //        max = price[i];
            //    }
            //}
            //Console.WriteLine( max-min);
       // }
 //   }
//}
