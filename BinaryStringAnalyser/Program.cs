using BinaryStringAnalyser.Interface;
using BinaryStringAnalyser.Repository;

public class BinaryStringEvaluator
{
    // Testing the function with examples
    public static void Main()
    {
        string[] testCases = {
            "",    // Not good: no 0's or 1's
            "1",    // Not good: unequal number of 0's and 1's
            "0",    // Not good: unequal number of 0's and 1's
            "110",      // Not good: unequal number of 0's and 1's
            "1100",     // Good: equal 0's and 1's, 1's >= 0's at all points
            "1001",     // Good: equal 0's and 1's, 1's >= 0's at all points
            "0011",     // Not good: more 0's than 1's in prefix
            "1010",     // Good: equal 0's and 1's, 1's >= 0's at all points
            "111000",    // Not good: unequal number of 0's and 1's
            "01A",    // Not good: Wrong Chaaracters in string
            "010A",    // Not good: Wrong Chaaracters in string
            "XXXX",    // Not good: Wrong Chaaracters in string
            "10AA",    // Not good: Wrong Chaaracters in string
        };
        IValidateBinaryString linqAnalyser = new LinqAnalyser();
        IValidateBinaryString forloopAnalyser = new ForloopAnalyser();
        foreach (var testCase in testCases)
        {
            linqAnalyser.IsGoodBinaryString(testCase).Wait();
            forloopAnalyser.IsGoodBinaryString(testCase).Wait();
        }
        Console.ReadLine();
    }
}