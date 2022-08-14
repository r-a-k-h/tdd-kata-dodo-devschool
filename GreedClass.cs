namespace tdd_kata_dodo
{
    public class GreedClass
    {
        public int RollDices(int first, int second, int third, int fourth, int fifth)
        {
            var sum = 0;
            
            if (first == 1 || second == 1 || third == 1 || fourth == 1 || fifth == 1)
            {
                sum += 100;
            }
            
            if (first == 5 || second == 5 || third == 5 || fourth == 5 || fifth == 5)
            {
                sum += 50;
            }
            
            return sum;
        }
    }
}