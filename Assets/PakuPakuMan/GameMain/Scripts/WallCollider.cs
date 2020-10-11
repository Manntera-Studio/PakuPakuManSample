using System;
using UnityEngine;
using UnityEngine.Events;

namespace GameMain
{
    public class WallCollider : MonoBehaviour
    {
        public UnityEvent hitEvent = new UnityEvent();

        private void OnTriggerStay2D(Collider2D other)
        {
            hitEvent.Invoke();
        }
    }
}