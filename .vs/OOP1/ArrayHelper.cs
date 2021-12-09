using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class ArrayHelper
    {
        public static int[] Fibonacci(int n)

        {
            int[] f = new int[n];
            f[0] = 0;

            if (n == 0) return f;
            f[1] = 1;

            if (n == 1) return f;
            int i = 1;


            while (i < n-1)
            {

                i++;
                f[i] = f[i - 1] + f[i - 2];

            }

            return f;

        }

        public static int Frecventa(int[] vector, int element)
        {
            int frecventa = 0;
            for (int i =0; i <= vector.Length; i++)
            {
                if (vector[i] == element) frecventa++;

            }

            return frecventa;
        }

        public static bool Identitate(int[,] matr)
        {
            bool identitate = true;

            for (int lin = 0; lin < matr.GetLength(0); lin++)
            {
                for (int col = 0; col < matr.GetLength(1); col++)
                {

                    if (lin != col)
                    {
                        if (matr[lin, col] != 0)
                        {
                            identitate = false;
                        }
                    }
                    else if (matr[lin, col] != 1)
                    {
                        identitate = false;
                    }
                }
            }
            if (identitate == true)
                return true;
            else
                return false;
        }
    }
}

