/*
 * BitDestroyer
 */
namespace BitDestroyer;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine()!);
        int position = int.Parse(Console.ReadLine()!);

        string binary = Converter.ConvertToBinary(number);
        binary = Converter.SetBitToNegative(binary, position);
        double result = Converter.ConvertToDecimal(binary);

        Console.WriteLine(result);
    }
};


