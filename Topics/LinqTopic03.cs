using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.CodeAnalysis;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.CompilerServices;
namespace CSharpDailyDrills.Topics
{
    public struct Order
    {
        //ProductNumber,ProductName,Amount,UnitPrice,ProductType

        public string ProductNumber { get; set; }
        public string ProductName { get; set; }
        public int Amount { get; set; }
        public int UnitPrice { get; set; }
        public string ProductType { get; set; }
    }
    internal class LinqTopic03
    {
        public static List<string> tittleName = new List<string>();
        public static List<Order> orders = new List<Order>();
        public static void Run()
        {
            // url: https://chatgpt.com/share/680ef03b-43a8-8005-aa01-f9ca2d557790

            //string path = @"../products.csv"; // 或 "./products.csv"
            string path = @"D:\code\CS\csDailyDrills\products.csv";

            (tittleName, orders) = ReadFile(path);

            Console.WriteLine("\nRunning LinqTopic03 is successful.");
            //func
            var actions = new List<Action<List<string>, List<Order>>>
            {
                LinqTopic03Funtion.Function1,
                LinqTopic03Funtion.Function2,
                LinqTopic03Funtion.Function3,
                LinqTopic03Funtion.Function4,
                LinqTopic03Funtion.Function5,
                LinqTopic03Funtion.Function6,
                LinqTopic03Funtion.Function7,
                LinqTopic03Funtion.Function8,
                LinqTopic03Funtion.Function9,
                LinqTopic03Funtion.Function10,
                LinqTopic03Funtion.Function11,
                LinqTopic03Funtion.Function12,
                LinqTopic03Funtion.Function13,
                LinqTopic03Funtion.Function14
            };

            while (true)
            {
                Console.Write("請輸入 1~9 的數字：");
                if (int.TryParse(Console.ReadLine(), out int num) && num >= 1 && num <= 15)
                {
                    actions[num - 1](tittleName, orders); // 用索引呼叫
                }
                else
                {
                    Console.WriteLine("請輸入有效數字");
                }
                Console.WriteLine("\n");
            }
        }

        public static (List<string>, List<Order>)ReadFile(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("找不到檔案！");
                return ([], []);
            }
            var lineStrings = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                string? line;
                if ((line = sr.ReadLine()) != null)
                {
                    tittleName = line.Split(",").ToList();
                }
                while ((line = sr.ReadLine()) != null)
                {
                    var datas = line.Split(",");
                    orders.Add(new Order { ProductNumber = datas[0], ProductName = datas[1], Amount = int.Parse(datas[2]), UnitPrice = int.Parse(datas[3]), ProductType = datas[4] });
                    //lineStrings.Add(line);
                }
            }
            return (tittleName, orders);
        }

    }
}
