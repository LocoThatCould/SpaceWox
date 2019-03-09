using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePause : MonoBehaviour
{

    public GameObject pausePanel;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void continueGame()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }

    public void exitToMenu()
    {
        SceneManager.LoadScene(0);
    }
}