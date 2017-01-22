using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Lowstone.UI
{
    public class LSAnimation : MonoBehaviour
    {
        public Action operation;
        public List<Action> callBacks;
        public bool isIntercept = false;

        public void Finish()
        {
            foreach(Action callBack in callBacks)
            {
                callBack();
            }
        }
    }
}
