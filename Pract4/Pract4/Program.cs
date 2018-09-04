using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract4
{
    class Program
    {
        static void Main(string[] args)
        {
            SobreCarga p1 = new SobreCarga("Julion");
            Console.WriteLine(p1.nombrar());
            Console.WriteLine(p1.nombrar("Alvarez"));
            Console.WriteLine(p1.nombrar(40));

            int[] n = { 7, 8, 9, 6, 1, 5 };
            int[] m = { 6, 4, 2, 8};


            Matriz a = new Matriz(n,m);
            Matriz b = new Matriz(n,m);
            Matriz c = a + b;

            c.print(c);
            Console.ReadKey();
        }
    }
}
