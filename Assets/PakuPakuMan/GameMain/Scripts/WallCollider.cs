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
            int Layer = LayerMask.GetMask("Wall");
            if ((1 << other.gameObject.layer) == Layer)
            {
                hitEvent.Invoke();
            }
        }
    }
}