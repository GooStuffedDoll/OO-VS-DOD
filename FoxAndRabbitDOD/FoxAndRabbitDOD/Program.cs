using System;
using System.Security.Cryptography;

namespace FoxAndRabbitDOD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GC.GetTotalMemory(false));

            int theFox = AnimalFactory.BuildAnimal(1, "fox");
            int theWolf = AnimalFactory.BuildAnimal(1, "wolf");
            int theDeer = AnimalFactory.BuildAnimal(1, "deer");
            int theBun = AnimalFactory.BuildAnimal(1, "bun");
            int winnerSpecies = 0;


            for (int i = 0; i < 1000000; i++)
            {
                winnerSpecies = Fight.FightAnimals(RandomNumberGenerator.GetInt32(0, 4),
                    RandomNumberGenerator.GetInt32(0, 4));
                EntityScores.score[winnerSpecies] += 1;
            }

            Console.WriteLine(
                $"FOX:{EntityScores.score[0]}\nWOLF:{EntityScores.score[1]}\nDEER{EntityScores.score[2]}\nBUNNY{EntityScores.score[3]}");

            Console.WriteLine("\n" + GC.GetTotalMemory(false));
        }
    }
}