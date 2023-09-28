using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sasdjfevgr
{
    public class pessoa
    {
        public string nome;

        public pessoa(string nome)
        {
            this.nome = nome;
        }

        public int idade;
        public double altura;
        public double peso;

        public void envelhecer()
        {
            if (idade<21)
            {
                altura = 0.5;
            }
            else
            {
                Console.WriteLine("passou da idade irmão, proxima vida coma mais feijão!");

            }
        }
        public void engordar()
        {
            Console.WriteLine("chegando na thais Carla");
        }

        public void emagrecer()
        {
            Console.WriteLine("como meu pai diria, se passar um vento forte tu voa! ");

        }
    }
}
