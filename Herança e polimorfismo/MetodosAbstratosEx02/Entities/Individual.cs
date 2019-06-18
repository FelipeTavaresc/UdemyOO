namespace MetodosAbstratosEx02.Entities
{
    class Individual : TaxPlayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20.000)
            {
                return (AnualIncome * 15 / 100) - (HealthExpenditures / 2.0);
            }
            else
            {
                return (AnualIncome * 25 / 100) - (HealthExpenditures / 2.0);
            }
        }
    }
}