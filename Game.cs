using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_project
{
    class Game
    {
        Player playerOne;
        Player playerTwo;
        int playerOneScore;
        int playerTwoScore;

        public Game()
        {
            string playerSelection;
            do
            {
                Console.WriteLine("How many Players?");
                Console.WriteLine("Single Player = 1 or Multiplayer = 2");
                playerSelection = Console.ReadLine();

            } while (playerSelection != "1" && playerSelection != "2");
            
            playerOne = new Human();
            if (playerSelection == "1")
            {
                playerTwo = new CPU();
            }
            else if (playerSelection == "2")
            {
                playerTwo = new Human();
            }
        }
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!");
            Console.WriteLine("Each player will select an object. The player with the strongest object will win the round.");
            Console.WriteLine("The best of 3 rounds will win the game!");
            Console.WriteLine("Press 1 for the object's details");
            string detailedRules = Console.ReadLine();
            if (detailedRules == "1")
            {
                Console.WriteLine("Rock crushes Scissors.");
                Console.WriteLine("Scissors cuts Paper.");
                Console.WriteLine("Paper covers Rock.");
                Console.WriteLine("Rock crushes Lizard.");
                Console.WriteLine("Lizard poisons Spock.");
                Console.WriteLine("Spock smashes Scissors.");
                Console.WriteLine("Scissors decapitates Lizard.");
                Console.WriteLine("Lizard eats Paper.");
                Console.WriteLine("Paper disproves Spock.");
                Console.WriteLine("Spock vaporizes Rock.");
            }
                



        }
    }
}
