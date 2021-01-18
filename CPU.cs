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

        public CPU()
        {
            random = new Random();
        }
        

        public override int GestureSelection()
        {
            int CPUGS = random.Next(selection.Count);
            return CPUGS;
        }
    }
}
