using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        namespace CalcularArea
    {
        internal class Program
        {
            static void Main(string[] args)
            {


                while (true)
                {

                    Console.WriteLine("Digite a altura do retângulo: ");
                    double altura = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a largura do retângulo: ");
                    double largura = double.Parse(Console.ReadLine());

                    if (altura <= 0 || largura <= 0)
                    {
                        Console.WriteLine("Os valores da altura e largura devem ser maiores que zero.");
                    }
                    else
                    {
                        Retangulo retangulo = new Retangulo(altura, largura);


                        Console.WriteLine($"A área do retângulo é: {retangulo.CalcularArea()}");

                        Console.WriteLine("Deseja realizar outra operação? (S/N)");
                        string resposta = Console.ReadLine();
                        if (resposta.ToLower() != "s")
                            break;
                    }

                }
            }
        }
    }

