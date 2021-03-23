using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall
{
    [RequireComponent(typeof(Rigidbody))]
    public class MovementController : MonoBehaviour
    {
        [Range(0, 10)] public float speed = 1;
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
            speed = 1;
        }
#endif
    }
}
