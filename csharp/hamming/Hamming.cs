using System;
using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand) => firstStrand.Length == secondStrand.Length
            ? firstStrand.Zip(secondStrand, (a, b) => a != b).Count(f => f)
            : throw new ArgumentException("The strands are not of equal length.");
}