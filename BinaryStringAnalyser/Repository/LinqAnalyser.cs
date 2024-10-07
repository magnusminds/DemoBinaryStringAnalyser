using BinaryStringAnalyser.Interface;
using System.Diagnostics;

namespace BinaryStringAnalyser.Repository
{
    public class LinqAnalyser : IValidateBinaryString
    {
        // Function to check if a binary string is "good"
        public async Task<bool> IsGoodBinaryString(string binaryString)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine(binaryString);
            Console.WriteLine("Start quering using linq");
            if (binaryString.Length % 2 != 0 || binaryString.Length == 0)
            {
                Console.WriteLine($"Is \"{binaryString}\" a good binary string? {false} (Time: {stopwatch.ElapsedTicks} ticks)");
                return false;
            }
            else
            {
                if (!(binaryString.Contains('1') && binaryString.Contains('0')))
                {
                    Console.WriteLine($"Input string contains characters other than '0' or '1'");
                    return false;
                }
                else if (binaryString.Count(c => c == '1') != binaryString.Count(c => c == '0'))
                {
                    Console.WriteLine($"Is \"{binaryString}\" a good binary string? {false} (Time: {stopwatch.ElapsedTicks} ticks)");
                    return false;
                }
                stopwatch.Stop();
                Console.WriteLine($"Is \"{binaryString}\" a good binary string? {true} (Time: {stopwatch.ElapsedTicks} ticks)");
                return true;
            }
        }
    }
}