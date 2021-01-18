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
            string choice = null;
            while (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5")
            {
                int j = 1;
                Console.WriteLine(playerName + " choose an object to throw (select a number):");
                for (int i = 0; i < selection.Count; i++)
                {
                    Console.WriteLine(j + " " + selection[i].Name);
                    j++;
                }
                choice = Console.ReadLine();
            }
            int gestureInt = int.Parse(choice);
            int P1GS = (gestureInt -= 1);
            return P1GS;
            
        }
    }
}
