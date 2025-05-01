using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDailyDrills.Topics
{
    internal class LinqTopic02
    {
        public static void Run()
        {
            Console.WriteLine("\nRunning LinqTopic02 is successful.");
            string s = "8,7,9,3,11,6,2,18";
            int[] array = s.Split(',').Select(x => int.Parse(x)).ToArray();
            //int[] even = new int[array.Length], odd = new int[array.Length];
            var even = array.Where(n => n % 2 == 0).OrderBy(n => n);
            var odd = array.Where(n => n % 2 == 1).OrderBy(n => n);
            Console.WriteLine(string.Join(", ", even));
            Console.WriteLine(string.Join(", ", odd));















        }
    }
}
