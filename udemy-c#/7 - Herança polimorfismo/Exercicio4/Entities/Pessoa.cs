namespace Exercicio4.Entities
{
    abstract class Pessoa
    {
        public string Name { get; set; }
        public double RendaAnual { get; set; }

        public Pessoa(string name, double rendaAnual) 
        {
            Name = name;
            RendaAnual = rendaAnual;
        }

        public abstract double Imposto();

    }
}
