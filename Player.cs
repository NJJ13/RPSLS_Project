using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_project
{
    public abstract class Player
    {
        public List<Gesture> selection;
        public Gesture rock = new Rock();
        public Gesture paper = new Paper();
        public Gesture scissors = new Scissor();
        public Gesture lizard = new Lizard();
        public Gesture spock = new Spock();
        public Gesture[] gestureArray = new Gesture[5];

        public Player()
        {
            selection = new List<Gesture>();
            selection.Add(rock);
            selection.Add(paper);
            selection.Add(scissors);
            selection.Add(lizard);
            selection.Add(spock);
            gestureArray[0] = rock;
            gestureArray[1] = paper;
            gestureArray[2] = scissors;
            gestureArray[3] = lizard;
            gestureArray[4] = spock;

        }

        public abstract int GestureSelection();
                   
    }
}
