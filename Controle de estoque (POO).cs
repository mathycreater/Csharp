\\ Classe para programa de controle de estoque:

using System;
using System.Collections.Generic;
using System.Text;

namespace estoque
{
    public class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;

        public double ValorTotalEmEstoque()
        {
            return preco * quantidade;
        }
        public void AdicionarProdutos(int q)
        {
            quantidade += q;
        }
        public void RemoverProdutos(int d)
        {
            quantidade -= d;
        }
        public override string ToString()
        {

            return "Produto: " + nome + " preço : $" + preco + " quantidade: " + quantidade;

        }

    }
}

\\ Programa :

using System;
using System.Globalization;

namespace estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto X = new Produto();

            Console.WriteLine("Digite o nome do produto: ");
            X.nome = Console.ReadLine();
            Console.WriteLine("Digite o valor do produto: ");
            X.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a quantidade do produto: ");
            X.quantidade = int.Parse(Console.ReadLine());

            double total = X.ValorTotalEmEstoque();

            Console.WriteLine("Produto: " + X.nome + " preço : $" + X.preco + " quantidade: " + X.quantidade);
            Console.WriteLine("Valor total em estoque: $" +  total.ToString());

            Console.WriteLine("Digite a quantidade de produtos a serem adicionados ao estoque:");
            int adicionar = int.Parse(Console.ReadLine());
            X.AdicionarProdutos(adicionar);
            Console.WriteLine(X.ToString());

            Console.WriteLine("Digite a quantidade de produtos a serem removidas do estoque:");
            adicionar = int.Parse(Console.ReadLine());
            X.RemoverProdutos(adicionar);
            Console.WriteLine(X.ToString());
        }
    }
}
