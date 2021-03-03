namespace FoxAndRabbitOO
{
    public class Wolf : AnimalBase, ISpecialAnimalChecker
    {
        public Wolf(string _name, int _health, int[] _healthRange) : base(_name, _health, _healthRange)
        {
            this.species = "wolf";
        }

        public override bool PredatorChecker(AnimalBase enemyAnimal)
        {
            return false;
        }

        public override bool PreyChecker(AnimalBase enemyAnimal)
        {
            if (enemyAnimal.Species.ToLower() == "deer")
            {
                return true;
            }

            return false;
        }
    }
}