﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOOps.DeckofCards
{
    class Main
    {
        public void Play()
        {
            Card deckofcards = new Card();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1:Shuffle cards \n2:Distribute cards \n3: Exit Game");
                Console.WriteLine("Enter the your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                ////User Choice
                switch (choice)
                {
                    case 1:
                        deckofcards.shuffleCards();
                        break;
                    case 2:
                        deckofcards.distributeCards();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}
