using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    public class Obstaculo
    {
        decimal aceleracion;
        int velocidad;


        public Obstaculo(decimal aceleracion, int velocidad)
        {
            this.aceleracion = aceleracion;
            this.velocidad = velocidad;
        }

    }
}
