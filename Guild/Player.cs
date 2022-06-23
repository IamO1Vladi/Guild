using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    class Player
    {

//        •	Name: string
//•	Class: string
//•	Rank: string – "Trial" by default
//•	Description: string – "n/a" by default

        public string Name { get; set; }
        public string Class { get; set; }

        public string Rank { get; set; }

        public string Description { get; set; }

        public Player(string name, string className)
        {
            this.Name = name;
            this.Class = className;
            Rank = "Trial";
            Description = "n/a";
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine($"Player {Name}: {Class}");
            output.AppendLine($"Rank: { Rank}");
            output.AppendLine($"Description: {Description}");

            return output.ToString().TrimEnd();

        }
    }
}
