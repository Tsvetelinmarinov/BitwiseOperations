/*
 * BitDestroyer
 */

namespace BitDestroyer
{
    public class Converter
    {
        public static string ConvertToBinary(int number) 
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
        public static double ConvertToDecimal(string binary)
        {
            List<int> bits = new();
            List<double> decimalBits = new();

            foreach (char bit in binary)
            {
                bits.Add(int.Parse(bit.ToString()));
            }

            double power = bits.Count - 1;
            foreach (int bit in bits)
            {
                decimalBits.Add(bit * Math.Pow(2, power--));
            }

            return decimalBits.Sum();
        }
        public static string ModifyBit(string binary, int bitPosition)
        {
            List<int> bits = new();
            foreach (char bit in binary)
            {
                bits.Add(int.Parse(bit.ToString()));
            }

            bits[bits.Count - 1 - bitPosition] = 0;
            return string.Join("", bits);
        }
        public static int GetBitAt(string binary, int bitPosition)
        {
            List<byte> bits = new();
            foreach (char bit in binary)
            {
                bits.Add(byte.Parse(bit.ToString()));
            }

            if (!string.IsNullOrWhiteSpace(binary) && bitPosition >= 0)
            {
                return bits[bits.Count - 1 - bitPosition];
            }
            else
            {
                return -1;
            }
        }
    }
}
