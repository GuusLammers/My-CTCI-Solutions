using System.Text;

namespace My_CTCI_Solutions.Ch1ArraysStrings
{
    public class Problem3
    {
        /// Input: "Mr John Smith    ", 13
        /// Output: "Mr%20John%20Smith"
        public static String URLify(String str, int length)
        {
            StringBuilder strBuilder = new StringBuilder();

            for(int i = 0; i < str.Length; i++)
            {
                if (i < length)
                {
                    if (Char.IsWhiteSpace(str, i))
                    {
                        strBuilder.Append("%20");
                        continue;
                    }

                    strBuilder.Append(str.ElementAt(i));
                }
            }

            return strBuilder.ToString();
        }
    }
}

