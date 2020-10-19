using System;
using System.Collections;
using System.Text;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = new string[] { "asd", "фвы", null, "!!!a" };
            text = TextTransformer.UpperCase(text);
            foreach (string str in text)
                Console.WriteLine(str);
            Console.WriteLine("______");

            text = TextTransformer.ConvertNullString(text);
            foreach (string str in text)
                Console.WriteLine(str);
        }
    }
}