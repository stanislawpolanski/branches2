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
            //this is master branch
            Apple a = new Apple();
            a.color = "red";

            Console.WriteLine(a.color);

            Tree t = new Tree();
            t.Color = "brown";

            Console.WriteLine(t.Color);
            Console.ReadKey();
        }
    }
}
