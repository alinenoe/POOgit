using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herancaa
{
    public class Mamiferos : Animal //herança
    {
        public int idade;
        public void Mamar()
        {
            Console.WriteLine("Mamiferos mamam...");
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
