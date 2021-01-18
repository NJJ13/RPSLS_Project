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
        int playerOneScore = 0;
        int playerTwoScore = 0;
        int P1S;
        int P2S;

        public Game()
        {
            string playerSelection;
            do
            {
                Console.WriteLine("How many Players?");
                Console.WriteLine("Demo = 0 Single Player = 1 or Multiplayer = 2");
                playerSelection = Console.ReadLine();

            } while (playerSelection != "0" && playerSelection != "1" && playerSelection != "2");

            if (playerSelection == "0")
            {
                playerOne = new CPU();
                playerOne.playerName = "CPU 1";
                playerTwo = new CPU();
                playerTwo.playerName = "CPU 2";
            }
            else if (playerSelection == "1")
            {
                playerOne = new Human();
                Console.WriteLine("Player 1, please enter your name:");
                playerOne.playerName = Console.ReadLine();
                playerTwo = new CPU();
                playerTwo.playerName = "CPU";
            }
            else if (playerSelection == "2")
            {
                playerOne = new Human();
                Console.WriteLine("Player 1, please enter your name:");
                playerOne.playerName = Console.ReadLine();
                playerTwo = new Human();
                Console.WriteLine("Player 2, please enter your name:");
                playerTwo.playerName = Console.ReadLine();
            }
        }
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!");
            Console.WriteLine("Each player will select an object. The player with the strongest object will win the round.");
            Console.WriteLine("The best of 3 rounds will win the game!");
            Console.WriteLine("Press 1 for the hierarchy details, or press any other key to start.");
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
        public void ThrowGesture()
        {
            P1S = playerOne.GestureSelection();
            P2S = playerTwo.GestureSelection();

            Console.WriteLine(playerOne.playerName + " picked " + playerOne.selection[P1S].Name + " and " + playerTwo.playerName + " picked " + playerTwo.selection[P2S].Name + ".");

        }
        public void Compare(int P1S, int P2S)
        {
            if (playerOne.selection[P1S].beats.Contains(playerTwo.selection[P2S].Name))
            {
                Console.WriteLine(playerOne.selection[P1S].Name + " beats " + playerTwo.selection[P2S].Name + ".");
                Console.WriteLine(playerOne.playerName + " won the round.");
                playerOneScore += 1;
            }
            else if (playerTwo.selection[P2S].beats.Contains(playerOne.selection[P1S].Name))
            {
                Console.WriteLine(playerTwo.selection[P2S].Name + " beats " + playerOne.selection[P1S].Name);
                Console.WriteLine(playerTwo.playerName + " won the round.");
                playerTwoScore += 1;
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }
        public void DisplayWinner()
        {
            if(playerOneScore == 2)
            {
                Console.WriteLine(playerOne.playerName + " has won the game!");
            }
            else if(playerTwoScore == 2)
            {
                Console.WriteLine(playerTwo.playerName + " has won the game!");
            }
        }
        public void RunGame()
        {
            DisplayRules();

            while(playerOneScore < 2 && playerTwoScore < 2)
            {
                ThrowGesture();
                Compare(P1S, P2S);
            }

            DisplayWinner();
            Console.WriteLine("Would you like to play again?");
            Console.WriteLine("Press 1 to restart, or press any other key to quit.");
            string restart = Console.ReadLine();
            if (restart == "1")
            {
                playerOneScore = 0;
                playerTwoScore = 0;
                RunGame();
            }
                       
        }
    }
}
