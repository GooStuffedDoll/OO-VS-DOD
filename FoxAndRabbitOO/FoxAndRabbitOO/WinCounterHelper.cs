namespace FoxAndRabbitOO
{
    class WinCounterHelper
    {
        public static bool addWinsToCounter(AnimalBase animal)
        {
            if (animal.Name.ToLower() == "fox")
            {
                if (animal.AmountOfWins > 0)
                {
                    WinCounter.foxWins++;
                    animal.AmountOfWins = 0;
                    return true;
                }

                return false;
            }

            if (animal.Name.ToLower() == "wolf")
            {
                if (animal.AmountOfWins > 0)
                {
                    WinCounter.wolfWins++;
                    animal.AmountOfWins = 0;
                    return true;
                }

                return false;
            }

            if (animal.Name.ToLower() == "deer")
            {
                if (animal.AmountOfWins > 0)
                {
                    WinCounter.deerWins++;
                    animal.AmountOfWins = 0;
                    return true;
                }

                return false;
            }

            if (animal.Name.ToLower() == "rabbit")
            {
                if (animal.AmountOfWins > 0)
                {
                    WinCounter.rabbitWins++;
                    animal.AmountOfWins = 0;
                    return true;
                }

                return false;
            }

            return false;
        }
    }
}