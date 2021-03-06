using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void GoMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadLevel(int numLvl)
    {
        SceneManager.LoadScene(numLvl);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
