using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDailyDrills.Topics
{
    public static class LinqTopic03Funtion
    {
        //ProductNumber,ProductName,Amount,UnitPrice,ProductType
        
        public static void Function1(List<string> tittleName, List<Order> orders)
        {
            // 1. 計算所有商品的總金額（UnitPrice * Amount）  
            Console.WriteLine("你選擇了功能 1");
            var reslut = orders.Sum(o => o.UnitPrice * o.Amount);
            Console.WriteLine($"商品的總金額: {reslut}");
        }
        public static void Function2(List<string> tittleName, List<Order> orders)
        {
            // 2. 計算所有商品的平均價格 
            Console.WriteLine("你選擇了功能 2");
            //foreach (var i in orders)
            {
                Console.WriteLine($"所有商品的平均價格: {orders.Average(n => n.UnitPrice):N0}");
            }
        }
        public static void Function3(List<string> tittleName, List<Order> orders)
        {
            // 3. 分別計算該類別底下所有產品的總金額（UnitPrice * Amount）
            Console.WriteLine("你選擇了功能 3");
            var result = orders
                .GroupBy(n => n.ProductType)
                .Select(m => new {type = m.Key, totalPrice = m.Sum(o => o.UnitPrice * o.Amount)}) ;
            foreach(var i in result)
            {
                Console.WriteLine($"類別 {i.type} 下產品的總金額: {i.totalPrice:N0}");
            }
        }
        public static void Function4(List<string> tittleName, List<Order> orders)   
        {
            // 4. 計算商品的總數量  
            Console.WriteLine("你選擇了功能 4");
            Console.WriteLine($"商品的總數量: {orders.Sum(n => n.Amount):N0}");
        }
        public static void Function5(List<string> tittleName, List<Order> orders)
        {
            // 5. 計算商品的平均數量
            Console.WriteLine("你選擇了功能 5");
            Console.WriteLine($"商品的平均數量: {orders.Average(n => n.Amount):N2}");

        }
        public static void Function6(List<string> tittleName, List<Order> orders)
        {
            // 6. 找出哪一項商品最貴  
            Console.WriteLine("你選擇了功能 6");
            var maxProduct = orders.OrderByDescending(o => o.UnitPrice).FirstOrDefault();
            Console.WriteLine($"最貴的商品為: {maxProduct.ProductName}\n價格為: {maxProduct.UnitPrice:N0}");
        }
        public static void Function7(List<string> tittleName, List<Order> orders)
        {
            // 7. 找出哪一項商品最便宜
            Console.WriteLine("你選擇了功能 7");
             var maxProduct = orders.OrderBy(o => o.UnitPrice).FirstOrDefault();
            Console.WriteLine($"最便宜的商品為: {maxProduct.ProductName}\n價格為: {maxProduct.UnitPrice:N0}");

        }
        public static void Function8(List<string> tittleName, List<Order> orders)
        {
            // 8. 找出各個商品類別底下有哪些商品的價格是大於 1000 的商品，若該類別底下找不到價格大於 1000 的商品，顯示“找不到價格大於 1000 的商品”。  
            Console.WriteLine("你選擇了功能 8");
            foreach (var type in orders.GroupBy(o => o.ProductType))
            {   
                var expensiveProducts = type.Where(n => (n.UnitPrice > 1000));
                Console.WriteLine($"商品類別: {type.Key}");
                if (!expensiveProducts.Any())
                {
                    Console.WriteLine("\t找不到價格大於 1000 的商品");
                }
                else
                {
                    foreach (var i in expensiveProducts)
                    {                        
                        Console.WriteLine($"\t價格是大於 1000 的商品: {i.ProductName}, 價格: {i.UnitPrice}");
                    }
                }

            }

        }
        public static void Function9(List<string> tittleName, List<Order> orders)
        {
            // 9. 延上題，利用上一題的結果算出平均價格，若該類別底下找不到價格大於 1000 的商品，則輸出與上題一樣的訊息。  
            Console.WriteLine("你選擇了功能 9");
            foreach (var type in orders.GroupBy(o => o.ProductType))
            {
                var expensiveProducts = type.Where(m => m.UnitPrice > 1000);

                Console.WriteLine($"商品類別: {type.Key}");
                if (expensiveProducts.Any())
                {
                    Console.WriteLine($"\t平均價格: {expensiveProducts.Average(n => n.UnitPrice)}");
                }
                else
                {
                    Console.WriteLine("\t找不到價格大於 1000 的商品");
                }

            }
        }
        public static void Function10(List<string> tittleName, List<Order> orders) 
        {
            // 10. 依照商品價格由高到低排序  
            Console.WriteLine("你選擇了功能 10");
            foreach (var item in orders.OrderByDescending(n => n.UnitPrice))
            {
                Console.WriteLine($"商品: {item.ProductName},價格: {item.UnitPrice}");
            }
        }
        public static void Function11(List<string> tittleName, List<Order> orders) 
        {
            // 11. 依照商品數量由低到高排序  
            Console.WriteLine("你選擇了功能 11");
            foreach (var item in orders.OrderBy(n => n.UnitPrice))
            {
                Console.WriteLine($"商品: {item.ProductName},價格: {item.UnitPrice}");
            }
        }
        public static void Function12(List<string> tittleName, List<Order> orders) 
        {
            // 12. 找出各商品類別底下，最貴的商品  
            Console.WriteLine("你選擇了功能 12");
            var mostExpensiveByType = orders
                .GroupBy(m => m.ProductType)
                .Select(n => new {productType = n.Key, maxProduct = n.OrderByDescending(o => o.UnitPrice).First() });
            foreach (var i in mostExpensiveByType)
            {
                Console.WriteLine($"類別 {i.productType} 中，最貴的商品為: {i.maxProduct.ProductName}, 價格: {i.maxProduct.UnitPrice} ");
            }

        }
        public static void Function13(List<string> tittleName, List<Order> orders) 
        {
            // 13. 找出各商品類別底下，最便宜的商品  
            Console.WriteLine("你選擇了功能 13");
            
            var mostExpensiveByType = orders
                .GroupBy(m => m.ProductType)
                .Select(n => new { productType = n.Key, maxProduct = n.OrderBy(o => o.UnitPrice).First() });
            foreach (var i in mostExpensiveByType)
            {
                Console.WriteLine($"類別 {i.productType} 中，最便宜的商品為: {i.maxProduct.ProductName}, 價格: {i.maxProduct.UnitPrice} ");
            }
        }
        public static void Function14(List<string> titleName, List<Order> orders)
        {
            Console.WriteLine("你選擇了功能 14");

            int pageSize = 4;
            int totalPages = (int)Math.Ceiling((double)orders.Count / pageSize);

            Console.Write($"請輸入要查看的頁數（1 ~ {totalPages}）：");
            if (int.TryParse(Console.ReadLine(), out int page) && (page <= totalPages) && (page > 0))
            {
                Console.WriteLine($"\n第 {page} 頁（每頁 {pageSize} 筆，共 {totalPages} 頁）");
                Console.WriteLine(string.Join(" \t| ", titleName)); 
                foreach (var i in orders.Skip((page-1) * pageSize).Take(pageSize))
                {
                    Console.WriteLine($" {i.ProductNumber},\t\t {i.ProductName}, \t {i.Amount}, \t\t {i.UnitPrice},\t\t {i.ProductType}");
                }
            }
            else
            {
                Console.WriteLine("請輸入有效的頁數！");
            }
        }



    }
}
