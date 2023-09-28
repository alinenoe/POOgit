using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    public class funcionario
    {
        public string nome;
        public double salario;

        public void Aumentarsalario(double taxa)
        {
            salario = salario + (salario * (taxa\100));
        }
        public void ImprimirDados()
         {
        Console.WriteLine("\t\t---dados do funcionario");
            Console.WriteLine($"Nome: (nome\n Salario {salario:c2}");
        }
    }
}S
