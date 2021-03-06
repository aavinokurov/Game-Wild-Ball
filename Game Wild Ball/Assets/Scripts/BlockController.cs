using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BlockController : MonoBehaviour
{
    [SerializeField] private Animator blockAnimator;
    private static System.Random rnd = new System.Random();
    private int numAnimation = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RandomNum"))
        {
            numAnimation = rnd.Next(0, 3);
            blockAnimator.SetInteger("RandomNum", numAnimation);
        }
    }
}
