using NUnit.Framework;
using tdd_kata_dodo;

namespace tdd_kata_tests
{
    public class IsbnTests
    {
        [Test]
        [TestCase("9780470059029")]
        [TestCase("978 0 471 48648 0")]
        [TestCase("978-0596809485")]
        [TestCase("978-0-13-149505-0")]
        [TestCase("978-0-262-13472-9")]
        public void Return_true_if_number_of_digits_are_13(string input)
        {
            var sut = new IsbnClass();

            var result = sut.CheckIsbn13(input);
            
            Assert.AreEqual(true, result);
        }
        
        [Test]
        [TestCase(null)]
        [TestCase("978 0 471 48648 0 1")]
        [TestCase("978-05968094851")]
        [TestCase("978-0-13-149505-0-1")]
        [TestCase("978-0-262-13472-91")]
        public void Return_false_if_number_of_digits_are_not_13(string input)
        {
            var sut = new IsbnClass();

            var result = sut.CheckIsbn13(input);
            
            Assert.AreEqual(false, result);
        }
    }
}