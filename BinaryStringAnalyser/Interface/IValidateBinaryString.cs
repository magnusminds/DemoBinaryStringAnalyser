namespace BinaryStringAnalyser.Interface
{
    public interface IValidateBinaryString
    {
        public Task<bool> IsGoodBinaryString(string binaryString);
    }
}