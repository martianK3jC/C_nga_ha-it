using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrac
{
    public class Logarithm : Operation
    {
        public override double Execute(double a, double b)
        {
            if (a <= 0 || b <= 0 || b == 1)
            {
                throw new ArgumentOutOfRangeException("Both base and argument must be greater than zero, and base cannot be 1.");
            }
            return Math.Log(b, a); // Logarithm of b with base a
        }
    }
}
