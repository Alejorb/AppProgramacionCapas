using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProgramacionCapas
{
    public static class EcuaciónCuadrática
    {
        /// <summary>
        /// Calcula x1 de la ecuación cuadrática
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static double calcularx1(double a,double b,double c)
        {
            double x1 = 0, d = 0;
            d = (b * b) - (4 * a * c);

            /*if(a==0)
            {
                 MessageBox.Show("error al dividir para cero...");
            }
            if (d < 0)
            {
                MessageBox.Show("error, la ecuación tiene soluciones imaginarias"):
                return 0;
            }*/
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            return x1;
        }

        public static double calcularx2(double a, double b, double c)
        {
            double x2 = 0, d = 0;
            d = (b * b) - (4 * a * c);

            /*if(a==0)
            {
                 MessageBox.Show("error al dividir para cero...");
            }
            if (d < 0)
            {
                MessageBox.Show("error, la ecuación tiene soluciones imaginarias");
                return 0;
            }*/
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            return x2;
        }

    }
}
