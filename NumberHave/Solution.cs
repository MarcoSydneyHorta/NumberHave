using System;
using System.Collections.Generic;
using System.Text;

namespace NumberHave
{
    class Solution
    {
        static public void CountElements(int[] arr)
        {
            // to be returned in arr[1] as requested by the problem

            int tam = arr.Length;
            int soma = 0;
            int total = -1;


            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        soma++;
                    }
                }
                if (soma == arr[i])
                {
                    total = soma;
                    break;
                }
                soma = 0;
            }
            arr[1] = total;
        }
    }
}
