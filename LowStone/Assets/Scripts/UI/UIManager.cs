using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lowstone.UI
{
    public class UIManager : MonoBehaviour
    {
        public UIHand PlayerHand;
        public UIDeck PlayerDeck;
        public Transform RightShowTrans;

        public void UseCard(UICard card) { }
        public void UseCard(UICard card, int position) { }
        //public void UseCard(UICard card, UICard target) { }
        //public void UseCard(UICard card, int position, UICard target) { }

        public void Attack(UICard attacker, UICard defender) { }

        public void EndTurn() { }

        public void DrawCard() {
            GameObject card = PlayerDeck.GetNewCard();
            LSAnimation move1 = AnimationFactory.Instance.CreatMove(card, RightShowTrans);
            AnimationManager.Instance.AddAnimation(move1);

            LSAnimation delay = AnimationFactory.Instance.CreatDelay(0.2f);
            AnimationManager.Instance.AddAnimation(delay);

            PlayerHand.AddNewCard(card);
        }

        public void DrawCard(int num) {
            for (int i = 0; i < num; ++i) DrawCard();
        }
    }
}
