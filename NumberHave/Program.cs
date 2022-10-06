using System;

namespace NumberHave
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] numeros;

            Console.Write("Enter numbers separeted by space, where a number n appear n times: ");
            numeros = Console.ReadLine().Split(" ");

            int tam = numeros.Length;
            if ( tam == 1)
            {               
                tam = 2;
                Array.Resize(ref numeros, tam); // because the output is in inteiros[1]
                numeros[1] = "0";
            }
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
