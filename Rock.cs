using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_project
{
    public class Rock : Gesture
    {
        public Rock()
        {
            Name = "Rock";
            beats = new List<string>();
            beats.Add("Scissors");
            beats.Add("Lizard");

        }
    }
}
