using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;



public class MenuScript : MonoBehaviour
{

    public void StartGame()

    {

        SceneManager.LoadScene(1);

    }



    public void LoadGame()

    {



    }



    public void Settings()

    {



    }



    public void ExitGame()

    {

        Application.Quit();

    }

}