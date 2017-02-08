using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Lowstone.UI.Animation
{
    public class UIDelay : LSAnimation
    {
        public float gap;

        private float startTime;


        public override void Start()
        {
            startTime = Time.time;
        }

        public override void Update()
        {
            float delta = Time.time - startTime;
            if (delta > gap)
            {
                Finish();
            }
        }
    }
}
