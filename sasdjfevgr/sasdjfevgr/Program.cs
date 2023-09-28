using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sasdjfevgr
{
    internal class Program
    {
        static void Main(string[] args)
        {
             double ladoA, ladoB, ladoq;
            string bolacor, novacor;
            Console.Write("informe a largura do triangulo: ");
            ladoA=double.Parse(Console.ReadLine());
            Console.Write("informe o comrpimento do triangulo: ");
            ladoB = double.Parse(Console.ReadLine());
            triangulo retan = new triangulo(ladoA, ladoB);

            Console.WriteLine($"quantidade de pisos: {retan.Calculararea()}");
            Console.WriteLine($"quantidade de rodapes: {retan.calcularperimetro()}");

            Console.WriteLine($"\n valor do lado do quadrado: ");
            ladoq = double.Parse(Console.ReadLine());
            quadrado lado = new quadrado (ladoq);
           Console.WriteLine($"valor do quadrado: {lado.Calcular()}\n area do quadrado: {lado.CalcularL()}");

            Console.WriteLine("Qual é a cor da bola: ");
            bolacor = Console.ReadLine();
            bola bola1 = new bola (bolacor);
            Console.WriteLine($"a cor da bola é: {bolacor}");

            Console.WriteLine("qual é a cor nova da bola? ");
            novacor = Console.ReadLine();
            bola1.alteraCor(novacor);
            Console.ReadKey(); 
              

            string nome;
            Console.WriteLine("qual é  nome da pessoa");
            nome = Console.ReadLine();
            pessoa Sydyney = new pessoa(nome);
            Sydyney.altura = 1.83;
            Sydyney.idade = 17;
            Sydyney.peso = 63;

            Console.WriteLine($"a pessoa se chama {Sydyney.nome}\nTem {Sydyney.idade} anos\ne pesa {Sydyney.peso}kl");
            Sydyney.engordar();
            Sydyney.envelhecer();
            Sydyney.emagrecer();
            
        
        }
    }
}
