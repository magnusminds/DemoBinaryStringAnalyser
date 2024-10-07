using BinaryStringAnalyser.Interface;
using BinaryStringAnalyser.Repository;

namespace BinaryStringAnalyser.Tests.ForLoopAnalyserTests
{
    [TestClass]
    public class BinaryStringTests_ForLoop
    {
        private IValidateBinaryString analyser;

        [TestInitialize()]
        public void Initialize()
        {
            analyser = new LinqAnalyser();
        }

        [TestMethod]
        [DataRow("01")]
        [DataRow("0011")]
        [DataRow("000111")]
        public async Task GoodBinaryString(string input)
        {
            // Act
            bool result = await analyser.IsGoodBinaryString(input);

            // Assert
            Assert.AreEqual(true, result, $"The string '{input}' should return {true}.");
        }

        [TestMethod]
        [DataRow("")]
        [DataRow("1")]
        [DataRow("0")]
        [DataRow("010")]
        [DataRow("011110")]
        [DataRow("111111111111100000000")]
        public async Task BadBinaryString(string input)
        {
            // Act
            bool result = await analyser.IsGoodBinaryString(input);

            // Assert
            Assert.AreEqual(false, result, $"The string '{input}' should return {false}.");
        }

        [TestMethod]
        [DataRow("1a")]
        [DataRow("01b")]
        [DataRow("011c")]
        [DataRow("01x10")]
        [DataRow("AABB")]
        public async Task WrongCharactersBinaryString(string input)
        {
            // Act
            bool result = await analyser.IsGoodBinaryString(input);

            // Assert
            Assert.AreEqual(false, result, $"The string '{input}' should return {false}.");
        }
    }
}