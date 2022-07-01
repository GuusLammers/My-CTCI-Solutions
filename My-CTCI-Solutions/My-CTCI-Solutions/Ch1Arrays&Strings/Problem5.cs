using System;
namespace My_CTCI_Solutions.Ch1ArraysStrings
{
    public class Problem5
    {
        // There are three types of edits that can be performed on strings: insert a character,
        // remove a character, or replace a character.Given two strings, write a function to check if they are
        // one edit (or zero edits) away.
        // EXAMPLE
        // pale, ple -> true
        // pales, pale -> true
        // pale, bale -> true
        // pale, bake -> false
        public static bool OneEdit(String str1, String str2)
        {
            // length of strings differs by more then one character
            if(Math.Abs(str1.Length - str2.Length) > 1)
            {
                return false;
            }

            int str1Pointer = 0, str2Pointer = 0, edits = 0;
            while(str1Pointer < str1.Length && str2Pointer < str2.Length)
            {
                // characters at str1Pointer and str2Pointer are the same
                if(str1.ElementAt(str1Pointer).Equals(str2.ElementAt(str2Pointer)))
                {
                    str1Pointer++;
                    str2Pointer++;
                    continue;
                }

                // an edit is required if this point is reached
                edits++;
                if(edits > 1)
                {
                    return false;
                }

                // check if an replace edit is required
                if (str1.Length == str2.Length)
                {
                    str1Pointer++;
                    str2Pointer++;
                }
                // check if an insert edit is required
                else if(str1.Length - str2.Length < 0)
                {
                    str2Pointer++;
                }
                // remove edit is required
                else
                {
                    str1Pointer++;
                }
            }

            return edits == 1;
        }
    }
}

