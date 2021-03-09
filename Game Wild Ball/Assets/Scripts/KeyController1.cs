using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall
{
    public class KeyController1 : MonoBehaviour
    {
        [SerializeField] private Animator keyAnim;

        private void OnTriggerEnter(Collider player)
        {
            if (player.CompareTag("Player"))
            {
                keyAnim.SetBool("TakeKey", true);
                Destroy(gameObject, 1.0f);
            }
        }
    }
}
