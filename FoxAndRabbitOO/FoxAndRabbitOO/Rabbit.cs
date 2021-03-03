namespace FoxAndRabbitOO
{
    public class Rabbit : AnimalBase, ISpecialAnimalChecker
    {
        public Rabbit(string _name, int _health, int[] _healthRange) : base(_name, _health, _healthRange)
        {
            this.species = "rabbit";
        }

        public override bool PredatorChecker(AnimalBase enemyAnimal)
        {
            if (enemyAnimal.Species.ToLower() == "fox")
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