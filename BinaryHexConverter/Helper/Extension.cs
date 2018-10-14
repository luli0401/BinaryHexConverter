using System;

namespace BinaryHexConverter.Helper
{
    public static class Extension
    {
        public static string ToHexString(this int intValue)
        {
            var result = "Converte To HexString Error.";

            try
            {
                result = Convert.ToString(intValue, 16);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception message: {0}", ex.Message);
            }

            return result;
        }

        public static string ToBinaryString(this int intValue)
        {
            var result = "Converte To BinaryString Error.";

            try
            {
                result = Convert.ToString(intValue, 2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception message: {0}", ex.Message);
            }

            return result;
        }       
    }
}
