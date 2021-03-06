using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall
{
    public class GameOverController : MonoBehaviour
    {
        private void OnTriggerEnter(Collider player)
        {
            if (player.CompareTag("Player"))
            {
                Debug.Log("GameOver!");
            }
        }
    }
}
