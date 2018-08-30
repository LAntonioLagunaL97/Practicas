using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoPract3
{
     class SonicoR:Sensores
    {
        public SonicoR()
        {
            this.Distancia = 0;
        }
        public SonicoR(int d)
        {
            this.Distancia = d;
        }

        public override string Avanzar()
        {
            if (this.Distancia > 50)
            {

                return "Estoy avanzando de reversa\n";
            }
            else
            {
                return Detenerse();

            }


        }
        public override string Detenerse()
        {
            return "Me detuve \n"+ this.Alarma()+"\n";
        }
    }
}
