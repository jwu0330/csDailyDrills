using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDailyDrills.Topics
{
    internal class LinqTopic04_1A2B
    {
        public static void Run()
        {
            int[] answer = { 1, 3, 4, 8 };
            while (true)
            {
                Console.WriteLine("請輸入數字: ");
                int[] inputNumbers = [.. Console.ReadLine().Take(4).Select(c => int.Parse(c.ToString()))];
                if (inputNumbers.Distinct().Count() == 4)
                {
                    Console.WriteLine($"{string.Join(',', inputNumbers)}");
                    var A = inputNumbers.Zip(answer, (a, b) => a == b).Count(match => match);
                    var bothHave = inputNumbers.Intersect(answer).Count();
                    Console.WriteLine($"{A}A{bothHave - A}B");
                }
                else
                {
                    Console.WriteLine("輸入錯誤");
                }
            }
        }
    }
}
