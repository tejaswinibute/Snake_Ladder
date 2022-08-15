

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder
{
    class PlayerWonGame
    {
        public class Throw
        {
            public int Rollingdie;
            public int option;
            //public int player1, player2;
            public void Roll1()
            {

                Random random = new Random();

                Rollingdie = random.Next(1, 7);
                // Console.WriteLine("ROLL THE DICE  : " + Rollingdie);

                Random random1 = new Random();
                option = random1.Next(0, 3);
                //Console.WriteLine("CHECKING THE OPTIONS  : " + option);

            }
        }
        public static void Main(string[] args)
        {
            int dice1, dice2, check1, check2;
            int position1 = 0, position2 = 0;
            int temp1 = 0, temp2 = 0;


        cont:
            for (int i = 0; i <= 100; i++)
            {
            rep:
                Throw myObj1 = new Throw();
                myObj1.Roll1();
                dice1 = myObj1.Rollingdie;
                dice2 = myObj1.Rollingdie;

                Throw myObj2 = new Throw();
                myObj2.Roll1();
                check1 = myObj2.option;
                check2 = myObj2.option;

                position1 += dice1;
                position2 += dice2;

                {
                    if (check1 == 0 || check2 == 0)//same
                    {
                        goto rep;
                    }

                    else if (check1 == 1 || check2 == 1)//ladder
                    {
                        goto rep;
                    }
                    else//snake
                    {
                        position1 -= dice1;
                        position2 += dice2;
                        if (position1 < 0 || position2 < 0)
                        {
                            goto cont;
                        }
                    }
                }
                temp1 = position1;
                temp2 = position2;
                if (temp1 == 100)
                {

                    goto calc;
                }
                else if (temp2 == 100)
                {

                    goto calc;
                }
                else
                {
                    goto rep;
                }
            }
        calc:

            Console.WriteLine("PLAYER_1 POSITION" + temp1);
            Console.WriteLine("PLAYER_2 POSITION" + temp2);
            if (temp1.CompareTo(temp2) > 0)
            {
                Console.WriteLine("PLAYER_1 WON THE GAME :" + temp1);
            }
            if (temp1.CompareTo(temp2) < 0)

            {
                Console.WriteLine("PLAYER 2 WON THE GAME :" + temp2);
            }



        }



    }
}