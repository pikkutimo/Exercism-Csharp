using System;
using System.Collections.Generic;
using System.Linq;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number < 1)
            throw new ArgumentOutOfRangeException();

        var sum = getFactorSum(number);

        if (sum == number)
            return Classification.Perfect;
        else if (sum > number)
            return Classification.Abundant;
        else
            return Classification.Deficient;
    }

    public static int getFactorSum(int number)
    {
        List<int> factors = new List<int>();

        for (int i = 1; i < number; ++i)
        {
            if (number % i == 0)
            {
                factors.Add(i);
            }
        }

        return factors.Sum();
    }

}
