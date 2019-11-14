using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProgramacionCapas
{
    class Factorial
    {
        public static long fact (int num)
        {
            long f = 1;
            if (num == 0 || num == 1)
                return f;

            for (int = 1; int <= num; int++)
                f = f * 1;

            return f;
        }
    }
}
