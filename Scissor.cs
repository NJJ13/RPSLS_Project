using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_project
{
    public class Scissor : Gesture
    {
        public Scissor()
        {
            Name = "Scissors";
            beats = new List<Gesture>();
        }
    }
}
