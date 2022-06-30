namespace My_CTCI_Solutions.Ch1ArraysStrings
{
    public class Problem2
    {
        public static bool ArePermutations(String str1, String str2)
        {
            char[] str1CharArray = str1.ToCharArray();
            char[] str2CharArray = str2.ToCharArray();

            Array.Sort(str1CharArray);
            Array.Sort(str2CharArray);

            if(str1CharArray.SequenceEqual(str2CharArray))
            {
                return true;
            }

            return false;
        }
    }
}

