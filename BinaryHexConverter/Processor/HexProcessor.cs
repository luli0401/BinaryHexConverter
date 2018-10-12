using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHexConverter.Processor
{
    public class HexProcessor
    {
        internal string ConvertToBinary(string input)
        {
            string result = string.Empty;

            try
            {
                result = Convert.ToString(Convert.ToInt32(input, 16), 2);

            }
            catch(Exception ex)
            {

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

            }

            return result;
        }
    }
}
