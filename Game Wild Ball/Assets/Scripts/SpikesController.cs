using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesController : MonoBehaviour
{
    [SerializeField] private Animator spikesAnimator;
    private static System.Random rnd = new System.Random();
    private int numAnimation = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RandomNum"))
        {
            numAnimation = rnd.Next(0, 2);
            spikesAnimator.SetInteger("RandomNum", numAnimation);
        }
    }
}
