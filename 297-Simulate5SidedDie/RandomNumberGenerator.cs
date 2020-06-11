using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace _297_Simulate5SidedDie
{
    static class RandomNumberGenerator
    {
        public static int rand7_approach1(Random rnd)
        {
            return rnd.Next(1, 8);   // creates a number between 1 and 7
        }

        public static int rand5_approach1(Random rnd)
        {
            int i = 7;
            while (i > 5)
                i = rand7_approach1(rnd);

            return i;
        }

        public static int rand7_approach2(Random rnd)
        {
            int i = rand7_approach2(rnd, false);
            double d = i / 10;
            int result = int.Parse(Math.Ceiling(d).ToString());

            return result;
        }
        public static int rand7_approach2(Random rnd, bool for5)
        {
            // creates a number between 0 and 69. 
            // As we are dividing result by 10 we want 0.0 -> 0.9 to be the range for each integer
            // doing 1 - 70 / 10 will not give the same mathematical distribution for each integer
            return rnd.Next(0, 70);   
        }

        public static int rand5_approach2(Random rnd)
        {
            int i = rand7_approach2(rnd, true);
            double d = i / 10;
            int result = 0;

            if (d > 0.0 & d <= 1.4) result = 1;
            else if (d > 1.4 & d <= 2.8) result = 2;
            else if (d > 2.8 & d <= 4.2) result = 3;
            else if (d > 4.2 & d <= 5.6) result = 4;
            else if (d > 5.6 & d <= 7.0) result = 5;

            return result;
        }
    }
}
