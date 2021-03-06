using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawController : MonoBehaviour
{
    [SerializeField] private Animator sawAnimator;
    private static System.Random rnd = new System.Random();
    private int numAnimation = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RandomNum"))
        {
            numAnimation = rnd.Next(0, 3);
            sawAnimator.SetInteger("RandomNum", numAnimation);
        }
    }
}
