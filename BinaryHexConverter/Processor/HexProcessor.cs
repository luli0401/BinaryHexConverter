using BinaryHexConverter.Helper;
using System;

namespace BinaryHexConverter.Processor
{
    public class HexProcessor
    {
        internal string ConvertToBinary(string input)
        {
            string result = string.Empty;

            try
            {
                result = Convert.ToInt32(input, 16).ToBinaryString();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception message: {0}", ex.Message);
            }

            return result;
        }

        internal string ConvertToInteger(string input)
        {
            string result = string.Empty;

            try
            {
                result = Convert.ToInt32(input, 16).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception message: {0}", ex.Message);
            }

            return result;
        }
    }
}
