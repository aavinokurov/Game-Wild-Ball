using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class SandStormController : MonoBehaviour
{
    [SerializeField] private Rigidbody playerRigidBody;
    [SerializeField] private ParticleSystem sandStormParticle;
    private Vector3 sandForce = new Vector3(10, 0, 0);
    private System.Random rnd = new System.Random();
    private float time;

    private void Start()
    {
        time = rnd.Next(3, 8);
        StartCoroutine(sandStromTimer());
    }

    private IEnumerator sandStromTimer()
    {
        yield return new WaitForSeconds(time);

        playerRigidBody.AddForce(sandForce);
        sandStormParticle.Play();
        time = rnd.Next(3, 8);
        StartCoroutine(sandStromTimer());
    }    
}
