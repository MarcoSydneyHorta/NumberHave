using System;
using System.Collections.Generic;
using System.Text;

namespace NumberHave
{
    class Solution
    {
        static public void CountElements (int[] arr)
        {
            // to be returned in arr[1] as requested by the problem

            int tam = arr.Length;
            int soma;
            int total = 0;

            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam; j++)
                {
                    soma = arr[i] + arr[j];
                    if (j < tam - 1)
                    {
                        if (soma == arr[j + 1])
                        {
                            total++;
                        }
                    }
                }
            }
            arr[1] = total;
        } 
    }
}
