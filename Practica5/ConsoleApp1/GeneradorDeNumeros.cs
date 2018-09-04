using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GeneradorDeNumeros
    {
        int[] numeros = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

        public int GetNumero(int indice)
        {
            if (indice < 0 || indice >= numeros.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return numeros[indice];
        }
    }
}
