using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascota
{
    class Program
    {
        enum TIPOSDECOMIDA { CROQUETAS, BASURA, AGUA };
        static void Main(string[] args)
        {
            bool alimentado = false;


            Perro Perro1 = new Perro();
            Perro1.Raza = "Boxer";
            Perro1.Peso = 25;
            Perro1.Sexo = "Macho";
            Perro1.Tamaño = "Mediana";


            alimentado = Perro1.Comer((int)TIPOSDECOMIDA.CROQUETAS);

            if (alimentado)
            {
                Console.WriteLine("El Perro " + Perro1.Raza + " Comió " + Convert.ToString(TIPOSDECOMIDA.AGUA));
            }

            Perro Perro2 = new Perro();
            Console.WriteLine("El Perro " + Perro2.Raza + " Comió " + Convert.ToString(TIPOSDECOMIDA.CROQUETAS));

            Perro Perro3 = new Perro("PITBULL", 20, "Hembra", "mediano");
            Console.WriteLine("El Perro " + Perro1.Raza + " Comió " + Convert.ToString(TIPOSDECOMIDA.BASURA));
           // Perro Perro3 = new Perro();
            Perro3.Color = "blanco";
            string colorr = Perro3.Color;

            Console.ReadKey();
        }
    }

}
