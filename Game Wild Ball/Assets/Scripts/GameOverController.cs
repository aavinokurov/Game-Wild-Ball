using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall
{
    public class GameOverController : MonoBehaviour
    {
        [SerializeField] private GameObject gameOverPanel;
        public GameObject ball;
        public ParticleSystem destroyingParticle;

        private void OnTriggerEnter(Collider player)
        {
            if (player.CompareTag("Player"))
            {
                destroyingParticle.Play();
                ball.SetActive(false);
                StartCoroutine(timerGameOver());
            }
        }

        public IEnumerator timerGameOver()
        {
            yield return new WaitForSeconds(1);

            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
    }
}
