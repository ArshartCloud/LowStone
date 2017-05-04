using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lowstone.UI
{
    public class UIBoard : MonoBehaviour
    {

        public const int MAX_MINION_SIZE = 7;
        public int MinionNum
        {
            get
            {
                return Minions.Count;
            }
        }
        public List<Transform> MinionPos;

        public List<UICard> Minions = new List<UICard>();
        //public Battlefield board;

        //private List<UIMinion> m_minions = new List<UIMinion>();
        //public List<Transform> minion_Pos;

        public void AddMinion(UICard minion)
        {
            AddMinion(minion, MinionNum);
        }

        public void AddMinion(UICard minion, int position) {

            int targetInd = position;
            Transform targetTrans = MinionPos[targetInd];
            //need animation
            minion.transform.position = targetTrans.position;
            minion.transform.rotation = targetTrans.rotation;
            minion.transform.localScale = targetTrans.localScale;
            minion.transform.SetParent(transform);

            Minions.Add(minion);
        }
    }
}