using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulamento
{
    public class Conta
    {
        public string Numero { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }

        public void calcularLimite(double Saldo)
        {
            Limite = Saldo * 0.1;

            Console.WriteLine(Limite);

        }
    }
}
