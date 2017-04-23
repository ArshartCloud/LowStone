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

        private Queue<LSAnimation> m_anis = new Queue<LSAnimation>();
        private LSAnimation m_currentAni;
        private State m_state;
        //private static AnimationManager _instance;

        void Start()
        {
            Instance = this;
            m_state = State.Idle;
        }

        void Update()
        {
            if (m_state == State.Run)
            {
                if (m_currentAni != null) m_currentAni.Update();
            }
        }

        public void AddAnimation(LSAnimation ani)
        {
            ani.callbacks.Add(AnimationFinish);
            m_anis.Enqueue(ani);
            if (m_state == State.Idle) PlayAnimation();
        }

        private void PlayAnimation() { 
            m_state = State.Run;
            m_currentAni = m_anis.Dequeue();
            m_currentAni.Start();
        }

        private void AnimationFinish()
        {
            if (m_anis.Count == 0)
            {
                m_state = State.Idle;
            } else
            {
                PlayAnimation();
            }
        }
    }
}