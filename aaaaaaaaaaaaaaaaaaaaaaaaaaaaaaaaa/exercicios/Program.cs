using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Aluno aluno2 = new Aluno();

           funcionario funcionario = new funcionario();
            funcionario funcionario2 = new funcionario();

            turma turma = new turma();
            turma turma2 = new turma();


            Console.WriteLine("\t\t---Imprimindo os dados dos Alunos---\n");
            Console.WriteLine("\t---Aluno 1:---\n");
            Console.Write($"Nome: ");
            aluno.Nome = Console.ReadLine();
            Console.Write($"RG: ");
            aluno.Rg = Console.ReadLine();
            Console.Write($"Data de Nascimento: ");
            aluno.DataDeNascimento = Console.ReadLine();

            Console.WriteLine("\t---Aluno 2:---\n");
            Console.Write($"Nome: ");
            aluno2.Nome = Console.ReadLine();
            Console.Write($"RG: ");
            aluno2.Rg = Console.ReadLine();
            Console.Write($"Data de Nascimento: ");
            aluno2.DataDeNascimento = Console.ReadLine();

            Console.WriteLine("\n\t\t---Imprimindo os dados dos Funcionários---\n");
            Console.WriteLine("\t---Funcionários 1:---\n");
            Console.Write($"Nome: ");
            funcionario.nome = Console.ReadLine();
            Console.Write($"Cargo: ");
            funcionario.cargo = Console.ReadLine();
            Console.Write($"Salário: ");
            funcionario.SalarioFuncionarios = double.Parse(Console.ReadLine());

            Console.WriteLine("\t---Funcionários 2:---\n");
            Console.Write($"Nome: ");
            funcionario2.nome = Console.ReadLine();
            Console.Write($"Cargo: ");
            funcionario2.cargo = Console.ReadLine();
            Console.Write($"Salário: ");
            funcionario2.SalarioFuncionarios = double.Parse(Console.ReadLine());

            Console.WriteLine("\n\t\t---Imprimindo os dados das Turmas---\n");
            Console.WriteLine("\t---Turma 1:---\n");
            Console.Write($"Série: ");
            turma.Serie = Console.ReadLine();
            Console.Write($"Período: ");
            turma.Periodo = Console.ReadLine();
            Console.Write($"Tipo de Ensino: ");
            turma.TipoDeEnsino = Console.ReadLine();

            Console.WriteLine("\t---Turma 2:---\n");
            Console.Write($"Série: ");
            turma2.Serie = Console.ReadLine();
            turma2.Serie = Console.ReadLine();
            Console.Write($"Período: ");
            turma2.Periodo = Console.ReadLine();
            Console.Write($"Tipo de Ensino: ");
            turma2.TipoDeEnsino = Console.ReadLine();
            Console.ReadKey();
        }
    }
}
