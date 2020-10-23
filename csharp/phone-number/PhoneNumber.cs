using System;
using System.Linq;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string justNumbers = new String(phoneNumber.Where(Char.IsDigit).ToArray());

        if (justNumbers.Length < 10 || justNumbers.Length > 11)
            throw new ArgumentException("Malformed phonenumber.");

        else if (justNumbers.Length == 11)
        {
            if (justNumbers[0] != '1' || justNumbers[1] == '1' || justNumbers[1] == '0'
                || justNumbers[4] == '1' || justNumbers[4] == '0')
                throw new ArgumentException("Not a valid phonenumber.");
            else
                justNumbers = justNumbers.Substring(1);
        }

        else if (justNumbers[0] == '1' || justNumbers[0] == '0'
                || justNumbers[3] == '1' || justNumbers[3] == '0')
            throw new ArgumentException("Not a valid phonenumber.");

        return justNumbers;
    }
}