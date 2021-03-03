namespace FoxAndRabbitOO
{
    public static class StandardMessages
    {
        public static string AnimalWins(AnimalBase animal)
        {
            return $"{animal.Name} has won this Match!";
        }

        public static string AnimalInstantWin(AnimalBase animal)
        {
            return $"OH DAMN, {animal.Name} brutalized it's prey!";
        }
    }
}