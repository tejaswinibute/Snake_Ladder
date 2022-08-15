
namespace Snake_Ladder
{
    class Snake_Ladder
{
    public static void Main(string[] args)
    {
        int store = 0;

        int positions = 0;
        int check, dice;
        int temp;


        Console.WriteLine("REPEAT TILL WINNER REACHES WINNING POSITION :");
    start:
        for (int i = 0; i <= 100; i++)
        {
        rep:
            Throw myObj1 = new Throw();
            myObj1.Roll1();
            dice = myObj1.Rollingdie;


            Throw myObj2 = new Throw();
            myObj2.Roll1();

            check = myObj2.options;


            store = +dice;
            if (check == 0)//same
            {
                goto rep;
            }

            else //behind
            {
                temp = 100 - dice;

            }
            positions += temp;
        }

        if (positions < 0)
        {
            goto start;
        }
        Console.WriteLine(positions);
    }

}
    }


