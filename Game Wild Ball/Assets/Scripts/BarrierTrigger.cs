using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace WildBall
{
    public class BarrierTrigger : MonoBehaviour
    {
        [SerializeField] private Image[] Hearts;
        [SerializeField] private Sprite imgFullHearts;
        [SerializeField] private Sprite imgEmptyHearts;
        [SerializeField] private Animator ballBarrier;
        [SerializeField] private GameObject gameOverPanel;
        private int indexHeart;
        private bool isImmortality = true;

        private void Start()
        {
            indexHeart = 0;
            Time.timeScale = 1;
            for (int i = 0; i < Hearts.Length; i++)
            {
                Hearts[i].sprite = imgFullHearts;
            }
        }

        private void OnTriggerEnter(Collider player)
        {
            if (player.CompareTag("Barrier") && isImmortality && indexHeart < Hearts.Length - 1)
            {
                Hearts[indexHeart].sprite = imgEmptyHearts;
                isImmortality = false;
                ballBarrier.SetBool("TriggerBarrier", !isImmortality);
                StartCoroutine(timerImmortality());
                indexHeart++;
            }

            if (player.CompareTag("Barrier") && isImmortality && indexHeart == Hearts.Length - 1)
            {
                Time.timeScale = 0;
                gameOverPanel.SetActive(true);
            }
        }

        private IEnumerator timerImmortality()
        {
            yield return new WaitForSeconds(2);

            isImmortality = true;
            ballBarrier.SetBool("TriggerBarrier", !isImmortality);
        }
    }
}
