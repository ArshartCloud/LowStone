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
            return go.GetComponent<UICard>();
        }

        public UICard CreatCard(Card card, Transform CardPos)
        {
            UICard uiCard = CreatCard(card);
            uiCard.gameObject.transform.position = CardPos.position;
            uiCard.gameObject.transform.rotation = CardPos.rotation;
            return uiCard;
        }

        public void Remove(UICard uiCard)
        {
            GameObject go = uiCard.gameObject;
            go.SetActive(false);
            UnusedCard.Add(uiCard);
        }
    }
}
