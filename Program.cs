using MathAppLibrary;
using System;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            bool repeat;
            Calculator calculator = new Calculator();

            do
            {
                repeat = false;
                try
                {
                    switch (UserDecision())
                    {
                        case "+":
                            Console.Write("Please input a number: ");
                            a = double.Parse(Console.ReadLine());
                            Console.Write("Please input another number: ");
                            b = double.Parse(Console.ReadLine());
                            Console.WriteLine(calculator.Add(a, b));
                            break;
                        case "-":
                            Console.Write("Please input a number: ");
                            a = double.Parse(Console.ReadLine());
                            Console.Write("Please input another number: ");
                            b = double.Parse(Console.ReadLine());
                            Console.WriteLine(calculator.Subtract(a, b));
                            break;
                        case "*":
                            Console.Write("Please input a number: ");
                            a = double.Parse(Console.ReadLine());
                            Console.Write("Please input another number: ");
                            b = double.Parse(Console.ReadLine());
                            Console.WriteLine(calculator.Multiply(a, b));
                            break;
                        case "/":
                            Console.Write("Please input a number: ");
                            a = double.Parse(Console.ReadLine());
                            Console.Write("Please input another number: ");
                            b = double.Parse(Console.ReadLine());
                            if(b==0)
                            {
                                throw new Exception();
                            }
                            Console.WriteLine(calculator.Divide(a, b));
                            break;
                        case "%":
                            Console.Write("Please input a number: ");
                            a = double.Parse(Console.ReadLine());
                            Console.Write("Please input another number: ");
                            b = double.Parse(Console.ReadLine());
                            if (b == 0)
                            {
                                throw new Exception();
                            }
                            Console.WriteLine(calculator.Modulus(a, b));
                            break;
                        default:
                            Console.WriteLine("Thanks for stopping by!");
                            break;
                    }
                }
                catch (FormatException fEx)
                {
                    Console.WriteLine(fEx.Message);
                    repeat = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("You cannot divide by 0.");
                    repeat = true;
                }
            } while (repeat);
        }
        static string UserDecision()
        {
            Console.Write("Please input a type of mathematical operator (or something else if you wish to exit): ");
            string input = Console.ReadLine();
            return input;
        }
    }
}