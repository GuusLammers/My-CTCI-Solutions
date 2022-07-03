using System;
namespace My_CTCI_Solutions.Ch1ArraysStrings
{
    public class Problem9
    {
        // Rotation:Assume you have a method isSubstring which checks if oneword is a substring
        // of another.Given two strings, sl and s2, write code to check if s2 is a rotation of sl using only one
        // call to isSubstring(e.g., "waterbottle" is a rotation of"erbottlewat").

        public static bool StringRotation(String str1, String str2)
        {
            if(str1.Length != str2.Length)
            {
                return false;
            }

            return IsSubstring(str1 + str1, str2);
        }

        public static bool IsSubstring(String str1str1, String str2)
        {
            return str1str1.Contains(str2);
        }
    }
}

