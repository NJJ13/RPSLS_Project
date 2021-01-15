using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_project
{
    public class Spock : Gesture
    {
        public Spock()
        {
            Name = "Spock";
            beats = new List<string>();
            beats.Add("Rock");
            beats.Add("Scissors");
        }
    }
}
