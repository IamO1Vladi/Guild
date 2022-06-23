using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    class Guild
    {

        public List<Player> Player { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => Player.Count;

        public Guild(string name,int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;

            Player = new List<Player>();
        }


        public void AddPlayer(Player player)
        {
            if (Capacity == Player.Count)
            {

            }
            else
            {
                Player.Add(player);
            }

        }


        public bool RemovePlayer(string name)
        {

            if (Player.Any(x => x.Name == name))
            {
                Player currentPLayer = Player.First(x => x.Name == name);
                Player.Remove(currentPLayer);
                return true;
            }
            else
            {
                return false;
            }

        }

        public void PromotePlayer(string name)
        {

            if (Player.Any(x => x.Name == name))
            {
                Player currentPLayer = Player.First(x => x.Name == name);
                
                if(currentPLayer.Rank!= "Member")
                {
                    currentPLayer.Rank = "Member";
                }
               
            }

        }

        public void DemotePlayer(string name)
        {
            if (Player.Any(x => x.Name == name))
            {
                Player currentPLayer = Player.First(x => x.Name == name);

                if (currentPLayer.Rank != "Trial")
                {
                    currentPLayer.Rank = "Trial";
                }

            }

        }

        public Player[] KickPlayersByClass(string className){

            Player[] removedPlayers = Player.Where(x => x.Class == className).ToArray();
            Player.RemoveAll(x => x.Class == className);

            return removedPlayers;

        }

        public string Report()
        {

            StringBuilder output = new StringBuilder();

            output.AppendLine($"Players in the guild: {this.Name}");

            foreach (var item in Player)
            {
                output.AppendLine(item.ToString());
            }

            return output.ToString().TrimEnd();

        }

    }
}
