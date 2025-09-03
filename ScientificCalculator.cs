using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrac
{
    public class ScientificCalculator : Calculator
    {
        //Methods for scientific operations: sine, cosine, tangent, logarithm, square root
        public double Sine(double x) => Math.Sin(x);

        public double Cosine(double x) => Math.Cos(x);

        public double Tangent(double x) => Math.Tan(x);

        public double Logarithm(double x)
        {
            if (x <= 0)
            {
                throw new ArgumentOutOfRangeException("Input must be greater than zero.");
            }
            return Math.Log(x);
        }

        public double SquareRoot(double x)
        {
            if (x < 0)
            {
                throw new ArgumentOutOfRangeException("Input must be non-negative.");
            }
            return Math.Sqrt(x);
        }

        //Override the Display method to customize output for scientific calculations
        public override void Display(double result)
        {
            //base.Display(result);// base refers to the parent class (Calculator)
            Console.WriteLine($"[Scientific Calculator] Result: {result}");
        }
    }
}
