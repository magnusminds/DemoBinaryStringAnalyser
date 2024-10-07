using BinaryStringAnalyser.Interface;
using System.Diagnostics;

namespace BinaryStringAnalyser.Repository
{
    public class ForloopAnalyser : IValidateBinaryString
    {
        // Function to check if a binary string is "good"
        public async Task<bool> IsGoodBinaryString(string binaryString)
        {
            int onesCount = 0, zerosCount = 0;

            Console.WriteLine("Start quering using forloop");

            // Iterate through each character in the binary string
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (binaryString.Length % 2 != 0 || binaryString.Length == 0)
            {
                Console.WriteLine($"Is \"{binaryString}\" a good binary string? {false} (Time: {stopwatch.ElapsedTicks} ticks)");
                zerosCount = 1; onesCount = 0;
            }
            else
            {
                foreach (char bit in binaryString)
                {
                    if (bit == '1')
                    {
                        onesCount++;
                    }
                    else if (bit == '0')
                    {
                        zerosCount++;
                    }
                    else
                    {
                        // Invalid character in binary string
                        Console.WriteLine("Input string contains characters other than '0' or '1'");
                        zerosCount = 1; onesCount = 0;
                        break;
                    }
                }
                stopwatch.Stop();
                Console.WriteLine($"Is \"{binaryString}\" a good binary string? {onesCount == zerosCount} (Time: {stopwatch.ElapsedTicks} ticks)");
            }
            // Final check: Equal number of 0's and 1's
            return onesCount == zerosCount;
        }
    }
}