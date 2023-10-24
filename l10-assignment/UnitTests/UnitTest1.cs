namespace UnitTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {

    }
}

namespace AssignmentTests
{
    [TestFixture]
    public class VowelFinderTests
    {
        [Test]
        public void CountVowels_ValidInputWithVowels_ReturnsCorrectCount()
        {
            string input = "adieu";
            int expectedCount = 4;

            int actualCount = VowelFinder.CountVowels(input);

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void CountVowels_ValidInputWithoutVowels_ReturnsZero()
        {
            string input = "rhythm";
            int expectedCount = 0;

            int actualCount = VowelFinder.CountVowels(input);

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void CountVowels_NonStringInput_ReturnsZero()
        {
            string input = null;
            int expectedCount = 0;

            int actualCount = VowelFinder.CountVowels(input);

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void CountVowels_EmptyInput_ReturnsZero()
        {
            string input = "";
            int expectedCount = 0;

            int actualCount = VowelFinder.CountVowels(input);

            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}