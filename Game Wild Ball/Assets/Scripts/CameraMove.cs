using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs
{
    public class CameraMove : MonoBehaviour
    {
        [SerializeField] private Transform cameraPosition;
        [SerializeField] private CameraController mainCamera;
        [SerializeField] private InputController inputController;

        private void OnTriggerEnter(Collider player)
        {
            if (player.CompareTag("Player"))
            {
                mainCamera.offset = cameraPosition.position - mainCamera.playerTransform.position;
                mainCamera.transform.rotation = Quaternion.Euler(30, -180, 0);
                inputController.forward = false;
            }
        }
    }
}
