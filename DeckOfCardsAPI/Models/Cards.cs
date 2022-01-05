﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeckOfCardsAPI.Models
{   

        public class Hand
        {
            public bool success { get; set; }
            public Card[] cards { get; set; }
            public string deck_id { get; set; }
            public int remaining { get; set; }
        }

        public class Card
        {
            public string image { get; set; }
            public Images images { get; set; }
            public string value { get; set; }
            public string suit { get; set; }
            public string code { get; set; }
        }

        public class Images
        {
            public string svg { get; set; }
            public string png { get; set; }
        }


}
