/*• Faça um algoritmo para receber um número qualquer e informar na tela se
é par ou ímpar.
*/


using System;

namespace exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o seu numero: ");

            double numero = Convert.ToDouble(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("O numero é par");
            else 
                Console.WriteLine("o numero é impar");
        }
    }
}
