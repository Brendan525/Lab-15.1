using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_15._1.Models
{
    public class Deck
    {

        public bool success { get; set; }

        public string deck_id { get; set; }

        public string cards { get; set; }

        public string code { get; set; }

        public int value { get; set; }

        public string image { get; set; }

        public string suit { get; set; }

        public int remaining { get; set; }

        public bool shuffled { get; set; }
    }
}
