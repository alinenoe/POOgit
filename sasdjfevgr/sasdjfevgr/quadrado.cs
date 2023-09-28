using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sasdjfevgr
{
    public class quadrado
    {
        public double tamanhodoslado;

        public quadrado(double tamanhodoslados)
        {
            this.tamanhodoslado = tamanhodoslados;
        }
        public void ValordosLados(double tamanhodoslados)
        {
            tamanhodoslado = tamanhodoslados;
        }
        public double Calcular()
        {
            return tamanhodoslado * 4;
        }
        public double CalcularL()
        {
            return tamanhodoslado * tamanhodoslado;
        }
    }
}
