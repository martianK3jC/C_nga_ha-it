using CSharpPrac.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrac
{
    public abstract class Operation : IOperation
    {
        public abstract double Execute(double a, double b);

        //virtual means this method can be overridden in derived classes
        //can virtual be optionally overridden? Yes, but abstract must be overridden. because abstract has no implementation, while virtual has a default implementation.
        public virtual void Display(double result)
        {
            Console.WriteLine($"Result: {result}");
        }

        
    }
}
