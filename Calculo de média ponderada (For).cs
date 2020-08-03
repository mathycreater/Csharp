 static void Main(string[] args)
        {
            int N = 3;
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("digite 3 médias para o teste {0}", i);
                string[] linha = Console.ReadLine().Split(' ');
                double t11 = double.Parse(linha[0], CultureInfo.InvariantCulture);
                double t12 = double.Parse(linha[1], CultureInfo.InvariantCulture);
                double t13 = double.Parse(linha[2], CultureInfo.InvariantCulture);
                double media = (t11 * 2.0 + t12 * 3.0 + t13 * 5.0) / 10.0;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            }
        }
