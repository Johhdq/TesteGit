using System;

namespace TesteGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao projeto de teste do Git!!");

            Console.Write("\nQual o seu nome? ");

            string nome = Console.ReadLine();
            Console.WriteLine($"Bom dia {nome}!!!");

            Console.WriteLine("\nTABUADA!");
            Console.Write("\nTabuada do? ");

            int tabuada = int.Parse(Console.ReadLine());
            
            if (tabuada >= 1 && tabuada <= 10)
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{tabuada} x {i} = {tabuada * i}");
                }
            }
            else
            {
                throw new ArgumentException("Error: Tabuada inválida!");
            }
            Console.Write("\nComo você esta? ");
            string resposta = Console.ReadLine();

            Console.WriteLine($"Você está {resposta}");
            Console.WriteLine("Obrigado pela sua resposta!");
        }
    }
}
