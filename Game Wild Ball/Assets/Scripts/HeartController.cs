using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall
{
    public class HeartController : MonoBehaviour
    {
        [SerializeField] private Animator heartAnim;
        [SerializeField] private BarrierTrigger ball;

        private void OnTriggerEnter(Collider player)
        {
            if (player.CompareTag("Player") && ball.indexHeart != 0)
            {
                heartAnim.SetBool("TakeHeart", true);
                Destroy(gameObject.GetComponent<BoxCollider>());
            }
        }
    }
}
