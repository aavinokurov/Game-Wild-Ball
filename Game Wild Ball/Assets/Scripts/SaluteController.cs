using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaluteController : MonoBehaviour
{
    [SerializeField] private ParticleSystem[] salute;

    private void OnTriggerEnter(Collider body)
    {
        if(body.CompareTag("Player"))
        {
            for (int i = 0; i < salute.Length; i++)
            {
                salute[i].Play();
            }
        }
    }
}
