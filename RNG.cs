using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_project
{
    public static class RNG
    {
        static Random random = new Random();

        public static int RandomNumber(int gestureOptions)
        {
            int randomNumber = random.Next(gestureOptions);
            return randomNumber;
        }
    }
}
