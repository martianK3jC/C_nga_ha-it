using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrac.Operations
{
    public class Subtraction : Operation
    {
        public override double Execute(double a, double b) => a - b;
    }
}
