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
                    //var A = inputNumbers.Select(n => n.Join(answer))
                    int A = 0, B = 0;
                    for (int i = 0; i <4; i++)
                    {
                        A += (inputNumbers[i] == answer[i]) ? 1 : 0;
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j <4; j++)
                        {
                            if (j == i) continue;
                            B += (inputNumbers[i] == answer[j]) ? 1 : 0;
                        }
                    }
                    //foreach (int i,j in inputNumbers, ananswer)
                    Console.WriteLine($"{A}A{B}B");
                }
                else
                {
                    Console.WriteLine("輸入錯誤");
                }
            }
        }
    }
}
