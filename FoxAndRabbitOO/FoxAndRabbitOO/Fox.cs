namespace FoxAndRabbitOO
{
    public class Fox : AnimalBase, ISpecialAnimalChecker
    {
        public Fox(string _name, int _health, int[] _healthRange) : base(_name, _health, _healthRange)
        {
            this.species = "fox";
        }

        public override bool PredatorChecker(AnimalBase enemyAnimal)
        {
            return false;
        }

        public override bool PreyChecker(AnimalBase enemyAnimal)
        {
            if (enemyAnimal.Species.ToLower() == "rabbit")
            {
                return true;
            }

            return false;
        }
    }
}