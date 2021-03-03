
namespace FoxAndRabbitDOD
{
    public class Fight
    {
        public static int FightAnimals(int firstAnimal, int secondAnimal)
        {
            // "fox" == 0;
            // "wolf" == 1;
            // "deer" == 2;
            // "bun" == 3;

            if (EntitySpecies.species[firstAnimal] == 1
                && EntitySpecies.species[secondAnimal] == 2)
            {
                return firstAnimal;
            }
            else if (EntitySpecies.species[firstAnimal] == 2
                     && EntitySpecies.species[secondAnimal] == 1)
            {
                return secondAnimal;
            }
            else if (EntitySpecies.species[firstAnimal] == 0
                     && EntitySpecies.species[secondAnimal] == 3)
            {
                return firstAnimal;
            }
            else if (EntitySpecies.species[firstAnimal] == 3
                     && EntitySpecies.species[secondAnimal] == 0)
            {
                return secondAnimal;
            }
            

            if (EntityHealth.health[firstAnimal] > EntityHealth.health[secondAnimal])
            {
                return firstAnimal;
            }
            else
            {
                return secondAnimal;
            }
        }
    }
}