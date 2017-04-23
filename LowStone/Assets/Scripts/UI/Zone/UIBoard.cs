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
        public List<UIMinion> Minions
        {
            get
            {
                return m_minions;
            }
        }
        public List<Transform> MinionPos
        {
            get
            {
                return m_minionPos;
            }
        }

        private List<UIMinion> m_minions = new List<UIMinion>();
        private List<Transform> m_minionPos = new List<Transform>();

        public void AddMinion(UICard minion)
        {
            AddMinion(minion, MinionNum);
        }

        public void AddMinion(UICard minion, int position) { }
    }
}