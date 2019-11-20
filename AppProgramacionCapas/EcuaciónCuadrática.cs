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
        public static double x1 (double a, double b, double c,out string msg)
        {
            double x1 = 0;
            msg = "";
            if (a==0)
            {
                msg = "Error, division para cero... ";
                return 0;
            }
            double d= (b * b) - (4 * a * c);
            if (d<0)
            {
                msg = "Raices negativas. La ecuación tiene soluciones imaginarias...";
                return 0;
            }
            x1= (-b + Math.Sqrt(d)) / (2 * a);
            return x1;
        }

        public static double x2(double a, double b, double c, out string msg)
        {
            double x2 = 0;
            msg = "";
            if (a == 0)
            {
                msg = "Error, division para cero... ";
                return 0;
            }
            double d = (b * b) - (4 * a * c);
            if (d < 0)
            {
                msg = "Raices negativas. La ecuación tiene soluciones imaginarias...";
                return 0;
            }
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            return x2;
        }

        public static double getx1(double a, double b, double c)
        {
            double x1 = 0;
           
            if (a == 0)
                throw new Exception("Error, division para cero... ");
                          
            double d = (b * b) - (4 * a * c);
            if (d < 0)
                throw new Exception("Raices negativas. La ecuación tiene soluciones imaginarias...");

            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            return x1;
        }

    }
}
