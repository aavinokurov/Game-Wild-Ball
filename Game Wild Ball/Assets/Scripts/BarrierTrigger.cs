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
        [SerializeField] public Image keyImage;
        [SerializeField] private Sprite imgFullKey;
        [SerializeField] public Sprite imgEmptyKey;
        [SerializeField] private Animator ballBarrier;
        [SerializeField] private GameObject gameOverPanel;        
        public bool haveKey;
        public int indexHeart;
        private bool isImmortality = true;
        public float timerStart;
        public int takeHearts;
        public int loseHearts;

        private void Start()
        {
            indexHeart = 0;
            Time.timeScale = 1;
            for (int i = 0; i < Hearts.Length; i++)
            {
                Hearts[i].sprite = imgFullHearts;
            }
            keyImage.sprite = imgEmptyKey;
            haveKey = false;
            timerStart = Time.time;
            takeHearts = 0;
            loseHearts = 0;
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
                loseHearts++;
            }

            if (player.CompareTag("Barrier") && isImmortality && indexHeart == Hearts.Length - 1)
            {
                Time.timeScale = 0;
                gameOverPanel.SetActive(true);
                loseHearts++;
            }

            if(player.CompareTag("Heart") && indexHeart > 0 && indexHeart < Hearts.Length)
            {
                indexHeart--;
                Hearts[indexHeart].sprite = imgFullHearts;
                takeHearts++;
            }

            if(player.CompareTag("Key"))
            {
                haveKey = true;
                keyImage.sprite = imgFullKey;
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
