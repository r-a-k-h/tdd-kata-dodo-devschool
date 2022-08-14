using System.Linq;

namespace tdd_kata_dodo
{
    public class GreedClass
    {
        public int RollDices(int[] dices)
        {
            var sum = 0;

            var countOnes = dices.Count(d => d == 1);

            if (countOnes == 3)
            {
                sum += 1000;
            }

            if ((countOnes != 3) && (dices[0] == 1 || dices[1] == 1 || dices[2] == 1 || dices[3] == 1 || dices[4] == 1))
            {
                sum += 100;
            }
            
            if (dices[0] == 5 || dices[1] == 5 || dices[2] == 5 || dices[3] == 5 || dices[4] == 5)
            {
                sum += 50;
            }
            
            return sum;
        }
    }
}