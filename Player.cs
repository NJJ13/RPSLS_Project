using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_project
{
    class Player
    {
        public List<Gesture> selection;
        public Gesture rock = new Rock();
        public Gesture paper = new Paper();
        public Gesture scissors = new Scissor();
        public Gesture lizard = new Lizard();
        public Gesture spock = new Spock();

        public Player()
        {
            selection = new List<Gesture>();
            selection.Add(rock);
            selection.Add(paper);
            selection.Add(scissors);
            selection.Add(lizard);
            selection.Add(spock);
        }
            
    }
}
