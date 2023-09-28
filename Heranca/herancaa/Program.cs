using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herancaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal ani = new Animal();
            ani.Nome = "Rex";
            Console.WriteLine(ani);
            ani.acordar();
            ani.comer();
            ani.dormir();
            Console.WriteLine("\n----------------------\n");
            Mamiferos mam = new Mamiferos();
            mam.Nome = "thor";
            mam.idade = 54;
            Console.WriteLine(mam); ;
            mam.acordar();
            mam.comer();
            mam.dormir();

            Console.ReadKey();
        }
    }
}
