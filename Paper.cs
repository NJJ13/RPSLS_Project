using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_project
{
    public class Paper : Gesture
    {
        public Gesture rock = new Rock();
        public Gesture spock = new Spock();

        public Paper()
        {
            Name = "Paper";
            beats = new List<Gesture>();
            beats.Add(rock);
            beats.Add(spock);
            
        }
    }
}
