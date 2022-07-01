using System.Text;

namespace My_CTCI_Solutions.Ch1ArraysStrings
{
    public class Problem6
    {
        // For example, the string aabcccccaaa would become a2blc5a3.If the
        // "compressed" string would not become smaller than the original string, your method should return
        // the original string. You can assume the string has only uppercase and lowercase letters(a - z).
        public static String StringCompression(String str)
        {
            if(str.Length.Equals(0))
            {
                return str;
            }

            StringBuilder stringBuilder = new();

            char currentChar = str.ElementAt(0);
            int charCount = 1;
            for(int i = 1; i < str.Length; i++)
            {
                if(str.ElementAt(i).Equals(currentChar))
                {
                    charCount++;
                }
                else if(!str.ElementAt(i).Equals(currentChar)) 
                {
                    stringBuilder.Append(currentChar);
                    stringBuilder.Append(charCount);
                    currentChar = str.ElementAt(i);
                    charCount = 1;
                }
            }

            stringBuilder.Append(currentChar);
            stringBuilder.Append(charCount);

            if (stringBuilder.Length < str.Length)
            {
                return stringBuilder.ToString();
            }
            else
            {
                return str;
            }
            
        }
    }
}

