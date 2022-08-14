namespace tdd_kata_dodo
{
    public class FizzBuzzClass
    {
        public string FizzBuzz(int input)
        {
            if (input % 3 == 0 && input % 5 == 0)
            {
                return "FizzBuzz";
            }
            
            if (input % 3 == 0)
            {
                return "Fizz";
            }
            
            if (input % 5 == 0)
            {
                return "Buzz";
            }
            
            return "1";
        }
    }
}