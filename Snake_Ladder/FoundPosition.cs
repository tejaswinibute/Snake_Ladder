
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    class FoundPosition
    {
        public class Throw
        {
            public int Rollingdie;
            public int option;

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
            int dice, check;
            int position = 0;
            int temp = 0, count = 0;

        cont:
            for (int i = 0; i <= 100; i++)
            {
                count += i;
            rep:

                Throw myObj1 = new Throw();
                myObj1.Roll1();
                dice = myObj1.Rollingdie;


                Throw myObj2 = new Throw();
                myObj2.Roll1();
                check = myObj2.option;

                position += dice;//ladder
                Console.WriteLine("AFTER EVERY DICE ROLL IN WHAT POSITION " + position);

                {
                    if (check == 0)//same
                    {
                        goto rep;
                    }

                    else//behind
                    {
                        position -= dice;
                        if (position < 0)
                        {
                            goto cont;
                        }
                    }
                }
                temp = position;//5
                if (temp > 100)
                {
                    temp -= dice;//97
                    temp -= 100;

                    goto calc;
                }

            }
        calc:

            Console.WriteLine("EXACT NUMBER THAT ADDS TO GET 100 IS :" + Math.Abs(temp));
            Console.WriteLine("NUMBER OF TIMES DIE ROLL TO WIN THE GAME: " + count);

        }



    }
}
