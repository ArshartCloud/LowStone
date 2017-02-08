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

    }
}