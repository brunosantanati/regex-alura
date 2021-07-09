using System;
using System.Text.RegularExpressions;

namespace regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string alvo = "11a22b33c";
            //string pattern = "(\\d\\d)(\\w)";
            string pattern = @"(\d\d)(\w)";

            Regex regex = new Regex(pattern);

            Console.WriteLine("Unico match: ");
            Console.WriteLine();

            Match match = regex.Match(alvo);

            Console.WriteLine(match.Value);
            Console.WriteLine(match.Index);
            Console.WriteLine(match.Length);
            Console.WriteLine();

            Console.WriteLine(match.Groups[0].Value);
            Console.WriteLine(match.Groups[0].Index);
            Console.WriteLine(match.Groups[0].Length);
            Console.WriteLine();

            Console.WriteLine(match.Groups[1].Value);
            Console.WriteLine(match.Groups[1].Index);
            Console.WriteLine(match.Groups[1].Length);
            Console.WriteLine();

            Console.WriteLine(match.Groups[2].Value);
            Console.WriteLine(match.Groups[2].Index);
            Console.WriteLine(match.Groups[2].Length);
            Console.WriteLine();

            Console.WriteLine("Varios matches: ");
            Console.WriteLine();

            MatchCollection matches = regex.Matches(alvo);

            foreach (Match m in matches)
            {
                Console.WriteLine(m.Groups[0].Value);
                Console.WriteLine(m.Groups[1].Value);
                Console.WriteLine(m.Groups[2].Value);
                Console.WriteLine(m.Index);
                Console.WriteLine(m.Length);
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
