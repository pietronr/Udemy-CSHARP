namespace Exercicio4.Entities
{
    class Individual : Pessoa
    {
        public double GastosSaude { get; set; }

        public Individual(string name, double rendaAnual, double gastosSaude)
        : base(name, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }

        public override double Imposto()
        {
            if(GastosSaude > 0) 
            {
                if(RendaAnual < 20000)
                {
                    return RendaAnual * 0.15 - GastosSaude * 0.5;
                }
                else
                {
                    return RendaAnual * 0.25 - GastosSaude * 0.5;
                }
            }
            else
            {
                if (RendaAnual < 20000)
                {
                    return RendaAnual * 0.15;
                }
                else
                {
                    return RendaAnual * 0.25;
                }
            }
        }
    }
}
