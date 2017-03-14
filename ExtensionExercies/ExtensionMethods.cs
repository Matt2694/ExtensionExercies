using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionExercies
{
    public static class ExtensionsMethods
    {
        public static int Reverse(this int value)
        {
            int result;
            string stringValue = value.ToString();
            int n = stringValue.Length;
            char[] charArrayValue = new char[n];
            string firstSubstring = "";
            string lastSubstring = "";
            for (int i = 0; i <= (n / 2); i++)
            {
                firstSubstring = stringValue.Substring(i);
                lastSubstring = stringValue.Substring(n - (i + 1));
                charArrayValue[i] = lastSubstring[0];
                charArrayValue[n - (i + 1)] = firstSubstring[0];
            }
            string stringResult = new string(charArrayValue);
            result = Int32.Parse(stringResult);
            return result;
        }

        public static string Alphabetical(this string value)
        {
            char[] charArrayValue = value.ToCharArray();
            int length = charArrayValue.Length;
            int n = length;
            bool swapped = false;
            do
            {
                swapped = false;
                for (int i = 0; i < n - 1; i++)
                {
                    if (charArrayValue[i].CompareTo(charArrayValue[i + 1]) > 0)
                    {
                        char holder = charArrayValue[i];
                        charArrayValue[i] = charArrayValue[i + 1];
                        charArrayValue[i + 1] = holder;
                        swapped = true;
                    }
                }
            } while (swapped);
            string result = new string(charArrayValue);
            return result;
        }

        public static Dictionary<string, List<string>> AnagramChecker(this string value)
        {
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
            string[] anagramsArray;
            using (StreamReader sr = new StreamReader("WORD.txt"))
            {
                string anagrams = sr.ReadToEnd();
                anagramsArray = anagrams.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            }
            string alphaValue = value.Alphabetical();
            string[] alphaAnagramsArray = new string[anagramsArray.Length];
            for (int i = 0; i < anagramsArray.Length; i++)
            {
                alphaAnagramsArray[i] = anagramsArray[i].Alphabetical();
            }
            List<string> anagramList = new List<string>();
            for (int i = 0; i < alphaAnagramsArray.Length; i++)
            {
                if (alphaValue.Equals(alphaAnagramsArray[i]))
                {
                    if (!value.Equals(anagramsArray[i]))
                    {
                        anagramList.Add(anagramsArray[i]);
                    }
                }
            }
            result.Add(value, anagramList);
            return result;
        }

        public static int[] QuickSort(this IEnumerable<int[]> value)
        {

        }
    }
}
