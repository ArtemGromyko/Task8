using System;
using System.Collections.Generic;
using System.Text;

namespace Task8
{
    static class TextTransformer
    {
        public static string[] UpperCase(string[] text)
        {
            string[] newText = new string[text.Length];
            int index = 0;
            foreach (string str in text)
            {
                if (str != null)
                    newText[index++] = str.ToUpper();
                else
                    newText[index++] = str;
            }
            return newText;
        }
        public static string[] ConvertNullString(string[] text)
        {
            string[] newText = new string[text.Length];
            int index = 0;
            foreach (string str in text)
            {
                if (str == null)
                    newText[index++] = "this is null string";
                else
                    newText[index++] = str;
            }
            return newText;
        }
    }
}
