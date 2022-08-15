using System;
namespace Snake_Ladder
{
    public class DiceRoll
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
            DiceRoll dice = new DiceRoll();
            dice.Rollingdie = random.Next(1, 7);
            dice.roll();
        }
    }
}

