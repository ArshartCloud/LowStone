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

        List<LSAnimation> animations;


        public void AddAnimation(LSAnimation animation)
        {
            animations.Add(animation);
        }

        private void PlayAnimation() { }
    }
}