using UnityEngine;
using System.Collections;

namespace Lowstone.Model
{

    public class CardStatus
    {
        public string name { get; set; }
        public int cost;
        public CardType type;
        public PlayerClass playerClass;
        public Rarity rarity;
        public CardSet set;
        public string text;
        //public
    }
}
