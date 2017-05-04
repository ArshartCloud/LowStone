using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lowstone.UI
{
    public class UIZone : MonoBehaviour
    {
    
        public int MAXSIZE = 10;

        public List<Transform> CardPos;

        public List<UICard> Cards
        {
            get
            {
                return m_cards;
            }
        }

        public int count
        {
            get
            {
                return Cards.Count;
            }
        }

        protected List<UICard> m_cards = new List<UICard>();


        /// <summary>
        /// Add the transform of card to hand.
        /// Adjust the position of all hand cards.
        /// </summary>
        /// <param name="go"></param>
        public virtual void Add(UICard card)
        {
            Cards.Add(card);
        }

    }
}