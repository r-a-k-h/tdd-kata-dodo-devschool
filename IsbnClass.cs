namespace tdd_kata_dodo
{
    public class IsbnClass
    {
        public bool CheckIsbn13(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            
            var clearInput = input.Replace(" ", null).Replace("-", null);
            
            if (clearInput.Length != 13)
            {
                return false;
            }

            return true;
        }
    }
}