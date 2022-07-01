using System;
namespace My_CTCI_Solutions.Ch1ArraysStrings
{
    public class Problem4
    {
        // Input: Tact Coa
        // Output: True(permutations: "taco cat", "atco cta", etc.)

        public static bool PalindromePermutation(String str)
        {
            Dictionary<char, int> dict = new();

            int numberOfCharactersWithOddCount = 0;
            
            foreach(char c in str.ToLower())
            {
                if(Char.IsWhiteSpace(c))
                {
                    continue;
                }

                if(!dict.ContainsKey(c))
                {
                    dict.Add(c, 1);
                    numberOfCharactersWithOddCount++;
                }
                else
                {
                    dict[c]++;

                    if(dict[c] % 2 == 0)
                    {
                        numberOfCharactersWithOddCount--;
                    }
                    else
                    {
                        numberOfCharactersWithOddCount++;
                    }
                }
            }

            if(numberOfCharactersWithOddCount <= 1)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Checks if the passed in string is a palindrome.
        /// </summary>
        /// <param name="str">Contains no spaces.</param>
        /// <returns>True if the string is a palindrome.</returns>
        public static bool IsPalindrome(String str)
        {
            char[] charArray = str.ToCharArray();
            char[] charArrayReversed = str.ToCharArray();
            Array.Reverse(charArrayReversed);

            if (charArray.SequenceEqual(charArrayReversed))
            {
                return true;
            }

            return false;
        }
    }
}

