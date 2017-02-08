﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Lowstone.UI
{
    public class UIHand : MonoBehaviour
    {
        public const int MAX_HANDSIZE = 10;

        public List<UICard> Hands;
        public List<Transform> HandCardPos;

        public int count
        {
            get
            {
                return Hands.Count;
            }
        }

        public Transform GetNewCardPostion()
        {
            //TODO
            return HandCardPos[1];
        }


        public void AddNewCard(GameObject go)
        {
            UICard card = go.GetComponent<UICard>();
            Hands.Add(card);
            int firstInd = GetFirstCardIndex();

            if (count % 2 == 1)
            {
                MultiAnimation moves = new MultiAnimation();
                for (int i = 0; i < count; ++i)
                {
                    Transform targetPos = HandCardPos[firstInd + i];
                    LSAnimation move = AnimationFactory.Instance.CreatMove(Hands[i].gameObject, targetPos);
                    go.transform.SetParent(transform);
                    moves.Add(move);
                }
                AnimationManager.Instance.AddAnimation(moves);
            }
            Transform targetPos2 = HandCardPos[firstInd + count - 1];
            LSAnimation move2 = AnimationFactory.Instance.CreatMove(go, targetPos2);
            go.transform.SetParent(transform);
            AnimationManager.Instance.AddAnimation(move2);
        }

        private int GetFirstCardIndex()
        {
            return (MAX_HANDSIZE - count) / 2;
        }
    }
}