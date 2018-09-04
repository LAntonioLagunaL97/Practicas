using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1 = 3000;
            int number2 = 0;
            try
            {
                Console.WriteLine(number1 / number2);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division of {0} by zero.", number1);
            }


            GeneradorDeNumeros Gnum = new GeneradorDeNumeros();

            Console.WriteLine(Convert.ToString(Gnum.GetNumero(10)));
            Console.ReadKey();
        }
    }
}
