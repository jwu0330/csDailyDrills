using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDailyDrills.Topics
{
    public static class LinqTopic03Funtion
    {
        public static void Function1(List<string> tittleName, List<Order> orders)
        {
            // 1. 計算所有商品的總金額（UnitPrice * Amount）  
            Console.WriteLine("你選擇了功能 1");
            Console.WriteLine(tittleName[0]);

         }
        public static void Function2(List<string> tittleName, List<Order> orders)
        {
            // 2. 計算所有商品的平均價格 
            Console.WriteLine("你選擇了功能 2");
        }
        public static void Function3(List<string> tittleName, List<Order> orders)
        {
            // 3. 分別計算該類別底下所有產品的總金額（UnitPrice * Amount）
            Console.WriteLine("你選擇了功能 3");
        }
        public static void Function4(List<string> tittleName, List<Order> orders)
        {
            // 4. 計算商品的總數量  
            Console.WriteLine("你選擇了功能 4");
        }
        public static void Function5(List<string> tittleName, List<Order> orders)
        {
            // 5. 計算商品的平均數量
            Console.WriteLine("你選擇了功能 5");
        }
        public static void Function6(List<string> tittleName, List<Order> orders)
        {
            // 6. 找出哪一項商品最貴  
            Console.WriteLine("你選擇了功能 6");
        }
        public static void Function7(List<string> tittleName, List<Order> orders)
        {
            // 7. 找出哪一項商品最便宜
            Console.WriteLine("你選擇了功能 7");
        }
        public static void Function8(List<string> tittleName, List<Order> orders)
        {
            // 8. 找出各個商品類別底下有哪些商品的價格是大於 1000 的商品，若該類別底下找不到價格大於 1000 的商品，顯示“找不到價格大於 1000 的商品”。  
            Console.WriteLine("你選擇了功能 8");
        }
        public static void Function9(List<string> tittleName, List<Order> orders)
        {
            // 9. 延上題，利用上一題的結果算出平均價格，若該類別底下找不到價格大於 1000 的商品，則輸出與上題一樣的訊息。  
            Console.WriteLine("你選擇了功能 9");
        }
        public static void Function10(List<string> tittleName, List<Order> orders) 
        {
            // 10. 依照商品價格由高到低排序  
            Console.WriteLine("你選擇了功能 10");
        }
        public static void Function11(List<string> tittleName, List<Order> orders) 
        {
            // 11. 依照商品數量由低到高排序  
            Console.WriteLine("你選擇了功能 11");
        }
        public static void Function12(List<string> tittleName, List<Order> orders) 
        {
            // 12. 找出各商品類別底下，最貴的商品  
            Console.WriteLine("你選擇了功能 12");
        }
        public static void Function13(List<string> tittleName, List<Order> orders) 
        {
            // 13. 找出各商品類別底下，最便宜的商品  
            Console.WriteLine("你選擇了功能 13");
        }
        public static void Function14(List<string> tittleName, List<Order> orders) 
        {
            // 14. 列出所有商品（1頁4筆，共5頁，換頁的方式自己想）
            Console.WriteLine("你選擇了功能 14");
        }
       

    }
}
