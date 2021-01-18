using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_project
{
    public class Lizard : Gesture
    {
        public Lizard()
        {
          
            Name = "Lizard";
            beats = new List<string>();
            beats.Add("Spock");
            beats.Add("Paper");
            
        }
    }
}
