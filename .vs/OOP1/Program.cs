using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numarul de valori:");
            int n;
            n = Int32.Parse(Console.ReadLine());
            
            int[] vector = (ArrayHelper.Fibonacci(n));

            for (int i = 0; i < vector.Length; i++)
                Console.WriteLine(vector[i] + " ");

            Console.WriteLine("Numarul de elemente din vector:");

            int nr = Int32.Parse(Console.ReadLine());
            int[] vector1 = new int[nr];

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"vector1[{i}]");
                vector1[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Valoarea cautata:");
            int element = Int32.Parse(Console.ReadLine());

            Console.WriteLine(ArrayHelper.Frecventa(vector1, element));


            Console.WriteLine("Numarul de linii din matrice: ");

            int N1 = Convert.ToInt32(Console.ReadLine());
            int[,] matr = new int[N1, N1];
            for (int lin = 0; lin < matr.GetLength(0); lin++)
            {
                for (int col = 0; col < matr.GetLength(1); col++)
                {
                    Console.Write($"[{lin},{col}]:");
                    matr[lin, col] = Convert.ToInt32(Console.ReadLine());

                }
            }
            if(ArrayHelper.Identitate(matr)==true)
                Console.WriteLine("Matrice identitate!");
            else
                Console.WriteLine("Nu este matrice identitate");
        }
    }
}
