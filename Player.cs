﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_project
{
    public abstract class Player
    {
        public List<Gesture> selection;
        public Rock rock = new Rock();
        public Paper paper = new Paper();
        public Scissor scissors = new Scissor();
        public Lizard lizard = new Lizard();
        public Spock spock = new Spock();
        public string playerName;

        public Player()
        {
            rock = new Rock();
            paper = new Paper();
            scissors = new Scissor();
            lizard = new Lizard();
            spock = new Spock();
            playerName = null;
            selection = new List<Gesture>();
            selection.Add(rock);
            selection.Add(paper);
            selection.Add(scissors);
            selection.Add(lizard);
            selection.Add(spock);
            
        }

        public abstract int GestureSelection();
                   
    }
}
