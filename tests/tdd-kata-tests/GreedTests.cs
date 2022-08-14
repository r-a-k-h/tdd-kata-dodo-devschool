using NUnit.Framework;
using tdd_kata_dodo;

namespace tdd_kata_tests
{
    public class GreedTests
    {
        // A single one (100 points)
        // A single five (50 points)
        // Triple ones [1,1,1] (1000 points)
        // Triple twos [2,2,2] (200 points)
        // Triple threes [3,3,3] (300 points)
        // Triple fours [4,4,4] (400 points)
        // Triple fives [5,5,5] (500 points)
        // Triple sixes [6,6,6] (600 points)

        // Example
        // [1,1,1,5,1] = 1150 points
        // [2,3,4,6,2] = 0 points
        // [3,4,5,3,3] = 350 points
        
        [Test]
        [TestCase(1, 2, 3, 4, 4)]
        [TestCase(2, 1, 3, 4, 4)]
        [TestCase(3, 2, 1, 4, 4)]
        [TestCase(3, 2, 4, 1, 4)]
        [TestCase(3, 2, 4, 4, 1)]
        public void If_dropped_just_single_one_return_100(int first, int second, int third, int fourth, int fifth)
        {
            var sut = new GreedClass();

            var dices = new[]
            {
                first, second, third, fourth, fifth
            };
            
            var result = sut.RollDices(dices);
            
            Assert.AreEqual(100, result);
        }
        
        [Test]
        [TestCase(5, 2, 3, 4, 4)]
        [TestCase(2, 5, 3, 4, 4)]
        [TestCase(3, 2, 5, 4, 4)]
        [TestCase(3, 2, 4, 5, 4)]
        [TestCase(3, 2, 4, 4, 5)]
        public void If_dropped_just_single_five_return_50(int first, int second, int third, int fourth, int fifth)
        {
            var sut = new GreedClass();

            var dices = new[]
            {
                first, second, third, fourth, fifth
            };
            
            var result = sut.RollDices(dices);
            
            Assert.AreEqual(50, result);
        }
        
        [Test]
        [TestCase(5, 1, 3, 4, 4)]
        [TestCase(2, 5, 1, 4, 4)]
        [TestCase(3, 2, 5, 1, 4)]
        [TestCase(1, 2, 4, 5, 4)]
        [TestCase(1, 1, 4, 4, 5)]
        public void If_dropped_single_one_and_five_return_150(int first, int second, int third, int fourth, int fifth)
        {
            var sut = new GreedClass();

            var dices = new[]
            {
                first, second, third, fourth, fifth
            };
            
            var result = sut.RollDices(dices);
            
            Assert.AreEqual(150, result);
        }
        
        [Test]
        [TestCase(1, 1, 1, 4, 4)]
        [TestCase(3, 1, 3, 1, 1)]
        [TestCase(1, 2, 1, 1, 4)]
        public void If_dropped_triple_ones_return_1000(int first, int second, int third, int fourth, int fifth)
        {
            var sut = new GreedClass();

            var dices = new[]
            {
                first, second, third, fourth, fifth
            };
            
            var result = sut.RollDices(dices);
            
            Assert.AreEqual(1000, result);
        }
        
        [Test]
        [TestCase(1, 1, 1, 4, 1)]
        public void If_dropped_triple_ones_and_another_one_return_1100(int first, int second, int third, int fourth, int fifth)
        {
            var sut = new GreedClass();

            var dices = new[]
            {
                first, second, third, fourth, fifth
            };
            
            var result = sut.RollDices(dices);
            
            Assert.AreEqual(1100, result);
        }
        
        [Test]
        [TestCase(1, 1, 5, 4, 1)]
        public void If_dropped_triple_ones_and_single_five_return_1050(int first, int second, int third, int fourth, int fifth)
        {
            var sut = new GreedClass();

            var dices = new[]
            {
                first, second, third, fourth, fifth
            };
            
            var result = sut.RollDices(dices);
            
            Assert.AreEqual(1050, result);
        }
    }
}