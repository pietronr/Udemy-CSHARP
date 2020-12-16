class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {

        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

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
	
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco);
            
            Produto p2 = new Produto();

            Produto p3 = new Produto { 
                Nome = "TV", 
                Preco = 500.00, 
                Quantidade = 20 
            };



            Console.WriteLine("\nDados do produto :" + p);

            Console.Write("\nDigite o número de produtos a ser adicionado no estoque: ");
            int adcQtd = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(adcQtd);

            Console.WriteLine("\nDados atualizados: " + p);

            Console.Write("\nDigite o número de produtos a ser removido do estoque: ");
            int delQtd = int.Parse(Console.ReadLine());

            p.RemoverProdutos(delQtd);

            Console.WriteLine("\nDados atualizados: " + p);
        }
    }