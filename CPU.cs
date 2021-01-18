using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_project
{
    class CPU : Player
    {
        public override int GestureSelection()
        {
            
            int CPUGS = RNG.RandomNumber(selection.Count);
            return CPUGS;
        }
    }
}
