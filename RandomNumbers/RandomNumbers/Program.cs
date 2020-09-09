using System;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            int i = 0;
            while (i < array.Length)
            {
                int random = new Random().Next(1, 50);
                if (!AlreadyUsed(i, random, array))
                {
                    array[i] = random;
                    i++;
                }
            }
            DisplayArray(array);
        }

        static bool AlreadyUsed(int i, int random, int[] array)
        {
            for (int j = 0; j < i; j++)
            {
                if (array[j] == random)
                {
                    return true;
                }
            }
            return false;
        }

        static void DisplayArray(int[] array)
        {
            Console.Write($"Le tirage au loto est le suivant : ");
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
