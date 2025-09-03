using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrac.Scientific
{
    public class Tangent : Operation
    {
        public override double Execute(double a, double b) => Math.Tan(a);
    }
}