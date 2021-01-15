using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_project
{
    public class Scissor : Gesture
    {
        public Gesture lizard = new Lizard();
        public Gesture paper = new Paper();
        public Scissor()
        {
            Name = "Scissors";
            beats = new List<Gesture>();
            beats.Add(lizard);
            beats.Add(paper);
        }
        
    }
}
