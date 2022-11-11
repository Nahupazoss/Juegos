using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    public class Auto
    {
        private int velocidad;
        private int puntosVida;

        public Auto(Point posicionInicial,int velocidad,int puntosVida)
        {
            this.velocidad = velocidad;
            this.puntosVida = puntosVida;
        }
        public int Velocidad
        {
            get
            {
                return this.velocidad;
            }
        }
        public int PuntosDeVida
        {
            get
            {
                return this.puntosVida;
            }
        }
        public bool TienePuntosDeVida
        {
            get
            {
                return this.puntosVida > 0;
            }
        }
        public virtual void RecibeStop(int valor)
        {
            this.puntosVida -= valor;
            this.velocidad = 0;
        }
        public virtual void RecibeRayo()
        {
            this.velocidad += 1;
        }

    }
}
