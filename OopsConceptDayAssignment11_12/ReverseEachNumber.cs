using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptDayAssignment11_12
{
    internal class ReverseEachNumber
    {
        internal static string ReverseEachWordAtItsPosition(string input)
        {
            char[] delimiters = new char[] { ' ', ',', '.', ';', ':', '!', '?' };
            string[] words = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = ReverseString(words[i]);
            }
            string result = "";
            for (int i = 0; i < words.Length; i++)
            {
                result += words[i];
                result += " ";
            }
            return result;
        }

        internal static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            int len = s.Length - 1;
            for (int i = 0; i < len; i++, len--)
            {
                char temp = charArray[i];
                charArray[i] = charArray[len];
                charArray[len] = temp;
            }
            return new string(charArray);
        }
    }
}
