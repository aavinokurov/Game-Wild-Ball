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
        private bool isJump;

        public void MovePlayer(Vector3 movement)
        {
            playerRigidbody.AddForce(movement * speed);
        }

        public void JumpPlayer()
        {
            if (isJump)
            {
                isJump = false;
                playerRigidbody.AddForce(Vector3.up, ForceMode.Impulse);
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            isJump = true;
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
