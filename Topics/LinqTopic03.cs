using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDailyDrills.Topics
{
    internal class LinqTopic03
    {   
        struct Order
        {
            public string CustomerName { get; set; }
            public string ProductName { get; set; }
            public int Quantity { get; set; }
            public int Price { get; set; }
        }
        public static void Run()
        {
            // url: https://chatgpt.com/share/680ef03b-43a8-8005-aa01-f9ca2d557790
            Console.WriteLine("\nRunning LinqTopic02 is successful.");
            string[] csvFile = new[]
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

            var dataList = csvFile.Skip(1).Select(n => n.Split(",")).ToList(Order);
            List<Order> orders = new List<Order>();
            foreach (var data in dataList)
            {
                orders.Add(new Order { CustomerName = data.CustomerName, ProductName = data.ProductName, Price = data.Quantity });
            }
            // 1





















        }
    }
}
