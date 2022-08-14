using System.Linq;

namespace tdd_kata_dodo
{
    public class IsbnClass
    {
        public bool CheckIsbn13(string input)
        {
            if (CheckLenghtOfIsbn13(input, out var clearInput))
            {
                var result = CheckMultiplyingIsbn13Digits(clearInput);
                return result;
            }

            return false;
        }

        public bool CheckLenghtOfIsbn13(string input, out string clearInput)
        {
            clearInput = string.Empty;

            if (string.IsNullOrEmpty(input)) 
                return false;
            
            clearInput = input.Replace(" ", null).Replace("-", null);
            return clearInput.Length == 13;
        }

        public bool CheckMultiplyingIsbn13Digits(string input)
        {
            var sum = 0;
            var numbers = input.Select(symbol => symbol - '0').ToArray();
            
            for (var i = 0; i < numbers.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += numbers[i] * 3;
                }
                else
                {
                    sum += numbers[i] * 1;
                }
            }
            
            var result = sum % 10 == 0;
            return result;
        }
    }
}