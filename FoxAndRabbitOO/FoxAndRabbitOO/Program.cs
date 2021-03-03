using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace FoxAndRabbitOO
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] theHEALTHRANGE = {1, 10};
            Fox fox = new Fox("fox", 1, theHEALTHRANGE);
            Wolf wolf = new Wolf("wolf", 1, theHEALTHRANGE);
            Deer deer = new Deer("deer", 1, theHEALTHRANGE);
            Rabbit rabbit = new Rabbit("rabbit", 1, theHEALTHRANGE);
            Dictionary<int, AnimalBase> theANIMAL = new Dictionary<int, AnimalBase>();

            theANIMAL.Add(0, fox);
            theANIMAL.Add(1, wolf);
            theANIMAL.Add(2, deer);
            theANIMAL.Add(3, rabbit);
            for (int i = 0; i < 1000000; i++)
            {
                theANIMAL.TryGetValue(RandomNumberGenerator.GetInt32(0, 4), out AnimalBase animal1);
                theANIMAL.TryGetValue(RandomNumberGenerator.GetInt32(0, 4), out AnimalBase animal2);
                animal1.Health = RandomNumberGenerator.GetInt32(0, 10);
                animal2.Health = RandomNumberGenerator.GetInt32(0, 10);
                animal1.Fight(animal2);
                WinCounterHelper.addWinsToCounter(animal1);
                WinCounterHelper.addWinsToCounter(animal2);
            }

            Console.WriteLine(
                $"FOX:{WinCounter.foxWins}\nWOLF:{WinCounter.wolfWins}\nDEER:{WinCounter.deerWins}\nRABBIT:{WinCounter.rabbitWins}");
        }
    }
}