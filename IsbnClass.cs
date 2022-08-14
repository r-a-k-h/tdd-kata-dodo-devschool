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
            
            var strWithoutSpaces = input.Replace(" ", null);
            var strWithoutSpacesAndDashes = strWithoutSpaces.Replace("-", null);
            
            if (strWithoutSpacesAndDashes.Length != 13)
            {
                return false;
            }

            return true;
        }
    }
}