namespace tdd_kata_dodo
{
    public class IsbnClass
    {
        public bool CheckIsbn13(string input)
        {
            if (input.Length != 13)
            {
                return false;
            }

            return true;
        }
    }
}