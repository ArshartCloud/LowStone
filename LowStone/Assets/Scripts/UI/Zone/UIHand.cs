using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Assertions;

namespace Lowstone.UI
{
    public class UIHand : UIZone
    {
        //public int MAXSIZE = 10;

        //public List<Transform> HandCardPos;

        public List<UICard> Hands
        {
            get
            {
                return m_hands;
            }
        }

        public int count
        {
            get
            {
                return Hands.Count;
            }
        }

        private List<UICard> m_hands = new List<UICard>();

        void Start()
        {
            MAXSIZE = 10; 
        }

        public Transform GetNewCardPostion()
        {
            //TODO
            return CardPos[1];
        }

        /// <summary>
        /// Add the transform of card to hand.
        /// Adjust the position of all hand cards.
        /// </summary>
        /// <param name="go"></param>
        public override void Add(UICard card)
        {
            
            Assert.IsTrue(Hands.Count < MAXSIZE);

            //UICard card = go.GetComponent<UICard>();
            GameObject go = card.gameObject;
            Hands.Add(card);
            int firstInd = GetFirstCardIndex();

            if (count % 2 == 1)
            {
                MultiAnimation moves = new MultiAnimation();
                for (int i = 0; i < count; ++i)
                {
                    Transform targetPos = CardPos[firstInd + i];
                    LSAnimation move = AnimationFactory.Instance.CreatMove(Hands[i].gameObject, targetPos);
                    go.transform.SetParent(transform);
                    moves.Add(move);
                }
                AnimationManager.Instance.AddAnimation(moves);
            }
            Transform targetPos2 = CardPos[firstInd + count - 1];
            LSAnimation move2 = AnimationFactory.Instance.CreatMove(go, targetPos2);
            go.transform.SetParent(transform);
            AnimationManager.Instance.AddAnimation(move2);
        }

        private int GetFirstCardIndex()
        {
            return (MAXSIZE - count) / 2;
        }
    }
}
