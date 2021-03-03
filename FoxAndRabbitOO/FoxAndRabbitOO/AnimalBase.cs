using System;

namespace FoxAndRabbitOO
{
    public abstract class AnimalBase
    {
        protected string species;
        protected string name;
        protected int health;
        protected int[] healthRange;
        protected int amountOfWins;

        public string Species
        {
            get => species;
            set => species = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Health
        {
            get => health;
            set => health = value;
        }

        public int[] HealthRange
        {
            get => healthRange;
            set => healthRange = value;
        }

        public int AmountOfWins
        {
            get => amountOfWins;
            set => amountOfWins = value;
        }

        protected AnimalBase(string _name, int _health, int[] _healthRange)
        {
            this.name = _name;
            this.health = _health;
            this.healthRange = _healthRange;
        }

        public string Fight(AnimalBase enemyAnimal)
        {
            if (PredatorChecker(enemyAnimal))
            {
                enemyAnimal.AmountOfWins++;
                return StandardMessages.AnimalInstantWin(enemyAnimal);
            }

            if (PreyChecker(enemyAnimal))
            {
                this.AmountOfWins++;
                return StandardMessages.AnimalInstantWin(this);
            }

            if (this.Health > enemyAnimal.Health)
            {
                this.amountOfWins++;
                return StandardMessages.AnimalWins(this);
            }
            else
            {
                enemyAnimal.AmountOfWins++;
                return StandardMessages.AnimalWins(enemyAnimal);
            }
        }


        public virtual bool PredatorChecker(AnimalBase enemyAnimal)
        {
            throw new NotImplementedException();
        }

        public virtual bool PreyChecker(AnimalBase enemyAnimal)
        {
            throw new NotImplementedException();
        }
    }
}