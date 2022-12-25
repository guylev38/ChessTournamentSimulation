using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSimulation
{
    internal class Bracket
    {
        private Player[] players;


        public Bracket(Player[] players)
        {
            this.players = players; 
        }

        public Player[] GetPlayers() { return players; }
        

        public Tuple<Player, Player>[] PairPlayers()
        {
            Tuple<Player, Player>[] pairings = new Tuple<Player, Player>[players.Length/2];

            for(int i=0; i<pairings.Length; i++)
            {
                for(int j=0; j<players.Length; j++)
                {
                    // Pair players by elo rating
                }
            }

            return null; // FIXME
        }
    }
}
