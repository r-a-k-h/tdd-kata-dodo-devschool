namespace tdd_kata_dodo
{
    public class GreedClass
    {
        public int RollDices(int first, int second, int third, int fourth, int fifth)
        {
            var sum = 0;
            
            if (first == 1 || second == 1 || third == 1 || fourth == 1 || fifth == 1)
            {
                return 100;
            }
            
            return 0;
        }
    }
}