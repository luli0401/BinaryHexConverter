using BinaryHexConverter.Helper;
using System;
using System.Text.RegularExpressions;

namespace BinaryHexConverter.Processor
{
    public class HexProcessor
    {
        internal int ConvertToHex(string input)
        {
            int hexValue = 2;

            try
            {
                hexValue = Convert.ToInt32(input, 16);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception message: {0}", ex.Message);
            }

            return hexValue;
        }

        internal bool IsHexNumber(string input)
        {
            return Regex.IsMatch(input, "[0-9A-Fa-f]+");
        }
    }
}
