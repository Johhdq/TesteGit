using System;

namespace TesteGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Bem-vindo ao projeto de teste do Git!!");
            Console.WriteLine("Bom dia!!!");

            Console.WriteLine("TABUADA!");
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



        }
    }
}
