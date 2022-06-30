using System;

namespace My_CTCI_Solutions.Ch1ArraysStrings
{
    public class Problem1
    {
        public static bool IsUnique(String str)
        {
            HashSet<Char> hashSet = new HashSet<Char>();

            foreach(char c in str)
            {
                hashSet.Add(c);
            }

            if(str.Length.Equals(hashSet.Count))
            {
                return true;
            }

            return false;
        }

        public static bool IsUniqueInPlace(String str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length - i; j++)
                {
                    if(str.ElementAt(i).Equals(str.ElementAt(j)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}

