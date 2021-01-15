using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_project
{
    public class Spock : Gesture
    {
        public Gesture rock = new Rock();
        public Gesture scissors = new Scissor();
    
        public Spock()
        {
            Name = "Spock";
            beats = new List<Gesture>();
            beats.Add(rock);
            beats.Add(scissors);
        }
    }
}
