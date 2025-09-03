using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpPrac.Core;
using CSharpPrac.Operations;
using CSharpPrac.Scientific;

namespace CSharpPrac.App
{
    public class CalculatorApp
    {
        private static double num1 = 0, num2 = 0;

        static double getNum1() => num1;

        static double getNum2() => num2;

        static void setNum1(double value) => num1 = value;

        static void setNum2(double value) => num2 = value;

        static void Main()
        {

            //Refined version: Naa nay Dictionary for operations
            //lazy creation of objects using Func<T>
            //Dictionary syntax: Dictionary<keyType, valueType> dictName = new Dictionary<keyType, valueType>();
            #region Select Operation
            Dictionary<string, Func<IOperation>> operations = new Dictionary<string, Func<IOperation>>
            {
                //Using the Func<T>, the values must be lambdas. WHy? because its a function delegate
                //{Tkey, () => new Tvalue()}
                { "+", () => new Addition() },
                { "-", () => new Subtraction() },
                { "*", () => new Multiplication() },
                { "/", () => new Division() },
                { "^", () => new Power() },
                { "%", () => new Modulus() },
                { "s", () => new Sine() },
                { "c", () => new Cosine() },
                { "t", () => new Tangent() },
                { "l", () => new Logarithm() },
                { "sqrt", () => new SquareRoot() }
            };
            #endregion
            //the usage of this would be: 
            //IOperation op = operations[operation](); // note the ()
            //double result = op.Execute(num1, num2);

            while (true)
            {
                #region Input Validation for Numbers
                while (true)
                {
                    Console.Write("Enter a number: ");
                    string input = Console.ReadLine();

                    //if input is not a number, throw exception and ask for input again
                    //Solution: via if else
                    if (!double.TryParse(input, out double number))//this means if input cannot be parsed to a double, then number will be 0
                    {
                        Console.WriteLine("Invalid input! Please enter a number.");
                        continue;
                    }

                    ////Solution: via exception handling
                    //try
                    //{
                    setNum1(Convert.ToDouble(input));
                    break;
                    //} catch(FormatException e)
                    //{
                    //    Console.WriteLine("Invalid input! Please enter a number.");
                    //}
                }


                //Determine if second number is needed
                Console.WriteLine("Select operation (+, -, *, /, ^, %, s, c, t, l, sqrt):");
                string operation = Console.ReadLine();

                if (operation.Equals("+") || operation.Equals("-") || operation.Equals("*") || operation.Equals("/") || operation.Equals("^") || operation.Equals("%"))
                {
                    while (true)
                    {
                        Console.Write("Enter 2nd number: ");
                        string input2 = Console.ReadLine();
                        try
                        {
                            setNum2(Convert.ToDouble(input2));
                            break;
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Invalid input! Please enter a number.");
                        }
                    }
                }
                #endregion

                #region Perform Operations
                //to know if operation exists in Dictionary:
                if (operations.ContainsKey(operation))
                {
                    Operation op = (Operation)operations[operation](); //Casting to operation becausee operations[operation]() is an IOperation object. we cast it aron maka gamit ta sa Display method ni Operation class
                    double result = op.Execute(num1, num2);
                    op.Display(result);
                }
                #endregion

                Console.WriteLine("Do you want to continue? (y/n)");
                if (Console.ReadLine().ToLower() != "y")
                {
                    break;
                }

            }





            #region Some Notes
            /*
            //Calculator calc = new Calculator();
            //ScientificCalculator calc = new ScientificCalculator();

            //a much more optimized version. ONE object, has base + scientific methods
            ScientificCalculator calc = new ScientificCalculator();






                //Perform operation
                try
                {
                    double result = 0;

                    switch (operation)
                    {
                        case "+": result = calc.Add(getNum1(), getNum2()); break;
                        case "-": result = calc.Subtract(getNum1(), getNum2()); break;
                        case "*": result = calc.Multiply(getNum1(), getNum2()); break;
                        case "/": result = calc.Divide(getNum1(), getNum2()); break;
                        case "^": result = calc.Power(getNum1(), getNum2()); break;
                        case "%": result = calc.Modulus(getNum1(), getNum2()); break;
                        case "s": result = calc.Sine(getNum1()); break;
                        case "c": result = calc.Cosine(getNum1()); break;
                        case "t": result = calc.Tangent(getNum1()); break;
                        case "l": result = calc.Logarithm(getNum1()); break;
                        case "sqrt": result = calc.SquareRoot(getNum1()); break;
                        default: 
                            Console.WriteLine("Invalid operation selected.");
                            return;
                    }

                    //Polymorphism in action
                    calc.Display(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return;
                }


            }
            */
            #endregion
        }
    }
}
