using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{
    [SerializeField] private Animator heartAnim;

    private void OnTriggerEnter(Collider player)
    {
        if(player.CompareTag("Player"))
        {
            heartAnim.SetBool("TakeHeart", true);
            Destroy(gameObject, 1.0f);
        }
    }
}
