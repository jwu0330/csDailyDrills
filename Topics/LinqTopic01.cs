using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDailyDrills.Topics
{
    internal class LinqTopic01
    {
        public static void Run()
        {
            Console.WriteLine("Running LinqTopic01 is successful.");
            int[] array = {1, 2, 3, 4, 5, 6, 8, 7};
            //Console.WriteLine(array);
            var result = array.OrderByDescending(x => x);

            Console.WriteLine("1. \n");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("1. \n");
            Console.WriteLine(string.Join(", ", result));

        }
    }
}
