using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sasdjfevgr
{
    public class triangulo
    {
        public double ladoAa;
        public double ladoBb;

        public triangulo(double ladoA, double ladoB)
        {
            this.ladoAa = ladoA;
            this.ladoBb = ladoB;
        }
        public void Mudarvalor(double ladoA, double ladoB)
        {
            ladoAa = ladoA;
            ladoBb = ladoB;
        }
        public double Calculararea()
        {
            return ladoAa * ladoBb;
        }
        public double calcularperimetro()
        {
            return 2 * (ladoAa + ladoBb);
        }
    }
}
