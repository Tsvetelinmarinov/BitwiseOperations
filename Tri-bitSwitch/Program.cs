/*
 * Tri-bitSwitch
 */

using BitDestroyer;

namespace Tri_bitSwitch;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine()!);
        int bitPosition = int.Parse(Console.ReadLine()!);
        string binary = Converter.ConvertToBinary(number);

        for (int i = 0; i < 3; ++i)
        {
            int index = bitPosition;
            if (Converter.GetBitValue(binary, bitPosition) == 0)
            {
                binary = Converter.SetBitToPositive(binary, index++);
            }
            else
            {
                binary = Converter.SetBitToNegative(binary, index++);
            }
        }

        double result = Converter.ConvertToDecimal(binary);
        Console.WriteLine(result);
    }
}