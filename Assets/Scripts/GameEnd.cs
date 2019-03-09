using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    
    public GameObject gameEndPanel;
    public GameObject playerShip;

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1; //При старте устанавливаю нормальное время..
        playerShip = GameObject.Find("playerShip");
    }

    // Update is called once per frame
    void Update()
    {
        //Если здоровье меньше или равно 0, тогда останавливаем время и открываем панель..
        if (playerShip.GetComponent<PlayerHealth>().currentHealth <= 0)
        {
            Time.timeScale = 0;                                              
            gameEndPanel.SetActive(true);
        }
    }

    public void TryAgain()
    {
        //Загружаем сцену с игрой
        SceneManager.LoadScene(1);
    }

    public void exitToMenu()
    {
        SceneManager.LoadScene(0); //Возвращаем время и загружаем сцену с меню
    }
    
}
