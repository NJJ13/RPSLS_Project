using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_project
{
    class CPU : Player
    {
        public Random random;

        public override int GestureSelection()
        {
           return random.Next(gestureArray.Length);
        }
    }
}
