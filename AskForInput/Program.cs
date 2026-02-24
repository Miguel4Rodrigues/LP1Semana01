using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro: ");
            int numeroInteiro = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um número real: ");
            float numeroReal = float.Parse(Console.ReadLine());
        }
    }
}
