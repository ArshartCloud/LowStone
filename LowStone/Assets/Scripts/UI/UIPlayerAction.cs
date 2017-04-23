using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lowstone.UI
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

        private static UIPlayerAction m_instence;

        void Start()
        {
            m_instence = this;
        }

        public void UseCard(UICard card)
        {

        }

        public void UseCard(UICard card, int position) { }
        //public void UseCard(UICard card, UICard target) { }
        //public void UseCard(UICard card, int position, UICard target) { }

        public void Attack(UICard attacker, UICard defender) { }

        public void EndTurn() { }

    }
}