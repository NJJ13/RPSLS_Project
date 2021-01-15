using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_project
{
    public class Lizard : Gesture
    {
        public Gesture paper = new Paper();
        public Gesture spock = new Spock();
        public Lizard()
        {
            Name = "Lizard";
            beats = new List<Gesture>();
            beats.Add(spock);
            beats.Add(paper);
        }
    }
}
