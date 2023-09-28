using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    public class Program
    {
        public string nome;
        public double saldo;
        public string num;
        public double limite;
        public Agencia agencia;
        public void depositar(double valor)

        {
            saldo += valor;
        }
        public void sacar (double valor)
        {
            saldo -= valor;
}
        public double consultarsaldo()
        {
            return saldo + limite;
        }
        public void ImprimeExtrato()
        {
            DateTime dt = DateTime.Now;
            string data = dt.ToShortDateString();
            string hora = dt.ToShortTimeString();
            Console.WriteLine("\t\t----Extrato detalhado----");
            Console.WriteLine("\nData: "+ data);
            Console.WriteLine("\nHora: " + hora);
            Console.WriteLine($"\nSaldo:  { saldo: c2}");
            Console.WriteLine($"\nlimite:  {limite: c2}");



        }
    }
}
