using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace Negativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;

            Console.Write("Digite um número: ");
            valor = int.Parse(Console.ReadLine());

            if (valor <= 0)
            {
                Console.WriteLine("Você digitou um número negativo!");
            }

            Console.Write("\n");
            Console.WriteLine("Pressione ENTER para sair!");
            Console.ReadKey();
        }
    }
}
