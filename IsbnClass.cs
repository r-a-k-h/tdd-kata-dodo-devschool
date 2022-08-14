namespace tdd_kata_dodo
{
    public class IsbnClass
    {
        public bool CheckIsbn13(string input)
        {
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