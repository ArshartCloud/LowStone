using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Lowstone.Model;

namespace Lowstone.UI
{
    public enum UICardShape
    {
        Card,
        Minion
    }

    public class UICard : MonoBehaviour
    {
        public Card card;
        //public int Attack
        //{
        //    get
        //    {

        //    }
        //}

        public Text ManaCostText;
        public Text AttackText;
        public Text HealthText;

        public UICardShape Shape
        {
            get
            {
                return shape;
            }
        }

        protected UICardShape shape = UICardShape.Card;

        public bool IsType(string typeName)
        {
            if (typeName == "Minion")
                return true;
            return false;
        }

        public void TransToMinion()
        {
            // become minion

        }
        

        public void SetCard(Card ncard) {
            card = ncard;
            ManaCostText.text = ncard.ManaCost.ToString();
            if (ncard.Type == CardType.Minion)
            {
                Minion minion = (Minion)ncard;
                AttackText.text = minion.Attack.ToString();
                HealthText.text = minion.Health.ToString();
            }
        }
    }
}
