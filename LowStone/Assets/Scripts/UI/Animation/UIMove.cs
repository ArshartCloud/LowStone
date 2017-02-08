using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace Lowstone.UI.Animation
{
    public class UIMove : LSAnimation
    {
        public Transform targetTrans;
        public float gap;

        private Vector3 deltaRot;
        private float startTime;
        private float speedPos;
        private float speedRot;
        private float speedScale;


        public override void Start()
        {
            startTime = Time.time;
            speedPos = Vector3.Distance(transform.position, targetTrans.position) * Time.deltaTime / gap;

            deltaRot = Diff(transform.eulerAngles, targetTrans.eulerAngles) * Time.deltaTime / gap;
            speedScale = Vector3.Distance(transform.localScale, targetTrans.localScale) * Time.deltaTime / gap;
        }

        public override void Update()
        {
            float delta = Time.time - startTime;
            if (delta > gap)
            {
                transform.position = targetTrans.position;
                transform.rotation = targetTrans.rotation;
                transform.localScale = targetTrans.localScale;
                Finish();
            }
            else
            {
                
                transform.position = Vector3.MoveTowards(transform.position, targetTrans.position, speedPos);
                transform.Rotate(deltaRot);
                transform.localScale = Vector3.MoveTowards(transform.localScale, targetTrans.localScale, speedScale);
            }
        }

        private Vector3 Diff(Vector3 a, Vector3 b) {
            Vector3 ans = b - a;
            if (ans.x >  180f)
            {
                ans.x -= 360f;
            } else if (ans.x < -180f)
            {
                ans.x += 360f;
            }
            if (ans.y > 180f)
            {
                ans.y -= 360f;
            } else if (ans.y < -180f)
            {
                ans.y += 360f;
            }
            if (ans.z > 180f)
            {
                ans.z -= 360f;
            } else if (ans.z < -180f)
            {
                ans.z += 360f;
            }
            return ans;
        }
    }
}
