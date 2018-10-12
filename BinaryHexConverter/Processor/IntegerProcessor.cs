using BinaryHexConverter.Helper;
using System;

namespace BinaryHexConverter.Processor
{
    public class IntegerProcessor
    {
        internal string ConvertToHex(string input)
        {
            string result = string.Empty;

            try
            {
                result = Convert.ToInt32(input).ToHexString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception message: {0}", ex.Message);
            }

            return result;
        }

        internal string ConvertToBinary(string input)
        {
            string result = string.Empty;

            try
            {
                result = Convert.ToInt32(input).ToBinaryString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception message: {0}", ex.Message);
            }

            return result;
        }
    }
}
