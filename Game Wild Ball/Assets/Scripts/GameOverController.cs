using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall
{
    public class GameOverController : MonoBehaviour
    {
        [SerializeField] private GameObject gameOverPanel;

        private void OnTriggerEnter(Collider player)
        {
            if (player.CompareTag("Player"))
            {
                Time.timeScale = 0;
                gameOverPanel.SetActive(true);
            }
        }
    }
}
