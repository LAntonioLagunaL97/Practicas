using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascota
{
    class Perro
    {
        public string Tamaño;
        public string Raza;
        public string Sexo;
        public int Peso;
        private string color;

        public string Color { get => color; set => color = value; }

        public enum TIPOSDECOMIDA {CROQUETAS,BASURA,AGUA};

        public Perro()
        {
            Raza = "PUG";
            Peso = 25;
            Sexo = "Macho";
            Tamaño = "Mediana";
        }

        public Perro(string raza, int peso, string sexo, string tamaño)
        {
            Raza = raza;
            Peso = peso;
            Sexo = sexo;
            Tamaño = tamaño;
        }

        public void Ladrar()
        {

        }
        public void Correr()
        {

        }
        public bool Comer(int alimento)
        {
            bool res = false;
            if (alimento == (int)TIPOSDECOMIDA.AGUA)
            {
                res= true;
            }
            else if (alimento == (int)TIPOSDECOMIDA.BASURA)
            {
                res= true;
            }
            else if (alimento == (int)TIPOSDECOMIDA.CROQUETAS)
            {

                res= true;
            }
            return res;


        }
        public void Cagar()
        {

        }
    }
}
