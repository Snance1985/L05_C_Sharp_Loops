namespace Assignment
{
    public class VowelFinder
    {
        public static int CountVowels(string input)
        {
            if (input == null || input.Length == 0)
                return 0;

            int vowelCount = 0;
            foreach (char c in input)
            {
                if (IsVowel(c))
                    vowelCount++;
            }

            return vowelCount;
        }

        private static bool IsVowel(char c)
        {
            c = char.ToLower(c);
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }
    }
}