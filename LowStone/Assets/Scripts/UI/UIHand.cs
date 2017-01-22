using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Lowstone.UI
{
    public class UIHand : MonoBehaviour
    {
        public List<UICard> hands;
        public List<Transform> handCardPos;

        public Transform GetNewCardPostion()
        {
            //TODO
            return handCardPos[1];
        }

    }
}