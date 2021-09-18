using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> data;
        

        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Player>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public void AddPlayer(Player player)
        {
            if (data.Count < Capacity)
            {
                data.Add(player);
            }
        }
        public bool RemovePlayer(string name)
        {
            Player player = data.FirstOrDefault(x => x.Name == name);
            if (player == null)
            {
                return false;
            }
            else
            {
                data.Remove(player);
                return true;
            }
        }
        public Player PromotePlayer(string name)
        {
            Player  player = data.First(x => x.Name == name);
            if (player.Rank != "Member")
            {
                player.Rank = "Member";
            }
            return player;
        }
        public Player DemotePlayer(string name)
        {
            Player player = data.First(x => x.Name == name);
            if (player.Rank != "Trial")
            {
                player.Rank = "Trial";
            }
            return player;
        }
        public Player KickPlayersByClass(string @class)
        {
            
               Player player = data.FirstOrDefault(x => x.Class == @class);

                if (player.Class != null)
                {
                    data.RemoveAll(x => x.Class == @class);
                }

            
        }
    }
}
