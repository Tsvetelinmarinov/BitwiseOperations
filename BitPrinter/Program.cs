/*
 * BitPrinter
 */

using BitDestroyer;

namespace BitPrinter;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine()!);
        int position = int.Parse(Console.ReadLine()!);
        string binary = Converter.ConvertToBinary(number);

        int bit = Converter.GetBitAt(binary, position);
        Console.WriteLine(bit);
    }
}