using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_project
{
    class Human : Player
    {
        public override int GestureSelection()
        {
            string selection = null;
            while (selection != "1" && selection != "2" && selection != "3" && selection != "4" && selection != "5")
            {
                Console.WriteLine("Choose an object to throw (select a number):");
                foreach (Gesture name in gestureArray)
                {
                    for (int i = 1; i < 6; i++)
                    {
                        Console.WriteLine(i + name.Name);
                    }
                    
                }
                selection = Console.ReadLine();
            }
            int gestureInt = int.Parse(selection);
            int P1GS = (gestureInt -= 1);
            return P1GS;
            
        }
    }
}
