using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_project
{
    public class Rock : Gesture
    {
        public Gesture scissors = new Scissor();
        public Gesture lizard = new Lizard();
        
        public Rock()
        {
            Name = "Rock";
            beats = new List<Gesture>();
            beats.Add(scissors);
            beats.Add(lizard);

            
            
        }
    }
}
