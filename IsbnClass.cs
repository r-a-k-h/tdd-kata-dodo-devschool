using System.Linq;

namespace tdd_kata_dodo
{
    public class IsbnClass
    {
        public bool CheckIsbn13(string input)
        {
            if (CheckLenghtOfIsbn13(input))
            {
                return true;
            }

            return false;
        }

        public bool CheckLenghtOfIsbn13(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                var clearInput = input.Replace(" ", null).Replace("-", null);
                if (clearInput.Length != 13)
                {
                    return false;
                }

                return true;
            }

            return false;
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