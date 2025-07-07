/*
 * BinaryDigitsCount
 */

namespace BinaryDigitsCount;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine()!);
        byte bit = byte.Parse(Console.ReadLine()!);

        string binary = ConvertToBinary(number);
        int occurences = GetOccurences(binary, bit);

        Console.WriteLine($"We have {occurences} occurences");
    }

    static string ConvertToBinary(int number)
    {
        List<byte> bits = new();
        while (number > 0)
        {
            bits.Add((byte)(number % 2));
            number /= 2;
        }

        bits.Reverse();
        return string.Join("", bits);
    }
    static int GetOccurences(string binary, byte bitValue)
    {
        int counter = default;
        foreach (char bit in binary)
        {
            if (bit.ToString().Equals(bitValue.ToString()))
            {
                counter++;
            }
        }

        if (counter > 0)
        {
            return counter;
        }
        else
        {
            return -1;
        }
    }
}