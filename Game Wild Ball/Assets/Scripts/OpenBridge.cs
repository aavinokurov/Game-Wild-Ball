using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBridge : MonoBehaviour
{
    [SerializeField] private Animator bridgeAnim;

    private void OnTriggerEnter(Collider player)
    {
        if(player.CompareTag("Player"))
        {
            bridgeAnim.SetBool("OpenTrigger", true);
        }
    }
}
