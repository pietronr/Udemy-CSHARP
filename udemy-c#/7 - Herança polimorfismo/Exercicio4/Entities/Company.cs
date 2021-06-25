using System.Globalization;

namespace Exercicio4.Entities
{
    class Company : Pessoa
    {
        public int Empregados { get; set; }

        public Company(string name, double rendaAnual, int empregados)
            : base(name, rendaAnual)
        {
            Empregados = empregados;
        }

        public override double Imposto()
        {
            if(Empregados > 10)
            {
                return RendaAnual * 0.14;
            }
            else
            {
                return RendaAnual * 0.16;
            }
        }
    }
}
