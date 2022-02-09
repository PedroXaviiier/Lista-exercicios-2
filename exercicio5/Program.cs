/*Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem
iguais deverá se somar os dois, caso contrário multiplique A por B.
Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma
variável C e mostrar seu conteúdo na tela.
*/



using System;

namespace exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o valor A: ");

            int Valor_A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escreva o valor B: ");

            int Valor_B = Convert.ToInt32(Console.ReadLine());

            int Valor_C = 0;

            if (Valor_A == Valor_B)
            {
                Valor_C = Valor_A + Valor_B;
            } 

            else
            {
                Valor_C = Valor_A * Valor_B;
            }

            Console.WriteLine($"{Valor_C}");


        }
    }
}
