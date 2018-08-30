using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoPract3
{
    abstract class Sensores
    {
        protected int Distancia;

        public abstract string Avanzar();

        public abstract string Detenerse();

        public virtual string Alarma()
        {
            return "Alarma Activada";
        }
    }
}
