using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace WildBall
{
    public class WinController : MonoBehaviour
    {
        [SerializeField] private BarrierTrigger ball;
        [SerializeField] private Text statisticsText;
        [SerializeField] private GameObject winPanel;
        private float timerFinish;

        private void OnTriggerEnter(Collider player)
        {
            if (player.CompareTag("Player"))
            {
                timerFinish = Time.time;
                statisticsText.text = $"{Mathf.Ceil(timerFinish - ball.timerStart)} s\n{ball.loseHearts}\n{ball.takeHearts}";
                Time.timeScale = 0;
                winPanel.SetActive(true);
            }
        }
    }
}
