using System.Collections.Generic;

namespace FoxAndRabbitDOD
{
    public class AnimalFactory
    {
        public static int BuildAnimal(int health, string species)
        {
            Dictionary<string, int> animalList = new Dictionary<string, int>();
            animalList.Add("fox", 0);
            animalList.Add("wolf", 1);
            animalList.Add("deer", 2);
            animalList.Add("bun", 3);

            EntityHealth.health.Add(0);
            EntitySpecies.species.Add(0);
            int position = EntityHealth.health.Count - 1;
            animalList.TryGetValue(species.ToLower(), out int inputSpecies);

            EntityHealth.health[position] = health;
            EntitySpecies.species[position] = inputSpecies;
            return position;
        }
    }
}