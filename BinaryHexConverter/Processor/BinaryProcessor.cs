using BinaryHexConverter.Helper;
using System;

namespace BinaryHexConverter.Processor
{
    public class BinaryProcessor
    {
        internal int ConvertToBinary(string input)
        {
            int binaryValue = 2;
        
            try
            {
                binaryValue = Convert.ToInt32(input, 2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception message: {0}", ex.Message);
            }

            return binaryValue;
        }
    }
}
