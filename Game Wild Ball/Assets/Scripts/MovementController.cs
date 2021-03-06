using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(Rigidbody))]
    public class MovementController : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float speed = 2;
        [SerializeField] private Rigidbody playerRigidbody;

        public void MovePlayer(Vector3 movement)
        {
            playerRigidbody.AddForce(movement * speed);
        }

#if UNITY_EDITOR

        [ContextMenu("Reset Value")]
        public void ResetVals()
        {
            speed = 2;
        }
#endif
    }
}
