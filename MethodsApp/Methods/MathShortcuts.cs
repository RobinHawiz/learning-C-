using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods;

internal class MathShortcuts
{
    public static void Add(double x, double y)
    {
        Console.WriteLine($"The value of {x} + {y} = {x + y}");
    }

    public static void AddAll(double[] values)
    {
        double result = 0;

        // values.Sum(); would also return the sum of values.
        foreach (double value in values)
        {
            result += value;
        }

        Console.WriteLine(result);
    }
}

