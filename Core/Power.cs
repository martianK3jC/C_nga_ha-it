using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrac
{
    public class Power : Operation
    {
        public override double Execute(double a, double b) => Math.Pow(a, b);
    }
}
