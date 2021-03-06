using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject menuPanel;
    [SerializeField] private GameObject levelPanel;
    private GameObject currentPanel;

    private void Start()
    {
        currentPanel = menuPanel;
        currentPanel.SetActive(true);
    }

    public void OpenMenuPanel()
    {
        OpenPanel(menuPanel);
    }

    public void OpenLevelPanel()
    {
        OpenPanel(levelPanel);
    }

    private void OpenPanel(GameObject namePanel)
    {
        if (currentPanel != null)
        {
            currentPanel.SetActive(false);
            currentPanel = namePanel;
            currentPanel.SetActive(true);
        }
    }
}
