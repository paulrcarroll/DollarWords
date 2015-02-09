using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DollarWords;

namespace DollarWordsTests
{
    [TestClass]
    public class DollarWordsUnitTests
    {
        [TestMethod]
        public void LetterAEvaluatesTo1()
        {
            int expectedIndex = 1;
            int actualIndex = 'a'.AlphabeticIndex();

            Assert.AreEqual(expectedIndex, actualIndex, "The letter 'a' does not evaluate to index 1.");
        }

        [TestMethod]
        public void LetterZEvaluatesTo26()
        {
            int expectedIndex = 26;
            int actualIndex = 'z'.AlphabeticIndex();

            Assert.AreEqual(expectedIndex, actualIndex, "The letter 'z' does not evaluate to index 26.");
        }

        [TestMethod]
        public void WhitespaceEvaluatesToZero()
        {
            int expectedIndex = 0;
            int actualIndex = ' '.AlphabeticIndex();

            Assert.AreEqual(expectedIndex, actualIndex, "Whitespace does not evaluate to index 0.");
        }

        [TestMethod]
        public void NumbersEvaluateToZero()
        {
            int expectedIndex = 0;
            int actualIndex = '1'.AlphabeticIndex();

            Assert.AreEqual(expectedIndex, actualIndex, "Numbers do not evaluate to index 0.");
        }

        [TestMethod]
        public void IsCaseInsensitive()
        {
            Assert.AreEqual('a'.AlphabeticIndex(), 'A'.AlphabeticIndex(), "The letter 'a' does not evaluate to the same index as the capital letter 'A'.");
        }

        [TestMethod]
        public void LetterSumIsCorrect()
        {
            int expectedSum = 10;
            string testString = "abcd";

            int actualSum = testString.SumLetters();

            Assert.AreEqual(expectedSum, actualSum, String.Format("The sum of the test string [{0}] does not equal the expected sum.", testString));
        }

        [TestMethod]
        public void LetterSumIsCorrectWithWhitespaceAndPunctuation()
        {
            int expectedSum = 10;
            string testString = "a b,cd ---";

            int actualSum = testString.SumLetters();

            Assert.AreEqual(expectedSum, actualSum, String.Format("The sum of the test string [{0}] does not equal the expected sum.", testString));
        }
    }
}
