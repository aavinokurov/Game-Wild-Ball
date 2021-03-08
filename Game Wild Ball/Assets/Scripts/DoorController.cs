using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall
{
    public class DoorController : MonoBehaviour
    {
        [SerializeField] private BarrierTrigger ball;
        [SerializeField] private GameObject doorClosed;

        private void OnTriggerEnter(Collider player)
        {
            if(player.CompareTag("Player") && ball.haveKey)
            {
                doorClosed.SetActive(false);
            }
        }
    }
}
