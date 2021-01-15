using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_project
{
    public class Paper : Gesture
    {
        public Paper()
        {
            Name = "Paper";
            beats = new List<Gesture>();
            
        }
    }
}
