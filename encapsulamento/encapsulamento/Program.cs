using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Funcionario funcionario = new Funcionario();
            funcionario.Nome = "Pedro Noemerg de Andrade";
            funcionario.Salario = 100000;
            Console.WriteLine(funcionario.Nome);
            Console.WriteLine(funcionario.Salario);

            Conta funcConta = new Conta();
            funcConta.Numero = "00000-1";
            funcConta.Saldo = 5000;
            funcConta.calcularLimite(funcConta.Saldo);

            Console.WriteLine(funcConta.Limite);
            Console.WriteLine(funcConta.Saldo);
            Console.WriteLine(funcConta.Limite);



        }
    }
}
