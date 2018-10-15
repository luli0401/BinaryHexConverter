using System;
using System.Text;
using System.Text.RegularExpressions;

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

        internal bool IsBinaryNumber(string input)
        {
            return Regex.IsMatch(input, "^[01]+$");
        }

        internal string ConvertToNibbles(string text)
        {
            var digits = 4 - (text.Length % 4);
            var stringBuilder = new StringBuilder();

            if (digits != 4)
            {
                for (int a = 0; a < digits; a++)
                {
                    text = "0" + text;
                }
            }

            for (int a = 0; a < text.Length; a++)
            {
                stringBuilder.Append(text[a]);

                if ((a + 1) % 4 == 0 && (a + 1) != text.Length)
                {
                    stringBuilder.Append('-');
                }
            }


            return stringBuilder.ToString();
        }
    }
}
