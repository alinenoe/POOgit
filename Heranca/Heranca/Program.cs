using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gerente gere = new Gerente();
            Secretaria secre = new Secretaria();
            Telefonista tele = new Telefonista();
            gere.Salario = 5000;
            tele.Salario = 1800;
            secre.Salario = 2400;
        }
    }
}
