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

            var result = sut.CheckLenghtOfIsbn13(input, out var anyString);
            
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

            var result = sut.CheckLenghtOfIsbn13(input, out var anyString);
            
            Assert.AreEqual(false, result);
        }
        
        [Test]
        [TestCase("9780470059029")]
        [TestCase("9780471486480")]
        [TestCase("9780596809485")]
        [TestCase("9780131495050")]
        [TestCase("9780262134729")]
        public void Return_true_if_multiplying_check_is_ok(string input)
        {
            var sut = new IsbnClass();

            var result = sut.CheckMultiplyingIsbn13Digits(input);
            
            Assert.AreEqual(true, result);
        }
        
        [Test]
        [TestCase("9780470059020")]
        [TestCase("9780471486481")]
        [TestCase("9780596809486")]
        [TestCase("9780131495051")]
        [TestCase("9780262134720")]
        public void Return_false_if_multiplying_check_is_not_ok(string input)
        {
            var sut = new IsbnClass();

            var result = sut.CheckMultiplyingIsbn13Digits(input);
            
            Assert.AreEqual(false, result);
        }
        
        [Test]
        [TestCase("9780470059029")]
        [TestCase("978 0 471 48648 0")]
        [TestCase("978-0596809485")]
        [TestCase("978-0-13-149505-0")]
        [TestCase("978-0-262-13472-9")]
        public void Return_true_if_all_checks_are_ok(string input)
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
        public void Return_false_if_not_all_checks_are_ok(string input)
        {
            var sut = new IsbnClass();

            var result = sut.CheckIsbn13(input);
            
            Assert.AreEqual(false, result);
        }
    }
}