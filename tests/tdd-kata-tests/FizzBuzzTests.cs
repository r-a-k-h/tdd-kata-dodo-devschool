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
        
        [Test]
        [TestCase(3)]
        [TestCase(6)]
        public void For_input_divisible_by_3_return_Fizz(int input)
        {
            var sut = new FizzBuzzClass();

            var result = sut.FizzBuzz(input);

            Assert.AreEqual("Fizz", result);
        }
        
        [Test]
        [TestCase(5)]
        [TestCase(10)]
        public void For_input_divisible_by_5_return_Buzz(int input)
        {
            var sut = new FizzBuzzClass();

            var result = sut.FizzBuzz(input);

            Assert.AreEqual("Buzz", result);
        }
        
        [Test]
        [TestCase(15)]
        [TestCase(30)]
        public void For_input_divisible_by_3_and_5_return_FizzBuzz(int input)
        {
            var sut = new FizzBuzzClass();

            var result = sut.FizzBuzz(input);

            Assert.AreEqual("FizzBuzz", result);
        }
    }
}