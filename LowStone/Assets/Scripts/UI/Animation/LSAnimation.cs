using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Lowstone.UI
{
    public class LSAnimation
    {
        public Action operation;
        public List<Action> callbacks = new List<Action>();
        public bool isIntercept = false;

        public GameObject gameObject;

        public Transform transform
        {
            get
            {
                return gameObject.transform;
            }
        }

        public virtual void Finish()
        {
            foreach(Action callBack in callbacks)
            {
                callBack();
            }
        }

        public virtual void Update() { }
        public virtual void Start() { }
    }
}
