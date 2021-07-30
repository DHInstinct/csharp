using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Assignment_4
{

    
    class Program
    {

        private static Random random;

        static List<Player> GetPlayers(params Player[] player)
        {
            List<Player> players = new List<Player>();

            for(int i = 0; i < player.Length; ++i)
            {
                players.Add(player[i]);
            }
            return players;
        }

        static Program()
        {
            random = new Random();
        }

        static void Main(string[] args)
        {

            Player Walter = new Player("Walter");
            Player Jessie = new Player("Jessie");
            Player Mike = new Player("Mike");
            Player Jimmy = new Player("Jimmy");
            Player Gustavo = new Player("Gustavo");


            List<Player> players = GetPlayers(Walter, Jessie, Mike, Jimmy, Gustavo);

            int rndPlayerNum = random.Next(0, players.Count);
            Stack<int> vs = new Stack<int>(players.Count);



            for(int j = 0; j < 5; ++j)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    if (vs.Contains(rndPlayerNum))
                    {
                        rndPlayerNum = random.Next(0, players.Count);
                        i--;
                        //Thread.Sleep(100);
                    }
                    else
                    {
                        players[i].Game(players[rndPlayerNum]);
                        vs.Push(rndPlayerNum);
                        //Thread.Sleep(100);
                    }
                }
                vs.Clear();
            }


            Console.WriteLine(Walter.GameCounter);
            Console.WriteLine("LEADERBOARDS: ");

            //sorting by number of wins
            var sortedPlayer = from player in players orderby player.Wins descending select player;
            foreach (var player in sortedPlayer)
                Console.WriteLine($"{player.Name} won {player.Wins} and Lost {player.Losses} times and tied:{player.Ties}");

            Console.WriteLine();
            Console.WriteLine("EQUAL WINS AND LOSSES: ");

            //Checking win and loss ties
            var sortedPlayerTies = from player in players where player.Wins == player.Losses  select player;
            foreach (var player in sortedPlayerTies)
                Console.WriteLine($"{player.Name} won {player.Wins} and Lost {player.Losses} times and tied:{player.Ties}");

        }
    }
}
