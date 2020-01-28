using System;

namespace MathAppLibrary
{
    public class Calculator
    {
        public string Add(double a, double b)
        {
            double c = a + b;
            return $"{a} + {b} = {c}";
        }
        public string Subtract(double a, double b)
        {
            double c = a - b;
            return $"{a} - {b} = {c}";
        }
        public string Multiply(double a, double b)
        {
            double c = a * b;
            return $"{a} * {b} = {c}";
        }
        public string Divide(double a, double b)
        {
            double c = a / b;
            return $"{a} / {b} = {c}";
        }
        public string Modulus(double a, double b)
        {
            double c = a % b;
            return $"{a} % {b} = {c}";
        }
    }
}
