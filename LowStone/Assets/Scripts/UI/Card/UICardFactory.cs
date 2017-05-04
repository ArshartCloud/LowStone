using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Lowstone.UI
{
    public class UICardFactory : MonoBehaviour
    {

        public static UICardFactory Instance;

        public GameObject UICardPrefab;
        protected List<UICard> UnusedCard = new List<UICard>();

        void Start()
        {
            Instance = this;
        }

        public UICard CreatCard(Card card)
        {
            GameObject go;
            if (UnusedCard.Count == 0)
            {
                go = Instantiate(UICardPrefab);
                go.GetComponent<UICard>().SetCard(card);
                go.SetActive(true);
            } else
            {
                go = UnusedCard[0].gameObject;
                UnusedCard.RemoveAt(0);
                go.GetComponent<UICard>().SetCard(card);
                go.SetActive(true);
            }
            UICard uic = go.GetComponent<UICard>();
            UIManager.Instence.LinkCard(card, uic);
            return uic;
        }

        public UICard CreatCard(Card card, Transform CardPos)
        {
            UICard uiCard = CreatCard(card);
            uiCard.gameObject.transform.position = CardPos.position;
            uiCard.gameObject.transform.rotation = CardPos.rotation;
            return uiCard;
        }

        public UICard CreatCard(Card card, Transform CardPos, Transform parent)
        {
            UICard uiCard = CreatCard(card, CardPos);
            uiCard.gameObject.transform.parent = parent;
            return uiCard;
        }

        public void Remove(Card card)
        {
            UICard uiCard = UIManager.Instence.UICardMap[card];
            GameObject go = uiCard.gameObject;
            go.SetActive(false);
            UnusedCard.Add(uiCard);

            UIManager.Instence.Delink(card);
        }
    }
}
