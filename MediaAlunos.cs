using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNotaAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            //Console.ReadLine();
            Console.WriteLine("##################################################################");
            Console.WriteLine("                    Média de nota dos Alunos");
            Console.WriteLine("##################################################################");
            
            float soma = 0;
            float media = 0;
            string nome;

            Console.WriteLine("Digite seu nome para iniciar o sistema: ");
            nome = Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("##################################################################");
                Console.WriteLine("                    Média de nota dos Alunos");
                Console.WriteLine("##################################################################");
                Console.WriteLine(nome + ", digite a nota do aluno " + i + ":");
                float nota = 0;
                float.TryParse(Console.ReadLine(), out nota);
                soma += nota;
                Console.Clear();
            }

            media = soma / 5;
            Console.WriteLine("##################################################################");
            Console.WriteLine("                    Média de nota dos Alunos");
            Console.WriteLine("##################################################################");
            Console.WriteLine("A média das notas dos Alunos é: " + media);
        }
    }
}
