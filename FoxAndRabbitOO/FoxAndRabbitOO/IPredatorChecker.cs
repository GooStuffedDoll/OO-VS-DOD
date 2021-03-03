namespace FoxAndRabbitOO
{
    public interface ISpecialAnimalChecker
    {
        public bool PredatorChecker(AnimalBase enemyAnimal);
        public bool PreyChecker(AnimalBase enemyAnimal);
    }
}