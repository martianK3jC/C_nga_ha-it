using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrac //namespace FolderName or SolutionName
{
    public class Calculator
    {
        //Methods fpr basic operation: add, subtract, multiply, divide... use double to accomodate decimals
        public double Add(double a, double b) => a + b;

        public double Subtract(double a, double b) => a - b;

        public double Multiply(double a, double b) => a * b;

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }

        public double Modulus(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot perform modulus by zero.");
            }
            return a % b;
        }

        public double Power(double a, double b) => Math.Pow(a, b);

        //virtual means this method can be overridden in derived classes
        //derived classes are classes that inherit from this class
        public virtual void Display(double result)
        {
            Console.WriteLine($"Result: {result}");
        }
    }
}



