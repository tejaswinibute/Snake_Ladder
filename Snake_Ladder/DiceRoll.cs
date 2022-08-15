using System;
namespace SnakeLadder
{
    public class Dice
    {
        public int Rollingdie;
        public void roll()
        {
            Console.WriteLine("ROLL THE DICE BETWEEN 1 TO 6: " + Rollingdie);
        }

    }
    class UC2
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Dice dice = new Dice();
            dice.Rollingdie = random.Next(1, 7);
            dice.roll();
        }
    }
}

