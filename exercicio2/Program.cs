/*Escreva um algoritmo que leia três valores inteiros e diferentes e
mostre-os em ordem decrescente.
*/


using System;

namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escreva o primeiro valor: ");

            int valor_a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("escreva o segundo valor: ");

            int valor_b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("escreva o terceiro valor: ");

            int valor_c = Convert.ToInt32(Console.ReadLine());

            int Maior_numero = 0;

            int segundo_numero = 0;

            int menor_numero = 0;

            if (valor_a > valor_b && valor_a > valor_c)
            {
                Maior_numero = valor_a;
            }

            else if (valor_b > valor_a && valor_b > valor_c)
            {
                Maior_numero = valor_b;
            }

            else if(valor_c > valor_b && valor_c > valor_a)
            {
                Maior_numero = valor_c;
            }

            if (valor_a > valor_b && valor_a < valor_c || valor_a < valor_b && valor_a > valor_c)
            {
                segundo_numero = valor_a;
            }


            else if (valor_b < valor_a && valor_b > valor_c || valor_b > valor_a && valor_b < valor_c)
            {
                segundo_numero = valor_b;
            }


            else if (valor_c < valor_a && valor_c > valor_b || valor_c > valor_a && valor_c<valor_b)
            {
                segundo_numero = valor_c;
            }


            else if (valor_a < valor_b && valor_a < valor_c)
            {
                menor_numero = valor_a;
            }

            if (valor_b < valor_a && valor_b < valor_c)
            {
                menor_numero = valor_b;
            }

            else if (valor_c < valor_a && valor_c < valor_b)
            {
                menor_numero = valor_c;
            }

            Console.WriteLine($"{Maior_numero}, {segundo_numero}, {menor_numero}");
        }
    }
}
