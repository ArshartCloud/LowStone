using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lowstone.UI.Animation;

namespace Lowstone.UI
{
    public class AnimationFactory : MonoBehaviour
    {

        public static AnimationFactory Instance;
        private const float defaultTimeGap = 0.2f;

        void Start()
        {
            Instance = this;
        }

        public LSAnimation CreatMove(GameObject go, Transform targetPos, float time)
        {
            UIMove ani = new UIMove();
            ani.gameObject = go;
            ani.targetTrans = targetPos;
            ani.gap = time;
            return ani;
        }

        public LSAnimation CreatMove(GameObject go, Transform targetPos)
        {
            return CreatMove(go, targetPos, defaultTimeGap);
        }

        public LSAnimation CreatDelay(float time)
        {
            UIDelay ani = new UIDelay();
            ani.gap = time;
            return ani;
        }
    }
}