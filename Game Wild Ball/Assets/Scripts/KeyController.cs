using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs
{
    public class KeyController : MonoBehaviour
    {
        [SerializeField] private Animator keyAnim;
        [SerializeField] private Transform cameraPosition;
        [SerializeField] private CameraController mainCamera;
        [SerializeField] private InputController inputController;

        private void OnTriggerEnter(Collider player)
        {
            if (player.CompareTag("Player"))
            {
                keyAnim.SetBool("TakeKey", true);
                Destroy(gameObject, 1.0f);
                mainCamera.offset = cameraPosition.position - mainCamera.playerTransform.position;
                mainCamera.transform.rotation = Quaternion.Euler(30, -180, 0);
                inputController.forward = false;
            }
        }
    }
}
