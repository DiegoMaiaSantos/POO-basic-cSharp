using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEF    ";

            string maiuscula = original.ToUpper();
            string minuscula = original.ToLower();
            string apagarEspacoBranco = original.Trim();

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string s1 = original.Substring(3);
            string s2 = original.Substring(3, 5);

            string s3 = original.Replace('a', 'x');
            string s4 = original.Replace("abc", "xy");

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: - " + original + " -");
            Console.WriteLine("Maiuscula: - " + maiuscula + " -");
            Console.WriteLine("Minuscula: - " + minuscula + " -");
            Console.WriteLine("Apagar os espaços em brancos: - " + apagarEspacoBranco + " -");

            Console.WriteLine("IndexOf('bc'): - " + n1 + " -");
            Console.WriteLine("LastIndexOf('bc'): - " + n2 + " -");

            Console.WriteLine("Substring(3): - " + s1 + " -");
            Console.WriteLine("Substring(3, 5): - " + s2 + " -");

            Console.WriteLine("Replace('a', 'x'): " + s3 + " -");
            Console.WriteLine("Replace('abc', 'xy'): " + s4 + " -");

            Console.WriteLine("IsNullOrEmpty: " + b1 + " -");
            Console.WriteLine("IsNullOrWhiteSpace: " + b2 + " -");
        }
    }
}