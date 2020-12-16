 class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
 
 class Program
    {
        static void Main(string[] args)
        {
 
 
            Produto produto;
            produto = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDados do produto :" + produto);

            Console.Write("\nDigite o número de produtos a ser adicionado no estoque: ");
            int adcQtd = int.Parse(Console.ReadLine());

            produto.AdicionarProdutos(adcQtd);

            Console.WriteLine("\nDados atualizados: " + produto);

            Console.Write("\nDigite o número de produtos a ser removido do estoque: ");
            int delQtd = int.Parse(Console.ReadLine());

            produto.RemoverProdutos(delQtd);

            Console.WriteLine("\nDados atualizados: " + produto);
			
			}
			
		}