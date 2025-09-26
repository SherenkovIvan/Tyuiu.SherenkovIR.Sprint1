using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SherenkovIR.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {
            if (string.IsNullOrEmpty(value))
                return string.Empty;

            var words = value.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

            var palindromes = words.Where(word => IsPalindrome(word.ToLower())).ToList();

            return string.Join(", ", palindromes);
        }

        private bool IsPalindrome(string word)
        {
            int len = word.Length;
            for (int i = 0; i < len / 2; i++)
            {
                if (word[i] != word[len - 1 - i])
                    return false;
            }
            return true;
        }
    }
}




