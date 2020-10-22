using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        if (number > 0)
        {
            var collatz = 0;

            while (number != 1)
            {
                number = number % 2 == 0 ? number /= 2 : 3 * number + 1;
                ++collatz;
            }

            return collatz;
        }

        throw new ArgumentOutOfRangeException("Number is either 0 or negative.");
    }
}