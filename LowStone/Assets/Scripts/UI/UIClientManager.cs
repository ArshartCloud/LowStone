using UnityEngine;
using System.Collections;
namespace Lowstone.UI
{
    public class UIClientManager : UIPlayerManager
    {
        //public UIBoard Board;
        //public UIHand PlayerHand;
        //public UIDeck PlayerDeck;
        //public Transform RightShowTrans;

        public void UseCard(UICard card)
        {

        }

        public void UseCard(UICard card, int position) { }
        //public void UseCard(UICard card, UICard target) { }
        //public void UseCard(UICard card, int position, UICard target) { }

        public void Attack(UICard attacker, UICard defender) { }

        public void EndTurn() { }

        public void DrawCard(Card card)
        {
            GameObject cardObject = PlayerDeck.GetNewCard(card);
            LSAnimation move1 = AnimationFactory.Instance.CreatMove(cardObject, RightShowTrans);
            AnimationManager.Instance.AddAnimation(move1);

            LSAnimation delay = AnimationFactory.Instance.CreatDelay(0.2f);
            AnimationManager.Instance.AddAnimation(delay);

            PlayerHand.AddNewCard(cardObject);
        }

        public void UseMinion(UICard minion)
        {

        }

        //public void DrawCard(int num)
        //{
        //    for (int i = 0; i < num; ++i) DrawCard();
        //}
    }
}