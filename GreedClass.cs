using System.Linq;

namespace tdd_kata_dodo
{
    public class GreedClass
    {
        public int RollDices(int[] dices)
        {
            var sum = 0;

            var countOnes = dices.Count(d => d == 1);
            var countTwos = dices.Count(d => d == 2);
            var countThrees = dices.Count(d => d == 3);
            var countFours = dices.Count(d => d == 4);
            var countFives = dices.Count(d => d == 5);
            var countSixes = dices.Count(d => d == 6);

            if (countOnes >= 3)
                sum += 1000;

            if (countTwos >= 3)
                sum += 200;
            
            if (countThrees >= 3)
                sum += 300;
            
            if (countFours >= 3)
                sum += 400;
            
            if (countFives >= 3)
                sum += 500;
            
            if (countSixes >= 3)
                sum += 600;
            
            if ((countOnes != 3) && (dices[0] == 1 || dices[1] == 1 || dices[2] == 1 || dices[3] == 1 || dices[4] == 1))
            {
                sum += 100;
            }
            
            if ((countFives != 3) && (dices[0] == 5 || dices[1] == 5 || dices[2] == 5 || dices[3] == 5 || dices[4] == 5))
            {
                sum += 50;
            }
            
            return sum;
        }
    }
}