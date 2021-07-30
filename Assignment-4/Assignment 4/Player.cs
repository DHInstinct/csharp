using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    enum Actions
    {
        Rock,
        Paper,
        Scissors
    }
    public class Player
    {

        private string name;
        private int wins;
        private int losses;
        private int ties;

        private static Random rnd;

        //Must instanitate rnd in a static constructor, so each player object gets a unqine random number seed    
        // if a Random obj is instanitated inside the game function then you will get faux random numbers, this 
        // is because when you create an instance of Random it is automatically seeded at the current timestamp
        // rnd1 and rnd2 would be instatitated in the same timestamp. So just seed the random number when a player 
        // obj is created.


        private int gameCounter;

        public int GameCounter
        {
            get { return gameCounter; }
            set { gameCounter = value; }
        }

        static Player()
        {
            rnd = new Random();
        }

        public Player(string name = "No-Name")
        {
            this.name = name;
        }

        public int Losses
        {
            get { return losses; }
            set { losses = value; }
        }
        public int Wins
        {
            get { return wins; }
            set { wins = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Ties
        {
            get { return ties; }
            set { ties = value; }
        }



        public void Game(Player p2)
        {

            //checks to see if the player is play aganist themselves
            //Console.WriteLine(this.Name);
            //Console.WriteLine(p2.Name);
            if(p2.Name != this.Name)
            {
                GameCounter++;
                
                bool run = true;
                while(run)
                {

                    int random = rnd.Next(0, 3);
                    int random2 = rnd.Next(0, 3);


                    Actions p1Action = (Actions)random;
                    Actions p2Action = (Actions)random2;

                    // Checking if player 1 wins 
                    if (p1Action == Actions.Paper && p2Action == Actions.Rock)
                    {
                        Console.WriteLine($"{this.Name} beats {p2.Name}: Paper Beats Rock");
                        this.Wins++;
                        p2.Losses++;
                        run = false;
                    }

                    else if (p1Action == Actions.Rock && p2Action == Actions.Scissors)
                    {
                        Console.WriteLine($"{this.Name} beats {p2.Name}: Rock beats Scissors");
                        this.Wins++;
                        p2.Losses++;
                        run = false;
                    }

                    else if (p1Action == Actions.Scissors && p2Action == Actions.Paper)
                    {
                        Console.WriteLine($"{this.Name} beats {p2.Name}: Scissors beats Paper");
                        this.Wins++;
                        p2.Losses++;
                        run = false;
                    }

                    // Checking if player 2 wins
                    else if (p2Action == Actions.Paper && p1Action == Actions.Rock)
                    {
                        Console.WriteLine($"{p2.Name} beats {this.Name}: Paper Beats Rock");
                        this.Losses++;
                        p2.Wins++;
                        run = false;
                    }

                    else if (p2Action == Actions.Rock && p1Action == Actions.Scissors)
                    {
                        Console.WriteLine($"{p2.Name} beats {this.Name}: Rock beats Scissors");
                        this.Losses++;
                        p2.Wins++;
                        run = false;
                    }

                    else if (p2Action == Actions.Scissors && p1Action == Actions.Paper)
                    {
                        Console.WriteLine($"{p2.Name} beats {this.Name} : Scissors beats Paper");
                        this.Losses++;
                        p2.Wins++;
                        run = false;
                    }

                    else
                    {
                        Console.WriteLine($"{this.Name} and {p2.Name} tied... replaying");
                        this.Ties++;
                        p2.Ties++;
                    }

                }
            }
            



        }

       
    }
}

