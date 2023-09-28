using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Endereco ed1 = new Endereco();
            Cartao cdc1 = new Cartao();
            Cliente cli = new Cliente();
            Cliente cli2 = new Cliente();
            ed1.endereco = "Jardim América";

            cdc1.cliente = cli;

            cdc1.cliente.nome = "Rafael";

            Conta con1 = new Conta();
            Agencia agen = new Agencia();

            con1.agencia = agen;
            con1.agencia.numero = "9829-0";

            cli2.endereco = ed1;


            Conta cc1 = new Conta();
            cc1.saldo = 50;
            cc1.limite = 100;
            Console.WriteLine($"Nome do cliente: {cdc1.cliente.nome} ");
            Console.WriteLine($"Numero da conta: {con1.agencia.numero} ");
            Console.WriteLine($"Endereço: {cli2.endereco.endereco} ");

            Console.ReadKey();
        }
    }
}
