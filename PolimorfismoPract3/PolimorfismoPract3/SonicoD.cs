using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoPract3
{
      class SonicoD:Sensores
    {
        public SonicoD()
        {
            this.Distancia = 0;
        }
        public SonicoD(int d)
        {
            this.Distancia = d;
        }

        public override string Avanzar()
        {
            if (100 < this.Distancia)
            {
                return "Estoy avanzando hacia adelante\n";
            }
            else
            {
                return Detenerse();
            }
           
        }
        public override string Detenerse()
        {
            return "Me detuve \n";
        }
    }
}
