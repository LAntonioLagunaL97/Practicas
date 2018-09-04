using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract4
{
    class SobreCarga

    {   string name;
        public SobreCarga(string n)
        {
            name = n;
        }
        public string nombrar()
        {
            return "Mi nombre es " + this.name;
        }
        public string nombrar(string apellido)
        {
            return "Mi nombre es " + name + " " + apellido;
        }
        public string nombrar( int edad)
        {
            return "Mi nombre es " + name + " y tengo "+ edad +" años" ;
        }

    }
}
