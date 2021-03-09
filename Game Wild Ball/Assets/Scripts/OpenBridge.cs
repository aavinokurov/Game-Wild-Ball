using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBridge : MonoBehaviour
{
    [SerializeField] private Animator[] bridgeAnim;
    [SerializeField] private Animator handelAnim;

    private void OnTriggerEnter(Collider player)
    {
        if(player.CompareTag("Player"))
        {
            for (int i = 0; i < bridgeAnim.Length; i++)
            {
                bridgeAnim[i].SetBool("StartTrigger", true);
            }
            handelAnim.SetBool("HandelTrigger", true);
        }
    }
}
