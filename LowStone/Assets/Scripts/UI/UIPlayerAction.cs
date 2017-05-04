using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lowstone.UI;

namespace Lowstone
{
    public class UIPlayerAction : MonoBehaviour
    {
        public static UIPlayerAction Instence
        {
            get
            {
                return m_instence;
            }
        }

        public Player Player
        {
            get { return UIManager.Instence.PlayerUI.Player; }
        }

        private static UIPlayerAction m_instence;

        void Awake()
        {
            m_instence = this;
        }

        public void PlayCard(UICard card)
        {
            GameController.Instence.PlayMinion(Player, card.card);
        }

        public void PlayCard(UICard card, int position) { }
        //public void UseCard(UICard card, UICard target) { }
        //public void UseCard(UICard card, int position, UICard target) { }

        public void Attack(UICard attacker, UICard defender) { }

        public void EndTurn() { }

        public void UseHeroPower(UICard card) { }
    }
}