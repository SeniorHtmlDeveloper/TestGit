using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        public delegate bool FilterState(int item);

        static void Main(string[] args)
        {
            var l = new List<int>() { 1, 2, 3, 4, 5 };
            var el = Filter((item) => item % 2 == 0, l);
            var ol = Filter((item) => item % 2 != 0, l);

            foreach(var item in el)
                Console.WriteLine(item);

            Console.WriteLine();

            foreach(var item in ol)
                Console.WriteLine(item);

            Console.ReadKey();
        }

        
        
        public static List<int> Filter(FilterState state, List<int> list)
        {
            var newList = new List<int>();
            foreach(var item in list)
            {
                if (state(item))
                {
                    newList.Add(item);
                }
            }
            return newList;
        }

    }
}
