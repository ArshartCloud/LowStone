using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lowstone.UI
{
    public class MultiAnimation : LSAnimation
    {
        private List<LSAnimation> subAnis = new List<LSAnimation>();
        private int finishCounter = 0;

        public virtual void Add(LSAnimation ani)
        {
            subAnis.Add(ani);
            ani.callbacks.Add(SubFinish);
        }

        public override void Start()
        {
            base.Start();
            foreach (LSAnimation ani in subAnis)
            {
                ani.Start();
            }
            finishCounter = 0;
        }

        public override void Update()
        {
            base.Update();
            foreach(LSAnimation ani in subAnis)
            {
                ani.Update();
            }
        }

        public override void Finish()
        {
            base.Finish();
        }

        private void SubFinish() {
            finishCounter++;
            if (finishCounter >= subAnis.Count)
            {
                Finish();
            }
        }
    }
}