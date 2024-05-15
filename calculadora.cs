using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class calculadora
    {
        public int Somar(int n1, int n2)
        {
            return n1 + n2;
        }

        public int Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }

        public int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }

        public int Dividir(int n1, int n2)
        {
            if (n2 != 0)
            {
                return n1 / n2;
            }
            else
            {
                throw new ArgumentException("Divisor não pode ser zero.");
            }
        }
    }
}
