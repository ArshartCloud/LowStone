using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lowstone.UI
{
    public class UIDeck : MonoBehaviour
    {
        public Transform DeckPos;


        ///need to be factory
        public GameObject CardPrefab;


        public GameObject GetNewCard()
        {
            //TODO
            GameObject go = Instantiate(CardPrefab, DeckPos.position, DeckPos.rotation, transform);
            go.SetActive(true);
            return go;
        }

        public GameObject GetNewCard(Card card)
        {
            UICard uic = UICardFactory.Instance.CreatCard(card, DeckPos, transform);
            GameObject go = uic.gameObject;
            //GameObject go = Instantiate(CardPrefab, DeckPos.position, DeckPos.rotation, transform);
            go.GetComponent<UICard>().SetCard(card);
            go.SetActive(true);
            return go;
        }

    }
}