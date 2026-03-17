using System;
using System.Collections.Generic;

public class DisplaySums
{
    public static void DisplaySumPairs(List<int> numbers)
    {
        HashSet<int> seen = new HashSet<int>();

        foreach (int num in numbers)
        {
            int complement = 10 - num;

            // Si ya vimos el complemento, mostramos el par
            if (seen.Contains(complement))
            {
                Console.WriteLine($"{num} + {complement} = 10");
            }

            // Agregamos el número al set
            seen.Add(num);
        }
    }
}