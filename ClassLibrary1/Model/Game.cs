using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Model
{
    public class Game : Karts
    {
        public Game()
        {
            base.karts = new List<Kart>();
            base.Create();

        }
        public List<Player> players;

        public void CreatePlayers(int count = 2)
        {
            if (count < 2)
            {
                throw new Exception("Не могут играть меньше двух игроков!");
            }
            for (int i = 0; i < count; i++)
            {
                Player p = new Player();
                p.Id = i;
                p.Name = "Player" + i;
                players.Add(p);
            }
        }

        public void Razdacha()
        {
            int p = 0;//players.Count;
            foreach (Kart item in karts)
            {
                if (p == players.Count - 1)
                {
                    p = 0;
                }

                players[p++].pKarts.Push(item);
            }
        }

        public Player StartGame()
        {
            CreatePlayers();
            Razdacha();
            int maxCard = 0;
            Player winner = null;

            Dictionary<Player, Kart> table = new Dictionary<Player, Kart>();
            while (!players.Any(a => a.pKarts.Count == 36))
            {
                table = new Dictionary<Player, Kart>();
                maxCard = 0;
                winner = null;

                foreach (Player p in players)
                {
                    p.printInfo();
                    table.Add(p, p.pKarts.Pop());
                }

                Console.WriteLine();
                foreach (var item in table)
                {
                    if ((int)item.Value.Naminal > maxCard)
                    {
                        maxCard = (int)item.Value.Naminal;
                        winner = item.Key;
                    }
                }
                foreach (var item in table)
                {
                    players[winner.Id].pKarts.Push(item.Value);
                }        
            }
            return players.FirstOrDefault(f => f.pKarts.Count == 36);
        }
    }
}
