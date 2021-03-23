using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall
{
    public class HeartController : MonoBehaviour
    {
        [SerializeField] private Animator heartAnim;
        [SerializeField] private BarrierTrigger ball;
        [SerializeField] private GameObject particleStatic;
        [SerializeField] private ParticleSystem particleTake;

        private void OnTriggerEnter(Collider player)
        {
            if (player.CompareTag("Player") && ball.indexHeart != 0)
            {
                heartAnim.SetBool("TakeHeart", true);
                particleStatic.SetActive(false);
                particleTake.Play();
                Destroy(gameObject.GetComponent<BoxCollider>());
            }
        }
    }
}
