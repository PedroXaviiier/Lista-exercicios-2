/*Faça um algoritmo que leia os valores A, B, C e imprima na tela se a
soma de A + B é menor que C.
*/



using System;


namespace Lista_exercicios_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escreva o valor A: ");

            double Valor_A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("escreva o valor B: ");

            double Valor_B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("escreva o valor C: ");

            double Valor_C = Convert.ToDouble(Console.ReadLine());

            double Soma = Valor_A + Valor_B;

            if (Soma > Valor_C)
                Console.WriteLine("A soma de A e B é maior que C");

            else Console.WriteLine("A soma de A e B é menor que C");
                    
        }
    }
}
