using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrac.Operations
{
    public class Addition : Operation
    {
        public override double Execute(double a, double b) => a + b;

        //If i use the Addition class from another class, I can still call the Display method even without overriding it here, because it's inherited from the Operation class.
    }
}
