namespace BinaryHexConverter.Processor
{
    public class IntegerProcessor
    {
        internal bool IsInteger(string input, out int integerValue)
        {
            return int.TryParse(input, out integerValue);
        }
    }
}
