using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herancaa
{
  public class Animal
    {
        private string nme;

        public string Nome { get { return Nome; } set { Nome = value; } }
        public void acordar()
        {
            Console.WriteLine("acordando");
        }
        public void comer()
        {
            Console.WriteLine("comendo");
        }
        public void dormir()
        {
            Console.WriteLine("dormindo");       
        }

        public override string ToString()
        {
            return "nome: " + Nome;
        }
    }
}
