using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.CodeAnalysis;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace CSharpDailyDrills.Topics
{
    public struct Order
    {
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
    internal class LinqTopic03
    {
        public static void Run()
        {
            // url: https://chatgpt.com/share/680ef03b-43a8-8005-aa01-f9ca2d557790

            //string path = @"../products.csv"; // 或 "./products.csv"
            string path = @"D:\code\CS\csDailyDrills\products.csv";     
            //ReadFile(path);


            Console.WriteLine("\nRunning LinqTopic03 is successful.");
            List<string> csvFile = new List<string>
            {
                "CustomerName,ProductName,Quantity,Price",
                "Alice,Keyboard,2,100",
                "Bob,Mouse,1,40",
                "Alice,Monitor,1,300",
                "David,Keyboard,1,100",
                "Betty,Speaker,3,60",
                "Alice,Webcam,1,80",
                "Bob,Monitor,2,300"
            };

            List<string> tittleName = csvFile[0].Split(",").ToList();
            List<Order> orders = new List<Order>();
            foreach (var data in csvFile)
            {
                var datas = data.Split(",");
                orders.Add(new Order { CustomerName = datas[0], ProductName = datas[1], Quantity = int.Parse(datas[2]), Price = int.Parse(datas[3])});
            }


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


            Console.Write("請輸入 1~9 的數字：");
            if (int.TryParse(Console.ReadLine(), out int num) && num >= 1 && num <= 9)
            {
                actions[num - 1](tittleName, orders); // 用索引呼叫
            }
            else
            {
                Console.WriteLine("請輸入有效數字");
            }





        }

        //public static List<string> ReadFile(string path)
        //{   
        //    if (!File.Exists(path))
        //    {
        //        Console.WriteLine("找不到檔案！");
        //        return ("test").ToList();

        //    }

        //    using (StreamReader sr = new StreamReader(path))
        //    {
        //        string? line;
        //        while ((line = sr.ReadLine()) != null)
        //        {
        //            Console.WriteLine("讀到一行：" + line);
        //        }
        //    }
        //    return line;
        //}

    }
}
