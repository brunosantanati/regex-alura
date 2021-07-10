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

            alterarFormatoData();

            trocarSeparador();

            Console.ReadKey();

        }

        private static void alterarFormatoData()
        {
            //string alvo = "2007-12-31";
            string alvo = "2007-12-31 2021-07-09";
            Regex regexp = new Regex(@"(\d{4})(-)(\d{2})(-)(\d{2})");

            MatchCollection resultados = regexp.Matches(alvo);
            foreach (Match resultado in resultados)
            {

                string ano = resultado.Groups[1].Value;
                string mes = resultado.Groups[3].Value;
                string dia = resultado.Groups[5].Value;

                string separador1 = resultado.Groups[2].Value;
                string separador2 = resultado.Groups[4].Value;

                Console.WriteLine(string.Format("{0}/{1}/{2}", dia, mes, ano));
            }
        }

        private static void trocarSeparador()
        {
            string alvo = "2010-10-10";
            Regex regexp = new Regex(@"(\d{4})(-)(\d{2})(-)(\d{2})");

            MatchCollection resultados = regexp.Matches(alvo);
            foreach (Match resultado in resultados)
            {

                string ano = resultado.Groups[1].Value;
                string mes = resultado.Groups[3].Value;
                string dia = resultado.Groups[5].Value;

                string separador1 = resultado.Groups[2].Value;
                string separador2 = resultado.Groups[4].Value;

                string novaData = string.Format("{0}{1}{2}{3}{4}", dia, separador1, mes, separador2, ano).Replace("-", "/");
                Console.WriteLine(novaData);
            }
        }
    }
}
