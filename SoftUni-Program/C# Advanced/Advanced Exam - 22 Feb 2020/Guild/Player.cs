﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Guild
{
    public class Player
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Rank { get; set; } = "Trial";
        public string Description { get; set; } = "n/a";
        public Player(string name, string class1)
        {
            Name = name;
            Class = class1;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Player {Name}: {Class}");
            sb.AppendLine($"Rank: {Rank}");
            sb.AppendLine($"Description: {Description}");

            return sb.ToString().TrimEnd();
        }
    }
}
