
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder
{

    public class CheckingPosition
    {
        public int Rollingdie;
        public int options;

        public void Roll1()
        {

            Random random = new Random();

            Rollingdie = random.Next(1, 7);
            Console.WriteLine("ROLL THE DICE  : " + Rollingdie);

            Random random1 = new Random();
            options = random1.Next(0, 2);
            Console.WriteLine("CHECKING THE OPTIONS  : " + options);

        }
    }

}
