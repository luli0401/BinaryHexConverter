using BinaryHexConverter.Helper;
using System;

namespace BinaryHexConverter.Processor
{
    public class BinaryProcessor
    {
        internal string ConvertToInteger(string input)
        {
            string result = string.Empty;

            try
            {
                var binary = ToBinary(input);

                if (binary == -1)
                {
                    result = "Convert To Integer Error.";
                }
                else
                {
                    result = binary.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception message: {0}", ex.Message);
            }

            return result;
        }

        internal string ConvertToHex(string input)
        {
            string result = string.Empty;

            try
            {
                var binary = ToBinary(input);

                if (binary == -1)
                {
                    result = "Convert To Hex Error.";
                }
                else
                {
                    result = binary.ToHexString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception message: {0}", ex.Message);
            }

            return result;
        }

        private static int ToBinary(string input)
        {
            int binaryValue = -1;

            try
            {
                binaryValue = Convert.ToInt32(input, 2);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return binaryValue;
        }

    }
}
