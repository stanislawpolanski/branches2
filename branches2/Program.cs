using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branches2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Apple a = new Apple();
            a.color = "red";

            Console.WriteLine(a.color);
            Console.ReadKey();
        }
    }
}
