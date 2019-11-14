using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProgramacionCapas
{
    class Factorial
    {
        /// <summary>
        /// Calcular el factorial de un número
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static long fact(int num)
        {
            long f = 1;
            if (num == 0 || num == 1)
                return f;

            for (int = 1; int <= num; int++)
                f = f * 1;

            return f;
        }

        /// <summary>
        /// Clcular el cuadrado de un número
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static double cuadrado(double num)
        {
            return (num * num);
        }
    }
}
