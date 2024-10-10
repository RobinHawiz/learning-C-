using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary;

public static class MathOperations
{
    public static double Add(double x, double y) { return x + y; }
    public static double Subtract(double x, double y) { return x - y; }
    public static double Multiply(double x, double y) { return x * y; }
    // I use Ints here because I want to learn how to catch exceptions and test them in my xunit tests.
    public static int Divide(int x, int y)
    {
        int output = 0;
        try
        {
            output = x / y;
        }
        catch (DivideByZeroException ex)
        {
            throw new DivideByZeroException("Cannot divide by zero");
        }
        return output;
    }
}