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
            int[] f = new int[n+1];
            f[0] = 0;

            if (n == 0) return f;
            f[1] = 1;

            if (n == 1) return f;
            int i = 1;


            while (f[i] <= n)
            {

                i++;
                f[i] = f[i - 1] + f[i - 2];

            }

            return f;

        }

    }
}

