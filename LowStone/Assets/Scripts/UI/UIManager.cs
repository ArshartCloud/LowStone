using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lowstone.UI
{
    public class UIManager : MonoBehaviour
    {
        public UIHand hand;


        public void UseCard(UICard card) { }
        public void UseCard(UICard card, int position) { }
        //public void UseCard(UICard card, UICard target) { }
        //public void UseCard(UICard card, int position, UICard target) { }

        public void Attack(UICard attacker, UICard defender) { }

        public void EndTurn() { }

        public void DrawCard() {
            Transform targetPos = hand.GetNewCardPostion();

        }

        public void DrawCard(int num) {
            for (int i = 0; i < num; ++i) DrawCard();
        }
    }
}
