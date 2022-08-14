namespace tdd_kata_dodo
{
    public class IsbnClass
    {
        public bool CheckIsbn13(string input)
        {
            var strWithoutSpaces = input.Replace(" ", null);
            
            if (strWithoutSpaces.Length != 13)
            {
                return false;
            }

            return true;
        }
    }
}