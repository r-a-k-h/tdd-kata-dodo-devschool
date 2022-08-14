using NUnit.Framework;
using tdd_kata_dodo;

namespace tdd_kata_tests
{
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(1)]
        public void For_other_input_return_input(int input)
        {
            var sut = new FizzBuzzClass();

            var result = sut.FizzBuzz(input);

            Assert.AreEqual("1", result);
        }
    }
}