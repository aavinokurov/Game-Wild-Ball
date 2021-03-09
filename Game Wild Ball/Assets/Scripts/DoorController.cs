using UnityEngine;

namespace WildBall
{
    public class DoorController : MonoBehaviour
    {
        [SerializeField] private BarrierTrigger ball;
        [SerializeField] private GameObject doorClosed;
        [SerializeField] private GameObject haveKeyPanel;
        [SerializeField] private GameObject haveNotKeyPanel;
        private bool openDoor;

        private void OnTriggerEnter(Collider player)
        {
            if(player.CompareTag("Player") && ball.haveKey)
            {
                haveKeyPanel.SetActive(true);
                openDoor = true;
            }

            if(player.CompareTag("Player") && !ball.haveKey)
            {
                haveNotKeyPanel.SetActive(true);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            haveKeyPanel.SetActive(false);
            haveNotKeyPanel.SetActive(false);
            openDoor = false;
        }

        private void FixedUpdate()
        {
            if (Input.GetKeyDown(KeyCode.E) && openDoor)
            {
                doorClosed.SetActive(false);
                ball.haveKey = false;
                ball.keyImage.sprite = ball.imgEmptyKey;
            }
        }
    }
}
