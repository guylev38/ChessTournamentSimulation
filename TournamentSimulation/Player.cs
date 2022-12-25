using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSimulation
{
    internal class Player
    {
        private string name;
        private int elo;
        private int points;

        public Player(string name, int elo)
        {
            this.name = name;
            this.elo = elo;
            this.points = 0;
        }

        public string GetName() { return this.name; }
        public int GetElo() { return this.elo; }
        public int GetPoints() { return this.points; }

        public void SetElo(int elo) { this.elo = elo; }
        public void SetPoints(int points) { this.points = points; }
    }
}
