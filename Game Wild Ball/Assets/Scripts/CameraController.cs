using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;

    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - playerTransform.position;
    }

    private void FixedUpdate()
    {
        transform.position = playerTransform.position + offset;
    }
}
