namespace FoxAndRabbitOO
{
    public class Deer : AnimalBase, ISpecialAnimalChecker
    {
        public Deer(string _name, int _health, int[] _healthRange) : base(_name, _health, _healthRange)
        {
            this.species = "deer";
        }

        public override bool PredatorChecker(AnimalBase enemyAnimal)
        {
            if (enemyAnimal.Species.ToLower() == "wolf")
            {
                return true;
            }

            return false;
        }

        public override bool PreyChecker(AnimalBase enemyAnimal)
        {
            return false;
        }
    }
}