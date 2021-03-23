using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs
{
    public class KeyController : MonoBehaviour
    {
        [SerializeField] private Animator keyAnim;
        [SerializeField] private GameObject particleStatic;
        [SerializeField] private ParticleSystem particleTake;

        private void OnTriggerEnter(Collider player)
        {
            if (player.CompareTag("Player"))
            {
                keyAnim.SetBool("TakeKey", true);
                particleStatic.SetActive(false);
                particleTake.Play();
                Destroy(gameObject, 1.0f);
            }
        }
    }
}
