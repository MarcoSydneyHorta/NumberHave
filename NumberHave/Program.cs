using System;

namespace NumberHave
{
    class Program
    {
        static void Main(string[] args)
        {
            string dados;
            string[] numeros;


            Console.Write("Enter number separeted by space: ");
            dados = Console.ReadLine();

            numeros = dados.Split(" ");
            int tam = numeros.Length;
            int[] inteiros = new int[tam];

            for (int i = 0; i< tam; i++)
            {
                inteiros[i] = int.Parse(numeros[i]);
            }
            Solution.CountElements(inteiros);
            Console.WriteLine("Output = " + inteiros[1]);
            Console.Read();
        }
    }
}
