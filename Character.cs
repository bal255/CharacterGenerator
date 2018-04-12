using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterGenerator
{
    class Character
    {

        public int[] generateStats()
        {

            int dice;
            int[] dices = new int[4];
            int[] stats = new int[6];
            int total = 0;
            Random rnd = new Random();

            for (int index = 0; index <= 5; index++)
            {
                for (int i = 0; i <= 3; i++)
                {

                    dice = rnd.Next(1, 6); // creates a number between 1 and 6
                    dices[i] = dice;
                    Array.Sort(dices);
                    total = dices[1] + dices[2] + dices[3];

                }

                stats[index] = total;

            }

            return stats;

        }


    }



}
