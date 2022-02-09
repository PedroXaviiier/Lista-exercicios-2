/*• O IMC – Índice de Massa Corporal é um critério da Organização Mundial
de Saúde para dar uma indicação sobre a condição de peso de uma pessoa
adulta
• A fórmula é IMC = peso / (altura) ²
• Elabore um algoritmo que leia o peso e a altura de um adulto e mostre
sua condição de acordo com a tabela abaixo.
IMC em adultos Condição
Abaixo de 18,5 Abaixo do peso
Entre 18,5 e 25 Peso normal
Entre 25 e 30 Acima do peso
Acima de 30 obeso
*/

using System;

namespace exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu peso: ");

            double Peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");

            double Altura = Convert.ToDouble(Console.ReadLine());

            double IMC = Peso / Math.Pow(Altura, 2);

            if (IMC < 18.5)
                Console.WriteLine("abaixo do peso");
            

            else if (IMC > 18.5 && IMC <= 25)
                Console.WriteLine("Peso normal");
           

            else if (IMC > 25 && IMC <= 30)
                Console.WriteLine("Acima do peso");
            

            else if (IMC > 30)
                Console.WriteLine("Obeso");

            Console.ReadKey();
        }
    }
}
