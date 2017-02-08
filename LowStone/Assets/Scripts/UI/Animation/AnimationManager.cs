using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lowstone.UI
{
    public class AnimationManager : MonoBehaviour
    {
        enum State
        {
            Idle,
            Run,
        }

        
        public static AnimationManager Instance;

        private Queue<LSAnimation> anis = new Queue<LSAnimation>();
        private LSAnimation currentAni;
        private State state;
        //private static AnimationManager _instance;

        void Start()
        {
            Instance = this;
            state = State.Idle;
        }

        void Update()
        {
            if (state == State.Run)
            {
                if (currentAni != null) currentAni.Update();
            }
        }

        public void AddAnimation(LSAnimation ani)
        {
            ani.callbacks.Add(AnimationFinish);
            anis.Enqueue(ani);
            if (state == State.Idle) PlayAnimation();
        }

        private void PlayAnimation() { 
            state = State.Run;
            currentAni = anis.Dequeue();
            currentAni.Start();
        }

        private void AnimationFinish()
        {
            if (anis.Count == 0)
            {
                state = State.Idle;
            } else
            {
                PlayAnimation();
            }
        }
    }
}